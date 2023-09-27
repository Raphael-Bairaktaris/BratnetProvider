using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    public class TaxesDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TaxType"/> property
        /// </summary>
        private IEnumerable<TaxType>? mTaxType;

        #endregion

        #region Public Property

        /// <summary>
        /// The tax type
        /// </summary>
        [AllowNull]
        [JsonProperty("taxType")]
        public IEnumerable<TaxType> TaxType 
        { 
            get => mTaxType ?? Enumerable.Empty<TaxType>();
            
            set => mTaxType = value;
        }

        /// <summary>
        /// The tax category
        /// </summary>
        [JsonProperty("taxCategory")]
        public VATCategory TaxCategory { get; set; }

        /// <summary>
        /// The underlying value
        /// Min Value 0
        /// Fraction digits 2
        /// </summary>
        [JsonProperty("underlyingValue")]
        public decimal? UnderlyingValue { get; set; }

        /// <summary>
        /// The tax amount
        /// Min value 0
        /// Fraction digits 2
        /// Required
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Unique tax id
        /// </summary>
        [JsonProperty("id")]
        public byte? TaxId { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxesDataModel()
        {
            
        }

        #endregion
    }
}
