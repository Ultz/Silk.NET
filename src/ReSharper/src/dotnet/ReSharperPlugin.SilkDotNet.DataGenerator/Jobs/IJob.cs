// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace ReSharperPlugin.SilkDotNet.DataGenerator.Jobs
{
    public interface IJob
    {
        bool HasVersionNumbers { get; }
        bool HasDocumentationUrls { get; }
        
        /// <summary>
        /// Collects a mapping of symbol names to the version they were introduced in.
        /// </summary>
        /// <returns>
        /// An enumerable of key-value pairs, where the key is the symbol name and the value the version number that
        /// symbol was introduced in.
        /// </returns>
        IAsyncEnumerable<KeyValuePair<string, Version>> EnumerateVersionNumbers();
        
        /// <summary>
        /// Collects a mapping of symbol names to their documentation URL.
        /// </summary>
        /// <returns>
        /// An enumerable of key-value pairs, where the key is the symbol name and the value is its documentation URL.
        /// </returns>
        IAsyncEnumerable<KeyValuePair<string, string>> EnumerateDocumentationLinks();
    }
}
