// <copyright file="SimpleDate.cs" company="APIMatic">
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
    /// SimpleDate.
    /// </summary>
    public class SimpleDate
    {
        private DateTime? dateNullable;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "dateNullable", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDate"/> class.
        /// </summary>
        public SimpleDate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDate"/> class.
        /// </summary>
        /// <param name="dateNullable">dateNullable.</param>
        /// <param name="date">date.</param>
        public SimpleDate(
            DateTime? dateNullable = null,
            DateTime? date = null)
        {
            if (dateNullable != null)
            {
                this.DateNullable = dateNullable;
            }

            this.Date = date;
        }

        /// <summary>
        /// Gets or sets DateNullable.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateNullable")]
        public DateTime? DateNullable
        {
            get
            {
                return this.dateNullable;
            }

            set
            {
                this.shouldSerialize["dateNullable"] = true;
                this.dateNullable = value;
            }
        }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SimpleDate : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateNullable()
        {
            this.shouldSerialize["dateNullable"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateNullable()
        {
            return this.shouldSerialize["dateNullable"];
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

            return obj is SimpleDate other &&
                ((this.DateNullable == null && other.DateNullable == null) || (this.DateNullable?.Equals(other.DateNullable) == true)) &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateNullable = {(this.DateNullable == null ? "null" : this.DateNullable.ToString())}");
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date.ToString())}");
        }
    }
}