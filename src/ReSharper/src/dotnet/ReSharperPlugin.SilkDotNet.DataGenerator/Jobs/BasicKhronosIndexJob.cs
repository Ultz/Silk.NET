// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace ReSharperPlugin.SilkDotNet.DataGenerator.Jobs
{
    public class BasicKhronosIndexJob : IJob
    {
        internal static ILogger Logger = Program.LoggerProvider.CreateLogger("BasicKhronosIndexJob");

        private readonly string _indexPage;
        private readonly Func<string, string> _getFnDocUrl;

        public BasicKhronosIndexJob(string indexPage, string logPrefix, Func<string, string>? getFnDocUrl = null)
        {
            LogPrefix = $"{logPrefix}: ";
            _indexPage = indexPage;
            _getFnDocUrl = getFnDocUrl;
            if (!_indexPage.EndsWith('/'))
            {
                _indexPage += '/';
            }
        }

        public string LogPrefix { get; }
        public bool HasVersionNumbers { get; } = false;
        public bool HasDocumentationUrls { get; } = true;

        public IAsyncEnumerable<KeyValuePair<string, Version>> EnumerateVersionNumbers()
            => throw new NotSupportedException();

        public async IAsyncEnumerable<KeyValuePair<string, string>> EnumerateDocumentationLinks()
        {
            Logger.LogInformation(LogPrefix + "Downloading index...");
            var doc = (await RemoteFile.GetAsync(_indexPage)).AsHtmlDocument();
            Logger.LogInformation(LogPrefix + "Download complete.");
            var i = 0;
            Logger.LogInformation(LogPrefix + "Looking for documentation URLs...");
            foreach (var tableRow in doc.DocumentNode.Descendants("tr"))
            {
                var data = tableRow.Descendants("td").ToArray();
                if (!tableRow.Descendants("th").Any() && data.Any())
                {
                    var href = data.First()
                        .Descendants("a")
                        .FirstOrDefault
                        (
                            x => x.Attributes.AttributesWithName("alt")
                                .All
                                (
                                    y => y.Value != "[PARENTDIR]" &&
                                         y.Value != "[DIR]"
                                )
                        )
                        ?.Attributes.AttributesWithName("href")
                        .FirstOrDefault()
                        ?.Value;
                    if (!string.IsNullOrWhiteSpace(href))
                    {
                        i++;
                        yield return new
                        (
                            Path.GetFileNameWithoutExtension(href),
                            _getFnDocUrl is null
                                ? _indexPage + href
                                : _getFnDocUrl(Path.GetFileNameWithoutExtension(href))
                        );
                    }
                }
            }

            Logger.LogInformation(LogPrefix + $"Found documentation URLs for {i} symbols.");
        }
    }
}
