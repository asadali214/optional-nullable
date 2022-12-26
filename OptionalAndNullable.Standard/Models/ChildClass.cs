// <copyright file="ChildClass.cs" company="APIMatic">
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
    /// ChildClass.
    /// </summary>
    public class ChildClass : ParentClass
    {
        private string optionalNullable;
        private string optionalNullableWithDefaultValue;
        private List<Models.ChildClass> childClassArray;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Optional_Nullable", false },
            { "Optional_Nullable_With_Default_Value", true },
            { "Child_Class_Array", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildClass"/> class.
        /// </summary>
        public ChildClass()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildClass"/> class.
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
        /// <param name="optionalNullable">Optional_Nullable.</param>
        /// <param name="optionalNullableWithDefaultValue">Optional_Nullable_With_Default_Value.</param>
        /// <param name="optional">Optional.</param>
        /// <param name="requiredNullable">Required_Nullable.</param>
        /// <param name="childClassArray">Child_Class_Array.</param>
        public ChildClass(
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
            string optionalNullable = null,
            string optionalNullableWithDefaultValue = "With default value",
            string optional = null,
            string requiredNullable = null,
            List<Models.ChildClass> childClassArray = null)
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
            if (optionalNullable != null)
            {
                this.OptionalNullable = optionalNullable;
            }

            this.OptionalNullableWithDefaultValue = optionalNullableWithDefaultValue;
            this.Optional = optional;
            this.RequiredNullable = requiredNullable;
            this.Required = required;
            if (childClassArray != null)
            {
                this.ChildClassArray = childClassArray;
            }

        }

        /// <summary>
        /// Gets or sets OptionalNullable.
        /// </summary>
        [JsonProperty("Optional_Nullable")]
        public string OptionalNullable
        {
            get
            {
                return this.optionalNullable;
            }

            set
            {
                this.shouldSerialize["Optional_Nullable"] = true;
                this.optionalNullable = value;
            }
        }

        /// <summary>
        /// Gets or sets OptionalNullableWithDefaultValue.
        /// </summary>
        [JsonProperty("Optional_Nullable_With_Default_Value")]
        public string OptionalNullableWithDefaultValue
        {
            get
            {
                return this.optionalNullableWithDefaultValue;
            }

            set
            {
                this.shouldSerialize["Optional_Nullable_With_Default_Value"] = true;
                this.optionalNullableWithDefaultValue = value;
            }
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

        /// <summary>
        /// Gets or sets ChildClassArray.
        /// </summary>
        [JsonProperty("Child_Class_Array")]
        public List<Models.ChildClass> ChildClassArray
        {
            get
            {
                return this.childClassArray;
            }

            set
            {
                this.shouldSerialize["Child_Class_Array"] = true;
                this.childClassArray = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChildClass : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOptionalNullable()
        {
            this.shouldSerialize["Optional_Nullable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOptionalNullableWithDefaultValue()
        {
            this.shouldSerialize["Optional_Nullable_With_Default_Value"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetChildClassArray()
        {
            this.shouldSerialize["Child_Class_Array"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOptionalNullable()
        {
            return this.shouldSerialize["Optional_Nullable"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOptionalNullableWithDefaultValue()
        {
            return this.shouldSerialize["Optional_Nullable_With_Default_Value"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChildClassArray()
        {
            return this.shouldSerialize["Child_Class_Array"];
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

            return obj is ChildClass other &&
                ((this.OptionalNullable == null && other.OptionalNullable == null) || (this.OptionalNullable?.Equals(other.OptionalNullable) == true)) &&
                ((this.OptionalNullableWithDefaultValue == null && other.OptionalNullableWithDefaultValue == null) || (this.OptionalNullableWithDefaultValue?.Equals(other.OptionalNullableWithDefaultValue) == true)) &&
                ((this.Optional == null && other.Optional == null) || (this.Optional?.Equals(other.Optional) == true)) &&
                ((this.RequiredNullable == null && other.RequiredNullable == null) || (this.RequiredNullable?.Equals(other.RequiredNullable) == true)) &&
                ((this.Required == null && other.Required == null) || (this.Required?.Equals(other.Required) == true)) &&
                ((this.ChildClassArray == null && other.ChildClassArray == null) || (this.ChildClassArray?.Equals(other.ChildClassArray) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OptionalNullable = {(this.OptionalNullable == null ? "null" : this.OptionalNullable == string.Empty ? "" : this.OptionalNullable)}");
            toStringOutput.Add($"this.OptionalNullableWithDefaultValue = {(this.OptionalNullableWithDefaultValue == null ? "null" : this.OptionalNullableWithDefaultValue == string.Empty ? "" : this.OptionalNullableWithDefaultValue)}");
            toStringOutput.Add($"this.Optional = {(this.Optional == null ? "null" : this.Optional == string.Empty ? "" : this.Optional)}");
            toStringOutput.Add($"this.RequiredNullable = {(this.RequiredNullable == null ? "null" : this.RequiredNullable == string.Empty ? "" : this.RequiredNullable)}");
            toStringOutput.Add($"this.Required = {(this.Required == null ? "null" : this.Required == string.Empty ? "" : this.Required)}");
            toStringOutput.Add($"this.ChildClassArray = {(this.ChildClassArray == null ? "null" : $"[{string.Join(", ", this.ChildClassArray)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}