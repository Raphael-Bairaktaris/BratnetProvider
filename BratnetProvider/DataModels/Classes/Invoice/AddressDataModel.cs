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
    /// Represents an address data
    /// </summary>
    public class AddressDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PostalCode"/> property
        /// </summary>
        private string? mPostalCode;

        /// <summary>
        /// The member of the <see cref="City"/> property
        /// </summary>
        private string? mCity;

        #endregion

        #region Public Property

        /// <summary>
        /// The postal code
        /// </summary>
        [AllowNull]
        [JsonProperty("postalCode")]
        public string PostalCode 
        { 
            get => mPostalCode ?? string.Empty; 

            set => mPostalCode = value;
        }

        /// <summary>
        /// The city name
        /// </summary>
        [AllowNull]
        [JsonProperty("city")]
        public string City 
        { 
            get => mCity ?? string.Empty;

            set => mCity = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressDataModel()
        {
            
        }

        #endregion
    }
}
