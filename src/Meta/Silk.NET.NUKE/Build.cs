using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.IO.FileSystemTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);

    static int IndexOfOrThrow(string x, char y)
    {
        var idx = x.IndexOf(y);
        if (idx == -1)
        {
            throw new ArgumentException();
        }

        return idx;
    }

    bool HasDesktopMsBuild
    {
        get
        {
            if (ForceDotnet)
            {
                return false;
            }
            
            try
            {
                MSBuildToolPathResolver.Resolve(); // throws if it can't find msbuild
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
    bool HasProcessedSolutions { get; set; }
    bool HasProcessedProperties { get; set; }

    [Parameter("The feature sets to build - Could include Core, iOS, or Android. Any projects that aren't " +
               "categorized into a feature set will always be built.")]
    string[] FeatureSets = {"core"};

    [Parameter("Forces the build system to use \"dotnet build\" instead of \"msbuild\" if available.")]
    readonly bool ForceDotnet;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

    [Parameter("The API key used to push packages and symbols packages to NuGet")] readonly string NugetApiKey;
    [Parameter("NuGet -NoServiceEndpoint")] readonly bool NugetNoServiceEndpoint;
    [Parameter("NuGet feed")] readonly string NugetFeed = "https://api.nuget.org/v3/index.json";
    [Parameter("NuGet username")] readonly string NugetUsername;
    [Parameter("NuGet password")] readonly string NugetPassword;
    [Parameter("Extra properties passed to MSBuild commands")]
    readonly string[] MsbuildProperties = Array.Empty<string>(); 

    [Solution] readonly Solution Solution;

    Solution ProcessedSolution
    {
        get
        {
            if (!HasProcessedSolutions)
            {
                Projects.ProcessSolution(Solution, FeatureSets, HasDesktopMsBuild);
                HasProcessedSolutions = true;
            }
            
            return Solution;
        }
    }

    Dictionary<string, object> ProcessedMsbuildPropertiesValue;
    Dictionary<string, object> ProcessedMsbuildProperties
    {
        get
        {
            if (!HasProcessedProperties)
            {
                ProcessedMsbuildPropertiesValue = MsbuildProperties.ToDictionary
                (
                    x => x.Substring(0, IndexOfOrThrow(x, '=')), x =>
                    {
                        var idx = IndexOfOrThrow(x, '=');
                        return (object) x.Substring(idx + 1, x.Length - idx - 1);
                    }
                );

                ProcessedMsbuildPropertiesValue["Configuration"] = Configuration;
            }

            return ProcessedMsbuildPropertiesValue;
        }
    }

    AbsolutePath SourceDirectory => RootDirectory / "src";

    // ReSharper disable once RedundantEmptyObjectOrCollectionInitializer
    readonly HashSet<string> AllowedExclusions = new()
    {

    };
    
    Target ValidateSolution => _ => _
        .Executes
        (
            () =>
            {
                var files = RootDirectory.GlobFiles("**/*.csproj").ToArray();
                Logger.Info($"Found {files.Length} csproj files in \"{RootDirectory}\"");
                var missedOut = new List<string>();
                foreach (var file in files)
                {
                    var found = false;
                    foreach (var project in Solution.GetProjects("*"))
                    {
                        if (new FileInfo(file).FullName.Equals(new FileInfo(project.Path).FullName))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found && !AllowedExclusions.Contains(Path.GetFileNameWithoutExtension(file)))
                    {
                        Logger.Error
                        (
                            "A project has not been included in the solution and will not be shipped! " +
                            $"\"{file}\" if this is acceptable please add the project name (excluding the path and " +
                            "extension) to the AllowedExclusions array in the NUKE Build.cs file."
                        );
                        
                        missedOut.Add(file);
                    }
                }

                if (missedOut.Any())
                {
                    Logger.Warn("Commands to add these for your convenience:");
                    foreach (var file in missedOut)
                    {
                        Logger.Warn($"dotnet sln \"{Path.GetFileName(Solution.FileName)}\" add \"{file}\"");
                    }

                    ControlFlow.Fail("Action required.");
                }
            }
        );

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            if (!HasProcessedSolutions)
            {
                var slnDir = Path.Combine(Solution.Directory!, "build", "sln");
                if (Directory.Exists(slnDir))
                {
                    Directory.Delete(slnDir, true);
                }
            }
            else
            {
                Logger.Warn
                (
                    "Solution has already been preprocessed prior to the Clean target. " +
                    "Unable to clean the preprocessed solution folder."
                );
            }
            
            
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s.SetTargetPath(ProcessedSolution)
                        .SetTargets("Clean")
                        .SetMaxCpuCount(Environment.ProcessorCount)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
            else
            {
                DotNetClean(s => s.SetProject(ProcessedSolution)
                    .SetConfiguration(Configuration)
                    .SetProperties(ProcessedMsbuildProperties));
            }

            if (Directory.Exists(RootDirectory / "build" / "output_packages"))
            {
                Directory.Delete(RootDirectory / "build" / "output_packages", true);
            }

            Directory.CreateDirectory(RootDirectory / "build" / "output_packages");
            
            if (FeatureSets.Any(x => x.Equals("android", StringComparison.InvariantCultureIgnoreCase)))
            {
                var silkDroid = SourceDirectory / "Windowing" / "Android" / "SilkDroid";
                using var process = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                    ? ProcessTasks.StartProcess("bash", "-c \"./gradlew clean\"", silkDroid)
                    : ProcessTasks.StartProcess("cmd", "/c \".\\gradlew clean\"", silkDroid);
                process.AssertZeroExitCode();
                return process.Output;
            }

            Logger.Warn("Skipping gradlew clean because Android hasn't been specified as a feature set.");
            return default;
        });

    Target Restore => _ => _
        .After(Clean)
        .Executes(() =>
        {
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s
                        .SetTargetPath(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetTargets("Restore")
                        .SetMaxCpuCount(Environment.ProcessorCount)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
            else
            {
                DotNetRestore
                (
                    s => s
                        .SetProjectFile(ProcessedSolution)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
        });

    Target Compile => _ => _
        .DependsOn(Clean, Restore)
        .Executes(() =>
        {
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s
                        .SetTargets("Build")
                        .SetTargetPath(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetMaxCpuCount(Environment.ProcessorCount)
                        .SetNodeReuse(IsLocalBuild)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
            else
            {
                DotNetBuild
                (
                    s => s
                        .SetProjectFile(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetNoRestore(true)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
        });

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes
        (
            () =>
            {
                if (FeatureSets.Any(x => !x.Equals("core", StringComparison.InvariantCultureIgnoreCase)))
                {
                    ControlFlow.Fail("The Test target can currently not run against additional feature sets.");
                }

                foreach (var project in ProcessedSolution.GetProjects("*"))
                {
                    if (project.Name.Contains("tests", StringComparison.InvariantCultureIgnoreCase))
                    {
                        DotNetTest(s => s.SetProjectFile(project));
                    }
                }
            }
        );

    Target RegenerateBindings => _ => _
        .DependsOn(Clean, Restore)
        .Executes
        (
            () =>
            {
                var project = ProcessedSolution.GetProject("Silk.NET.BuildTools");
                if (project == default)
                {
                    Logger.Error("Couldn't find BuildTools in the solution file.");
                    return;
                }

                DotNetRun
                (
                    s => s.SetProjectFile(project)
                        .SetConfiguration("Release")
                        .SetApplicationArguments(Path.Combine(RootDirectory, "generator.json"))
                );
            }
        );

    Target BuildLibSilkDroid => _ => _
        .DependsOn(Clean)
        .Executes
        (
            () =>
            {
                if (!FeatureSets.Any(x => x.Equals("android", StringComparison.InvariantCultureIgnoreCase)))
                {
                    Logger.Warn("Skipping BuildLibSilkDroid because Android hasn't been specified as a feature set.");
                    return default;
                }
                
                var sdl = RootDirectory / "build" / "submodules" / "SDL";
                var silkDroid = SourceDirectory / "Windowing" / "Android" / "SilkDroid";
                var xcopy = new (string, string)[]
                {
                    (sdl / "android-project" / "app" / "src" / "main" / "java",
                        silkDroid / "app" / "src" / "main" / "java"),
                    (sdl, silkDroid / "app" / "jni" / "SDL2")
                };

                foreach (var (from, to) in xcopy)
                {
                    if (!Directory.Exists(from))
                    {
                        ControlFlow.Fail($"\"{from}\" does not exist (did you forget to recursively clone the repo?)");
                    }
                    
                    CopyDirectoryRecursively(from, to, DirectoryExistsPolicy.Merge, FileExistsPolicy.Overwrite);
                }

                using var process = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                    ? ProcessTasks.StartProcess("bash", "-c \"./gradlew build\"", silkDroid)
                    : ProcessTasks.StartProcess("cmd", "/c \".\\gradlew build\"", silkDroid);
                process.AssertZeroExitCode();
                var ret = process.Output;
                CopyFile
                (
                    silkDroid / "app" / "build" / "outputs" / "aar" / "app-release.aar",
                    SourceDirectory / "Windowing" / "Android" / "Silk.NET.Windowing.Sdl.Android" / "Jars" /
                    "app-release.aar",
                    FileExistsPolicy.Overwrite
                );
                return ret;
            }
        );

    Target FullCompile => _ => _
        .DependsOn(BuildLibSilkDroid, RegenerateBindings, Compile);

    Target Pack => _ => _
        .DependsOn(Clean, Restore)
        .After(RegenerateBindings, BuildLibSilkDroid)
        .Executes(() =>
        {
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s
                        .SetTargets("Pack")
                        .SetTargetPath(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetMaxCpuCount(Environment.ProcessorCount)
                        .SetNodeReuse(IsLocalBuild)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
            else
            {
                DotNetPack
                (
                    s => s
                        .SetProject(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetNoRestore(true)
                        .SetProperties(ProcessedMsbuildProperties)
                );
            }
        });

    Target FullPack => _ => _
        .DependsOn(BuildLibSilkDroid, RegenerateBindings, Pack);

    Target PushToNuGet => _ => _
        .DependsOn(Pack)
        .Executes(PushPackages);

    Target FullPushToNuGet => _ => _
        .DependsOn(FullPack, PushToNuGet);

    async Task PushPackages()
    {
        const int rateLimit = 300;
        var allFiles = Directory.GetFiles(RootDirectory / "build" / "output_packages", "*.nupkg")
            .Where(x => Path.GetFileName(x).StartsWith("Silk.NET") || Path.GetFileName(x).StartsWith("Ultz.Native"))
            .Select((x, i) => new {Index = i, Value = x})
            .GroupBy(x => x.Index / rateLimit)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
        var first = true;
        var pushed = 0;
        var feed = NuGetInterface.OpenNuGetFeed(NugetFeed, NugetUsername, NugetPassword);
        var uploadResource = await NuGetInterface.GetUploadResourceAsync(feed);
        var symbolsResource = await NuGetInterface.GetSymbolsUploadResourceAsync(feed);
        var exceptions = new List<Exception>();
        Logger.Info($"Searching for packages in \"{RootDirectory / "build" / "output_packages"}\"...");
        foreach (var files in allFiles)
        {
            if (first)
            {
                first = false;
            }
            else
            {
                await Task.Delay(TimeSpan.FromHours(1));
            }

            foreach (var file in files)
            {
                try
                {
                    await NuGetInterface.UploadPackageAsync
                        (uploadResource, NugetNoServiceEndpoint, file, NugetApiKey, symbolsResource);
                    pushed++;
                }
                catch (Exception ex)
                {
                    if (file.Contains(".Native.")) // native packages have their own update cycle
                    {
                        Logger.Warn(ex);
                    }
                    else
                    {
                        exceptions.Add(new Exception($"Failed to push package \"{file}\"", ex));
                    }
                }
            }
        }

        Logger.Success($"Successfully pushed {pushed} packages.");

        if (exceptions.Count > 0)
        {
            throw new AggregateException(exceptions);
        }
    }
}
