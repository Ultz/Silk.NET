// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;

public static class Projects
{
    // Modify this bit if you want to define another feature set
    public static readonly IReadOnlyList<FeatureSet> FeatureSets = new[]
    {
        new FeatureSet("iOS", true, "Silk.NET.Windowing.Sdl.iOS", "TriangleIOS"),
        new FeatureSet("Android", true, "Silk.NET.Windowing.Sdl.Android", "TriangleDroid", "TriangleDroidUvExperiment"),
        new FeatureSet("NUKE", false, "Silk.NET.NUKE", "Silk.NET.NUKE.SshAgent"), 
    };

    public static void ProcessSolution(Solution originalSolution, string[] featureSets, bool hasDesktopMsBuild)
    {
        foreach (var featureSet in FeatureSets!)
        {
            var featureSetUsed = featureSets.Any
                (x => x.Equals(featureSet.Name, StringComparison.OrdinalIgnoreCase));
            if (featureSetUsed && !hasDesktopMsBuild && featureSet.RequiresDesktopMsBuild)
            {
                throw new NotSupportedException("Desktop MSBuild is not available.");
            }
            
            foreach (var proj in originalSolution.GetProjects("*"))
            {
                if (!featureSetUsed &&
                    featureSet.Projects.Any(x => x.Equals(proj.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    Logger.Trace($"\"{proj.Name}\" will not be built as its feature set \"{featureSet.Name}\" has " +
                                 "not been enabled. To build this project, specify the feature set name when " +
                                 "invoking NUKE.");

                    originalSolution.RemoveProject(proj);
                }
            }
        }

        var slnDir = Path.Combine(originalSolution.Directory!, "build", "sln");
        if (!Directory.Exists(slnDir))
        {
            Directory.CreateDirectory(slnDir);
        }

        var filename = Path.Combine(slnDir, Path.GetRandomFileName() + ".gen.sln");
        originalSolution.SaveAs(filename);
    }

    public struct FeatureSet
    {
        public string Name { get; }
        public bool RequiresDesktopMsBuild { get; }
        public string[] Projects { get; }

        public FeatureSet(string name, bool requiresDesktopMsBuild, params string[] projects)
        {
            Name = name;
            RequiresDesktopMsBuild = requiresDesktopMsBuild;
            Projects = projects;
        }
    }
}
