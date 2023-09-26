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

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private AddressDataModel? mAddress;

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
        public CountryCode Country { get; set; }

        /// <summary>
        /// The branch
        /// </summary>
        [JsonProperty("branch")]
        public uint Branch { get; set; }

        /// <summary>
        /// The address data model
        /// </summary>
        [JsonProperty("address")]
        public AddressDataModel Address
        {
            get => mAddress ??= new();

            set => mAddress = value;
        }

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
