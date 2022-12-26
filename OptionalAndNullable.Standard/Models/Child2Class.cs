// <copyright file="Child2Class.cs" company="APIMatic">
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
    /// Child2Class.
    /// </summary>
    public class Child2Class : ParentClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Child2Class"/> class.
        /// </summary>
        public Child2Class()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Child2Class"/> class.
        /// </summary>
        /// <param name="grandParentRequired">Grand_Parent_Required.</param>
        /// <param name="parentRequired">Parent_Required.</param>
        /// <param name="required">Required.</param>
        /// <param name="grandParentOptional">Grand_Parent_Optional.</param>
        /// <param name="grandParentRequiredNullable">Grand_Parent_Required_Nullable.</param>
        /// <param name="mClass">class.</param>
        /// <param name="precision">precision.</param>
        /// <param name="bigDecimal">Big_Decimal.</param>
        /// <param name="parentOptionalNullableWithDefaultValue">Parent_Optional_Nullable_With_Default_Value.</param>
        /// <param name="parentOptional">Parent_Optional.</param>
        /// <param name="parentRequiredNullable">Parent_Required_Nullable.</param>
        /// <param name="optional">Optional.</param>
        /// <param name="requiredNullable">Required_Nullable.</param>
        public Child2Class(
            string grandParentRequired,
            string parentRequired,
            string required,
            string grandParentOptional = null,
            string grandParentRequiredNullable = null,
            int? mClass = 23,
            double? precision = null,
            double? bigDecimal = null,
            string parentOptionalNullableWithDefaultValue = "Has default value",
            string parentOptional = null,
            string parentRequiredNullable = null,
            string optional = null,
            string requiredNullable = null)
            : base(
                grandParentRequired,
                parentRequired,
                grandParentOptional,
                grandParentRequiredNullable,
                mClass,
                precision,
                bigDecimal,
                parentOptionalNullableWithDefaultValue,
                parentOptional,
                parentRequiredNullable)
        {
            this.Optional = optional;
            this.RequiredNullable = requiredNullable;
            this.Required = required;
        }

        /// <summary>
        /// Gets or sets Optional.
        /// </summary>
        [JsonProperty("Optional", NullValueHandling = NullValueHandling.Ignore)]
        public string Optional { get; set; }

        /// <summary>
        /// Gets or sets RequiredNullable.
        /// </summary>
        [JsonProperty("Required_Nullable", NullValueHandling = NullValueHandling.Include)]
        public string RequiredNullable { get; set; }

        /// <summary>
        /// Gets or sets Required.
        /// </summary>
        [JsonProperty("Required")]
        public string Required { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Child2Class : ({string.Join(", ", toStringOutput)})";
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

            return obj is Child2Class other &&
                ((this.Optional == null && other.Optional == null) || (this.Optional?.Equals(other.Optional) == true)) &&
                ((this.RequiredNullable == null && other.RequiredNullable == null) || (this.RequiredNullable?.Equals(other.RequiredNullable) == true)) &&
                ((this.Required == null && other.Required == null) || (this.Required?.Equals(other.Required) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Optional = {(this.Optional == null ? "null" : this.Optional == string.Empty ? "" : this.Optional)}");
            toStringOutput.Add($"this.RequiredNullable = {(this.RequiredNullable == null ? "null" : this.RequiredNullable == string.Empty ? "" : this.RequiredNullable)}");
            toStringOutput.Add($"this.Required = {(this.Required == null ? "null" : this.Required == string.Empty ? "" : this.Required)}");

            base.ToString(toStringOutput);
        }
    }
}