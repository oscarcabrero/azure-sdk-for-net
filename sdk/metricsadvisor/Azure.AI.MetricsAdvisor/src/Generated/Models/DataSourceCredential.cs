// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataSourceCredential. </summary>
    internal partial class DataSourceCredential
    {
        /// <summary> Initializes a new instance of DataSourceCredential. </summary>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceCredentialName"/> is null. </exception>
        public DataSourceCredential(string dataSourceCredentialName)
        {
            if (dataSourceCredentialName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCredentialName));
            }

            DataSourceCredentialName = dataSourceCredentialName;
        }

        /// <summary> Initializes a new instance of DataSourceCredential. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="dataSourceCredentialId"> Unique id of data source credential. </param>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="dataSourceCredentialDescription"> Description of data source credential. </param>
        internal DataSourceCredential(DataSourceCredentialType dataSourceCredentialType, Guid? dataSourceCredentialId, string dataSourceCredentialName, string dataSourceCredentialDescription)
        {
            DataSourceCredentialType = dataSourceCredentialType;
            DataSourceCredentialId = dataSourceCredentialId;
            DataSourceCredentialName = dataSourceCredentialName;
            DataSourceCredentialDescription = dataSourceCredentialDescription;
        }

        /// <summary> Type of data source credential. </summary>
        internal DataSourceCredentialType DataSourceCredentialType { get; set; }
        /// <summary> Unique id of data source credential. </summary>
        public Guid? DataSourceCredentialId { get; }
        /// <summary> Name of data source credential. </summary>
        public string DataSourceCredentialName { get; set; }
        /// <summary> Description of data source credential. </summary>
        public string DataSourceCredentialDescription { get; set; }
    }
}
