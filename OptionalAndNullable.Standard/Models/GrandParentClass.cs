// <copyright file="GrandParentClass.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace OptionalAndNullable.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using OptionalAndNullable.Standard;
    using OptionalAndNullable.Standard.Utilities;

    /// <summary>
    /// GrandParentClass.
    /// </summary>
    public class GrandParentClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrandParentClass"/> class.
        /// </summary>
        public GrandParentClass()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrandParentClass"/> class.
        /// </summary>
        /// <param name="grandParentRequired">Grand_Parent_Required.</param>
        /// <param name="grandParentOptional">Grand_Parent_Optional.</param>
        /// <param name="grandParentRequiredNullable">Grand_Parent_Required_Nullable.</param>
        public GrandParentClass(
            string grandParentRequired,
            string grandParentOptional = null,
            string grandParentRequiredNullable = null)
        {
            this.GrandParentOptional = grandParentOptional;
            this.GrandParentRequiredNullable = grandParentRequiredNullable;
            this.GrandParentRequired = grandParentRequired;
        }

        /// <summary>
        /// Gets or sets GrandParentOptional.
        /// </summary>
        [JsonProperty("Grand_Parent_Optional", NullValueHandling = NullValueHandling.Ignore)]
        public string GrandParentOptional { get; set; }

        /// <summary>
        /// Gets or sets GrandParentRequiredNullable.
        /// </summary>
        [JsonProperty("Grand_Parent_Required_Nullable", NullValueHandling = NullValueHandling.Include)]
        public string GrandParentRequiredNullable { get; set; }

        /// <summary>
        /// Gets or sets GrandParentRequired.
        /// </summary>
        [JsonProperty("Grand_Parent_Required")]
        public string GrandParentRequired { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GrandParentClass : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GrandParentClass other &&
                ((this.GrandParentOptional == null && other.GrandParentOptional == null) || (this.GrandParentOptional?.Equals(other.GrandParentOptional) == true)) &&
                ((this.GrandParentRequiredNullable == null && other.GrandParentRequiredNullable == null) || (this.GrandParentRequiredNullable?.Equals(other.GrandParentRequiredNullable) == true)) &&
                ((this.GrandParentRequired == null && other.GrandParentRequired == null) || (this.GrandParentRequired?.Equals(other.GrandParentRequired) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GrandParentOptional = {(this.GrandParentOptional == null ? "null" : this.GrandParentOptional == string.Empty ? "" : this.GrandParentOptional)}");
            toStringOutput.Add($"this.GrandParentRequiredNullable = {(this.GrandParentRequiredNullable == null ? "null" : this.GrandParentRequiredNullable == string.Empty ? "" : this.GrandParentRequiredNullable)}");
            toStringOutput.Add($"this.GrandParentRequired = {(this.GrandParentRequired == null ? "null" : this.GrandParentRequired == string.Empty ? "" : this.GrandParentRequired)}");
        }
    }
}