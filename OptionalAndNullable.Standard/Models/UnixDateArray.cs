// <copyright file="UnixDateArray.cs" company="APIMatic">
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
    /// UnixDateArray.
    /// </summary>
    public class UnixDateArray
    {
        private List<DateTime> dateTime;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "dateTime", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UnixDateArray"/> class.
        /// </summary>
        public UnixDateArray()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnixDateArray"/> class.
        /// </summary>
        /// <param name="dateTime1">dateTime1.</param>
        /// <param name="dateTime">dateTime.</param>
        public UnixDateArray(
            List<DateTime> dateTime1,
            List<DateTime> dateTime = null)
        {
            if (dateTime != null)
            {
                this.DateTime = dateTime;
            }

            this.DateTime1 = dateTime1;
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(ListDateTimeConverter), typeof(OptionalAndNullable.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime")]
        public List<DateTime> DateTime
        {
            get
            {
                return this.dateTime;
            }

            set
            {
                this.shouldSerialize["dateTime"] = true;
                this.dateTime = value;
            }
        }

        /// <summary>
        /// Gets or sets DateTime1.
        /// </summary>
        [JsonConverter(typeof(ListDateTimeConverter), typeof(OptionalAndNullable.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime1")]
        public List<DateTime> DateTime1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UnixDateArray : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateTime()
        {
            this.shouldSerialize["dateTime"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateTime()
        {
            return this.shouldSerialize["dateTime"];
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

            return obj is UnixDateArray other &&
                ((this.DateTime == null && other.DateTime == null) || (this.DateTime?.Equals(other.DateTime) == true)) &&
                ((this.DateTime1 == null && other.DateTime1 == null) || (this.DateTime1?.Equals(other.DateTime1) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateTime = {(this.DateTime == null ? "null" : $"[{string.Join(", ", this.DateTime)} ]")}");
            toStringOutput.Add($"this.DateTime1 = {(this.DateTime1 == null ? "null" : $"[{string.Join(", ", this.DateTime1)} ]")}");
        }
    }
}