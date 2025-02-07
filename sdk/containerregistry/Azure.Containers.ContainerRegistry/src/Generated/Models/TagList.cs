// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of tag details. </summary>
    internal partial class TagList
    {
        /// <summary> Initializes a new instance of TagList. </summary>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repository"/> or <paramref name="tagAttributeBases"/> is null. </exception>
        internal TagList(string repository, IEnumerable<TagAttributesBase> tagAttributeBases)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }
            if (tagAttributeBases == null)
            {
                throw new ArgumentNullException(nameof(tagAttributeBases));
            }

            Repository = repository;
            TagAttributeBases = tagAttributeBases.ToList();
        }

        /// <summary> Initializes a new instance of TagList. </summary>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <param name="link"> . </param>
        internal TagList(string repository, IReadOnlyList<TagAttributesBase> tagAttributeBases, string link)
        {
            Repository = repository;
            TagAttributeBases = tagAttributeBases;
            Link = link;
        }

        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> List of tag attribute details. </summary>
        public IReadOnlyList<TagAttributesBase> TagAttributeBases { get; }
        public string Link { get; }
    }
}
