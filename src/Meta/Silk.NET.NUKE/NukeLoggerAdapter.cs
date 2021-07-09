// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol.Core.Types;
using Nuke.Common;
using LogLevel = NuGet.Common.LogLevel;

public class NuGetInterface
{
    public static SourceRepository OpenNuGetFeed(string nuGetRepositoryUrl, string username, string password)
    {
        var providers = new List<Lazy<INuGetResourceProvider>>();
        providers.AddRange(Repository.Provider.GetCoreV3());
        Logger.Info($"Opening feed \"{nuGetRepositoryUrl}\"...");
        var name = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        var packageSource = new PackageSource(nuGetRepositoryUrl, name);
        if (username is not null && password is not null)
        {
            packageSource.Credentials = new PackageSourceCredential(name, username, password, true, "basic");
        }
        return new SourceRepository(packageSource, providers);
    }

    public static async Task<PackageUpdateResource> GetUploadResourceAsync(SourceRepository sourceRepository)
    {
        return await sourceRepository.GetResourceAsync<PackageUpdateResource>();
    }

    public static async Task<SymbolPackageUpdateResourceV3> GetSymbolsUploadResourceAsync
        (SourceRepository sourceRepository)
    {
        return await sourceRepository.GetResourceAsync<SymbolPackageUpdateResourceV3>();
    }

    public static async Task UploadPackageAsync
    (
        PackageUpdateResource uploadResource,
        bool noServiceEndpoint,
        string packagePath,
        string apiKey,
        SymbolPackageUpdateResourceV3 symbolsResource
    )
    {
        if (symbolsResource is not null && IsValidSymbols(packagePath))
        {
            await uploadResource.Push
            (
                packagePath, symbolsResource.SourceUri.ToString(), 600, false, _ => apiKey, _ => apiKey,
                noServiceEndpoint, true, symbolsResource,
                NukeLoggerAdapter.Instance
            );
        }
        else
        {
            await uploadResource.Push
            (
                packagePath, null, 600, false, (param) => apiKey, null, noServiceEndpoint, true, null,
                NukeLoggerAdapter.Instance
            );
        }
    }

    public static bool IsValidSymbols(string pkg)
    {
        if (!File.Exists(Path.GetFileNameWithoutExtension(pkg) + ".snupkg"))
        {
            return false;
        }

        using var archive = new ZipArchive
            (File.OpenRead(Path.GetFileNameWithoutExtension(pkg) + ".snupkg"), ZipArchiveMode.Read);
        foreach (var entry in archive.Entries)
        {
            if (Path.GetExtension(entry.FullName) == ".pdb")
            {
                return true;
            }
        }

        return false;
    }

    public class NukeLoggerAdapter : ILogger
    {
        public static readonly NukeLoggerAdapter Instance = new NukeLoggerAdapter();
        public void LogDebug(string data) => Logger.Trace(data);
        public void LogVerbose(string data) => Logger.Trace(data);
        public void LogInformation(string data) => Logger.Info(data);
        public void LogMinimal(string data) => Logger.Info(data);
        public void LogWarning(string data) => Logger.Warn(data);
        public void LogError(string data) => Logger.Error(data);
        public void LogInformationSummary(string data) => Logger.Info(data);

        public void Log(LogLevel level, string data)
        {
            switch (level)
            {
                case LogLevel.Debug:
                {
                    Logger.Trace(data);
                    break;
                }
                case LogLevel.Verbose:
                {
                    Logger.Trace(data);
                    break;
                }
                case LogLevel.Information:
                {
                    Logger.Info(data);
                    break;
                }
                case LogLevel.Minimal:
                {
                    Logger.Info(data);
                    break;
                }
                case LogLevel.Warning:
                {
                    Logger.Warn(data);
                    break;
                }
                case LogLevel.Error:
                {
                    Logger.Error(data);
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }

        public Task LogAsync(LogLevel level, string data) => Task.Run(() => Log(level, data));

        public void Log(ILogMessage message) => Log
            (message.Level, string.Join(" - ", message.Code, message.ProjectPath, message.Message));

        public Task LogAsync(ILogMessage message) => Task.Run(() => Log(message));
    }
}