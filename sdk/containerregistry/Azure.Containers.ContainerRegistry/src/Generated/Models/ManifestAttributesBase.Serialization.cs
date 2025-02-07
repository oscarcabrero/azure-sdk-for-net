// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestAttributesBase
    {
        internal static ManifestAttributesBase DeserializeManifestAttributesBase(JsonElement element)
        {
            string digest = default;
            Optional<long> imageSize = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<ArtifactArchitecture?> architecture = default;
            Optional<ArtifactOperatingSystem?> os = default;
            Optional<IReadOnlyList<ManifestAttributesManifestReferences>> references = default;
            Optional<IReadOnlyList<string>> tags = default;
            Optional<ContentProperties> changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("digest"))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    imageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("architecture"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        architecture = null;
                        continue;
                    }
                    architecture = new ArtifactArchitecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("os"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        os = null;
                        continue;
                    }
                    os = new ArtifactOperatingSystem(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("references"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManifestAttributesManifestReferences> array = new List<ManifestAttributesManifestReferences>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestAttributesManifestReferences.DeserializeManifestAttributesManifestReferences(item));
                    }
                    references = array;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("changeableAttributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    changeableAttributes = ContentProperties.DeserializeContentProperties(property.Value);
                    continue;
                }
            }
            return new ManifestAttributesBase(digest, Optional.ToNullable(imageSize), Optional.ToNullable(createdTime), Optional.ToNullable(lastUpdateTime), Optional.ToNullable(architecture), Optional.ToNullable(os), Optional.ToList(references), Optional.ToList(tags), changeableAttributes.Value);
        }
    }
}
