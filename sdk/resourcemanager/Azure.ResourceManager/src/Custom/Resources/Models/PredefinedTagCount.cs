﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Tag count. </summary>
    public partial class PredefinedTagCount
    {
        /// <summary> Initializes a new instance of TagCount. </summary>
        internal PredefinedTagCount()
        {
        }

        /// <summary> Initializes a new instance of TagCount. </summary>
        /// <param name="type"> Type of count. </param>
        /// <param name="value"> Value of count. </param>
        internal PredefinedTagCount(string type, int? value)
        {
            Type = type;
            Value = value;
        }

        /// <summary> Type of count. </summary>
        public string Type { get; }
        /// <summary> Value of count. </summary>
        public int? Value { get; }
    }
}
