// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;

namespace ReSharperPlugin.SilkDotNet.DataGenerator.Jobs
{
    public class KhronosXmlJob : IJob
    {
        internal static ILogger Logger = Program.LoggerProvider.CreateLogger("KhronosXmlJob");
        private readonly string _xml;
        private readonly string? _limitApi;

        public KhronosXmlJob(string xml, string limitApi)
        {
            _xml = xml;
            _limitApi = limitApi;
            LoggerPrefix = limitApi + ": ";
        }

        public string LoggerPrefix { get; }
        public bool HasVersionNumbers { get; } = true;
        public bool HasDocumentationUrls { get; } = false;

        public async IAsyncEnumerable<KeyValuePair<string, Version>> EnumerateVersionNumbers()
        {
            Logger.LogInformation($"{LoggerPrefix}Downloading registry...");
            var registry = (await RemoteFile.GetAsync(_xml)).AsXDocument(LoadOptions.SetLineInfo);
            Logger.LogInformation($"{LoggerPrefix}Download complete.");
            var i = 0;
            Logger.LogInformation($"{LoggerPrefix}Looking for version numbers...");
            foreach (var feature in registry.Element("registry")?.Elements("feature") ?? Enumerable.Empty<XElement>())
            {
                var version = feature.Attribute("number")?.Value;
                var api = feature.Attribute("api")?.Value;
                if (version is null)
                {
                    var cursor = (IXmlLineInfo) feature;
                    Logger.LogWarning
                    (
                        $"No \"number\" attribute for \"feature\" element at L{cursor.LineNumber}, " +
                        $"C{cursor.LinePosition}; skipping..."
                    );
                    continue;
                }

                if (api != _limitApi)
                {
                    continue;
                }

                foreach (var symbol in feature.Elements("require").Elements().Attributes("name"))
                {
                    i++;
                    yield return new(symbol.Value, Version.Parse(version));
                }
            }
            
            Logger.LogInformation($"{LoggerPrefix}Found version numbers for {i} symbols. Extensions are not mapped.");
        }

        public IAsyncEnumerable<KeyValuePair<string, string>> EnumerateDocumentationLinks()
            => throw new NotSupportedException();
    }
}
