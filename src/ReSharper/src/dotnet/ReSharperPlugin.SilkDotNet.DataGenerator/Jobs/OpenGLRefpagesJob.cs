// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.Extensions.Logging;

namespace ReSharperPlugin.SilkDotNet.DataGenerator.Jobs
{
    public class OpenGLRefpagesJob : IJob
    {
        internal static ILogger Logger = Program.LoggerProvider.CreateLogger("OpenGLRefpagesJob");
        private const string NamesXPath = "/*[local-name()='refentry']/*[local-name()='refsynopsisdiv']/" +
                                          "*[local-name()='funcsynopsis']/*[local-name()='funcprototype']/" +
                                          "*[local-name()='funcdef']/*[local-name()='function']";

        private readonly string _zipUrl, _profile, _baseUrl;

        public OpenGLRefpagesJob(string zipUrl, string profile, string baseUrl)
        {
            (_zipUrl, _profile, _baseUrl) = (zipUrl, profile, baseUrl);
            if (!_baseUrl.EndsWith('/'))
            {
                _baseUrl += '/';
            }
        }

        public bool HasVersionNumbers { get; } = false;
        public bool HasDocumentationUrls { get; } = true;
        private string LogPrefix => $"{Path.GetFileName(_profile)}: ";

        public IAsyncEnumerable<KeyValuePair<string, Version>> EnumerateVersionNumbers()
            => throw new NotSupportedException();

        public async IAsyncEnumerable<KeyValuePair<string, string>> EnumerateDocumentationLinks()
        {
            Logger.LogInformation(LogPrefix + "Downloading documentation...");
            using var archive = (await RemoteFile.GetAsync(_zipUrl)).AsZipArchive();
            Logger.LogInformation(LogPrefix + "Download complete.");
            var i = 0;
            Logger.LogInformation(LogPrefix + "Looking for documentation URLs...");
            foreach (var entry in archive.Entries)
            {
                if (entry.FullName.StartsWith(_profile) && entry.FullName.EndsWith(".xml"))
                {
                    XDocument doc = null!;
                    KeyValuePair<string, string>? assumed = null;
                    try
                    {
                        await using var stream = entry.Open();
                        doc = XDocument.Load(stream);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogWarning($"{LogPrefix}Failed to load file \"{entry.FullName}\", assuming the file " +
                                          $"name maps 1:1 to the function name. Reason: {ex.Message}");
                        assumed = new
                        (
                            Path.GetFileNameWithoutExtension(entry.Name),
                            $"{_baseUrl}{Path.GetFileNameWithoutExtension(entry.Name)}.xhtml"
                        );
                    }

                    if (assumed is not null)
                    {
                        yield return assumed.Value;
                        continue;
                    }

                    var nameElements = doc!.Root!.XPathEvaluate(NamesXPath);
                    foreach (var xElement in (nameElements as IEnumerable)?.OfType<XElement>() ?? Enumerable.Empty<XElement>())
                    {
                        i++;
                        yield return new
                        (
                            xElement.Value,
                            $"{_baseUrl}{Path.GetFileNameWithoutExtension(entry.Name)}.xhtml"
                        );
                    }
                }
            }

            Logger.LogInformation($"{LogPrefix}Found documentation URLs for {i} symbols.");
        }
    }
}
