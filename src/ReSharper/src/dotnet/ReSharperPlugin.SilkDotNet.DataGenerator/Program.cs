// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ReSharperPlugin.SilkDotNet.DataGenerator.Jobs;
using Ultz.Extensions.Logging;

namespace ReSharperPlugin.SilkDotNet.DataGenerator
{
    internal class Program
    {
        internal static UltzLoggerProvider LoggerProvider = new()
        {
            MessageFormat = "§7[{5:HH}:{5:mm}:{5:ss}] [{1} §9{0}§7] §f{2}"
        };

        internal static ILogger Logger = LoggerProvider.CreateLogger("Core");

        private static async Task Main()
        {
            Console.WriteLine("Silk.NET ReSharper Plugin Data Generator");
            Console.WriteLine("Copyright (c) .NET Foundation and Contributors");
            Console.WriteLine();
            Logger.LogInformation("Collecting...");
            var versionNumbers = new ConcurrentDictionary<string, ConcurrentDictionary<string, Version>>();
            var docUrls = new ConcurrentDictionary<string, ConcurrentDictionary<string, string>>();
            await Task.WhenAll
            (
                Config.Jobs.Select
                    (
                        x => (DoJob(versionNumbers.GetOrAdd(x.Key, _ => new()), docUrls.GetOrAdd(x.Key, _ => new())), x)
                    )
                    .SelectMany(static x => x.x.Value.Select(x.Item1))
            );

            var docUrlSum = docUrls.Sum(x => x.Value.Count);
            var versionNumSum = versionNumbers.Sum(x => x.Value.Count);
            Logger.LogInformation
            (
                $"Collected {docUrlSum + versionNumSum} items. ({docUrlSum} documentation URLs, {versionNumSum} " +
                "version mappings)"
            );

            await Outputs.Output.WriteAsync(docUrls, versionNumbers);
            LoggerProvider.WaitAndShutdown();
        }

        private static Func<IJob, Task> DoJob
        (
            ConcurrentDictionary<string, Version> versionNumbers,
            ConcurrentDictionary<string, string> docUrls
        ) => job => Task.Run
        (
            async () =>
            {
                try
                {
                    if (job.HasDocumentationUrls)
                    {
                        await foreach (var (symbol, url) in job.EnumerateDocumentationLinks())
                        {
                            if (docUrls.GetOrAdd(symbol, url) != url)
                            {
                                Logger.LogWarning
                                (
                                    $"Failed to add URL \"{url}\" for symbol \"{symbol}\" " +
                                    "(has another job handled it?)"
                                );
                            }
                        }
                    }

                    if (job.HasVersionNumbers)
                    {
                        await foreach (var (symbol, version) in job.EnumerateVersionNumbers())
                        {
                            versionNumbers.AddOrUpdate(symbol, version, (_, v) => v > version ? version : v);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError($"{job.GetType().Name} job failed with exception: {ex}");
                }
            }
        );

        internal static string RelativeToConfigFile(string path, [CallerFilePath] string file = default!)
            => Path.Combine(Path.GetDirectoryName(file)!, path);
    }
}
