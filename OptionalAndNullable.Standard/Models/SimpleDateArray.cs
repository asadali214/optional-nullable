// <copyright file="SimpleDateArray.cs" company="APIMatic">
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
    /// SimpleDateArray.
    /// </summary>
    public class SimpleDateArray
    {
        private List<DateTime> date;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDateArray"/> class.
        /// </summary>
        public SimpleDateArray()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDateArray"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="date1">date1.</param>
        public SimpleDateArray(
            List<DateTime> date = null,
            List<DateTime> date1 = null)
        {
            if (date != null)
            {
                this.Date = date;
            }

            this.Date1 = date1;
        }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(ListDateTimeConverter), typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date")]
        public List<DateTime> Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.shouldSerialize["date"] = true;
                this.date = value;
            }
        }

        /// <summary>
        /// Gets or sets Date1.
        /// </summary>
        [JsonConverter(typeof(ListDateTimeConverter), typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date1", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTime> Date1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SimpleDateArray : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDate()
        {
            this.shouldSerialize["date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDate()
        {
            return this.shouldSerialize["date"];
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

            return obj is SimpleDateArray other &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.Date1 == null && other.Date1 == null) || (this.Date1?.Equals(other.Date1) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : $"[{string.Join(", ", this.Date)} ]")}");
            toStringOutput.Add($"this.Date1 = {(this.Date1 == null ? "null" : $"[{string.Join(", ", this.Date1)} ]")}");
        }
    }
}