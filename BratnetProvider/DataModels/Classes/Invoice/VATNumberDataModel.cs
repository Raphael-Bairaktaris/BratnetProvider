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
    /// Represents a vat number data 
    /// </summary>
    public class VATNumberDataModel
    {
        #region Public property

        /// <summary>
        /// The invoice vat number
        /// </summary>
        [JsonProperty("vatNumber")]
        public uint VATNumber { get; set; }

        /// <summary>
        /// The issuer country information
        /// </summary>
        [JsonProperty("country")]
        public CountryCode Country { get; set; } = CountryCode.GR;

        /// <summary>
        /// The issuer branch number
        /// </summary>
        [JsonProperty("branch")]
        public uint Branch { get; set; }

        /// <summary>
        /// The issuer entity name
        /// Max lenght = 150
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The invoice address
        /// </summary>
        [AllowNull]
        [JsonProperty("address")]
        public string? Address { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATNumberDataModel()
        {
            
        }

        #endregion
    }
}
