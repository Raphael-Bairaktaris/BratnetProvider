using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent a counterpart data
    /// </summary>
    public class CounterpartDataModel
    {
        #region Private Members


        #endregion

        #region Public Property

        /// <summary>
        /// The counterpart vat number
        /// </summary>
        [AllowNull]
        [JsonProperty("vatNumber")]
        public string VATNumber { get; set; }

        /// <summary>
        /// The counterpart country information
        /// </summary>
        [AllowNull]
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The counterpart postal code
        /// </summary>
        [AllowNull]
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The counterpart city information
        /// </summary>
        [AllowNull]
        [JsonProperty("city")]
        public string City { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public CounterpartDataModel()
        {
            
        }

        #endregion
    }
}
