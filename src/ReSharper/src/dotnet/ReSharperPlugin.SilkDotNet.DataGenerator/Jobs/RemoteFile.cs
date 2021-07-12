// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using HtmlAgilityPack;

namespace ReSharperPlugin.SilkDotNet.DataGenerator.Jobs
{
    public class RemoteFile
    {
        public static ConcurrentDictionary<string, RemoteFile> Cache { get; } = new();
        public static HttpClient Client { get; } = new();
        
        public static async Task<RemoteFile> GetAsync(string url)
        {
            var ret = Cache.GetOrAdd(url, x => new(x));
            var download = false;
            lock (ret)
            {
                if (ret.OnDownloadResetEvent is null)
                {
                    download = true;
                    ret.OnDownloadResetEvent = new();
                }
            }

            if (download)
            { 
                await ret.DownloadAsync();
            }
            else
            {
                ret.OnDownloadResetEvent.Wait();
            }

            return ret;
        }

        private RemoteFile(string url)
        {
            Url = url;
            PrivateStream = new();
        }

        public string Url { get; set; }
        private MemoryStream PrivateStream { get; set; }

        private ManualResetEventSlim? OnDownloadResetEvent { get; set; }

        private async Task DownloadAsync()
        {
            var s = await Client.GetStreamAsync(Url);
            await s.CopyToAsync(PrivateStream);
            OnDownloadResetEvent!.Set();
        }

        public string AsString(Encoding? encoding = null)
            => (encoding ?? Encoding.UTF8).GetString(PrivateStream.ToArray());

        public byte[] AsBytes() => PrivateStream.ToArray();
        public Stream AsStream() => new MemoryStream(AsBytes());

        public HtmlDocument AsHtmlDocument()
        {
            var ret = new HtmlDocument();
            ret.Load(AsStream());
            return ret;
        }

        public XDocument AsXDocument(LoadOptions options = LoadOptions.None)
        {
            using var stream = AsStream();
            return XDocument.Load(stream, options);
        }

        public ZipArchive AsZipArchive() => new(AsStream(), ZipArchiveMode.Read);
    }
}
