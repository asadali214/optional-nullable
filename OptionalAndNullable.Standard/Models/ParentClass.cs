// <copyright file="ParentClass.cs" company="APIMatic">
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
    /// ParentClass.
    /// </summary>
    public class ParentClass : GrandParentClass
    {
        private int? mClass;
        private double? precision;
        private double? bigDecimal;
        private string parentOptionalNullableWithDefaultValue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "class", true },
            { "precision", false },
            { "Big_Decimal", false },
            { "Parent_Optional_Nullable_With_Default_Value", true },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentClass"/> class.
        /// </summary>
        public ParentClass()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentClass"/> class.
        /// </summary>
        /// <param name="grandParentRequired">Grand_Parent_Required.</param>
        /// <param name="parentRequired">Parent_Required.</param>
        /// <param name="grandParentOptional">Grand_Parent_Optional.</param>
        /// <param name="grandParentRequiredNullable">Grand_Parent_Required_Nullable.</param>
        /// <param name="mClass">class.</param>
        /// <param name="precision">precision.</param>
        /// <param name="bigDecimal">Big_Decimal.</param>
        /// <param name="parentOptionalNullableWithDefaultValue">Parent_Optional_Nullable_With_Default_Value.</param>
        /// <param name="parentOptional">Parent_Optional.</param>
        /// <param name="parentRequiredNullable">Parent_Required_Nullable.</param>
        public ParentClass(
            string grandParentRequired,
            string parentRequired,
            string grandParentOptional = null,
            string grandParentRequiredNullable = null,
            int? mClass = 23,
            double? precision = null,
            double? bigDecimal = null,
            string parentOptionalNullableWithDefaultValue = "Has default value",
            string parentOptional = null,
            string parentRequiredNullable = null)
            : base(
                grandParentRequired,
                grandParentOptional,
                grandParentRequiredNullable)
        {
            this.MClass = mClass;
            if (precision != null)
            {
                this.Precision = precision;
            }

            if (bigDecimal != null)
            {
                this.BigDecimal = bigDecimal;
            }

            this.ParentOptionalNullableWithDefaultValue = parentOptionalNullableWithDefaultValue;
            this.ParentOptional = parentOptional;
            this.ParentRequiredNullable = parentRequiredNullable;
            this.ParentRequired = parentRequired;
        }

        /// <summary>
        /// Gets or sets MClass.
        /// </summary>
        [JsonProperty("class")]
        public int? MClass
        {
            get
            {
                return this.mClass;
            }

            set
            {
                this.shouldSerialize["class"] = true;
                this.mClass = value;
            }
        }

        /// <summary>
        /// Gets or sets Precision.
        /// </summary>
        [JsonProperty("precision")]
        public double? Precision
        {
            get
            {
                return this.precision;
            }

            set
            {
                this.shouldSerialize["precision"] = true;
                this.precision = value;
            }
        }

        /// <summary>
        /// Gets or sets BigDecimal.
        /// </summary>
        [JsonProperty("Big_Decimal")]
        public double? BigDecimal
        {
            get
            {
                return this.bigDecimal;
            }

            set
            {
                this.shouldSerialize["Big_Decimal"] = true;
                this.bigDecimal = value;
            }
        }

        /// <summary>
        /// Gets or sets ParentOptionalNullableWithDefaultValue.
        /// </summary>
        [JsonProperty("Parent_Optional_Nullable_With_Default_Value")]
        public string ParentOptionalNullableWithDefaultValue
        {
            get
            {
                return this.parentOptionalNullableWithDefaultValue;
            }

            set
            {
                this.shouldSerialize["Parent_Optional_Nullable_With_Default_Value"] = true;
                this.parentOptionalNullableWithDefaultValue = value;
            }
        }

        /// <summary>
        /// Gets or sets ParentOptional.
        /// </summary>
        [JsonProperty("Parent_Optional", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOptional { get; set; }

        /// <summary>
        /// Gets or sets ParentRequiredNullable.
        /// </summary>
        [JsonProperty("Parent_Required_Nullable", NullValueHandling = NullValueHandling.Include)]
        public string ParentRequiredNullable { get; set; }

        /// <summary>
        /// Gets or sets ParentRequired.
        /// </summary>
        [JsonProperty("Parent_Required")]
        public string ParentRequired { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ParentClass : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClass()
        {
            this.shouldSerialize["class"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPrecision()
        {
            this.shouldSerialize["precision"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBigDecimal()
        {
            this.shouldSerialize["Big_Decimal"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentOptionalNullableWithDefaultValue()
        {
            this.shouldSerialize["Parent_Optional_Nullable_With_Default_Value"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClass()
        {
            return this.shouldSerialize["class"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrecision()
        {
            return this.shouldSerialize["precision"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBigDecimal()
        {
            return this.shouldSerialize["Big_Decimal"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentOptionalNullableWithDefaultValue()
        {
            return this.shouldSerialize["Parent_Optional_Nullable_With_Default_Value"];
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

            return obj is ParentClass other &&
                ((this.MClass == null && other.MClass == null) || (this.MClass?.Equals(other.MClass) == true)) &&
                ((this.Precision == null && other.Precision == null) || (this.Precision?.Equals(other.Precision) == true)) &&
                ((this.BigDecimal == null && other.BigDecimal == null) || (this.BigDecimal?.Equals(other.BigDecimal) == true)) &&
                ((this.ParentOptionalNullableWithDefaultValue == null && other.ParentOptionalNullableWithDefaultValue == null) || (this.ParentOptionalNullableWithDefaultValue?.Equals(other.ParentOptionalNullableWithDefaultValue) == true)) &&
                ((this.ParentOptional == null && other.ParentOptional == null) || (this.ParentOptional?.Equals(other.ParentOptional) == true)) &&
                ((this.ParentRequiredNullable == null && other.ParentRequiredNullable == null) || (this.ParentRequiredNullable?.Equals(other.ParentRequiredNullable) == true)) &&
                ((this.ParentRequired == null && other.ParentRequired == null) || (this.ParentRequired?.Equals(other.ParentRequired) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MClass = {(this.MClass == null ? "null" : this.MClass.ToString())}");
            toStringOutput.Add($"this.Precision = {(this.Precision == null ? "null" : this.Precision.ToString())}");
            toStringOutput.Add($"this.BigDecimal = {(this.BigDecimal == null ? "null" : this.BigDecimal.ToString())}");
            toStringOutput.Add($"this.ParentOptionalNullableWithDefaultValue = {(this.ParentOptionalNullableWithDefaultValue == null ? "null" : this.ParentOptionalNullableWithDefaultValue == string.Empty ? "" : this.ParentOptionalNullableWithDefaultValue)}");
            toStringOutput.Add($"this.ParentOptional = {(this.ParentOptional == null ? "null" : this.ParentOptional == string.Empty ? "" : this.ParentOptional)}");
            toStringOutput.Add($"this.ParentRequiredNullable = {(this.ParentRequiredNullable == null ? "null" : this.ParentRequiredNullable == string.Empty ? "" : this.ParentRequiredNullable)}");
            toStringOutput.Add($"this.ParentRequired = {(this.ParentRequired == null ? "null" : this.ParentRequired == string.Empty ? "" : this.ParentRequired)}");

            base.ToString(toStringOutput);
        }
    }
}