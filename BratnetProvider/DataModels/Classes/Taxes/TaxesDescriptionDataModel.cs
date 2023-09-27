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
    /// Represent a taxes descriptio data
    /// </summary>
    public class TaxesDescriptionDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TaxDescription"/> property
        /// </summary>
        private string? mTaxDescription;

        #endregion

        #region Public Property

        /// <summary>
        /// The line id
        /// </summary>
        [JsonProperty("lineid")]
        public int LineId { get; set; }

        /// <summary>
        /// The tax description
        /// </summary>
        [AllowNull]
        [JsonProperty("taxDescription")]
        public string TaxDescription 
        { 
            get => mTaxDescription ?? string.Empty;

            set => mTaxDescription = value;
        }

        /// <summary>
        /// The tax amount
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// The tax vat amount
        /// </summary>
        [JsonProperty("taxVatAmount")]
        public decimal TaxVATAmount { get; set; }

        /// <summary>
        /// The vat category
        /// </summary>
        [AllowNull]
        [JsonProperty("VatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory VATCategory { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxesDescriptionDataModel()
        {
            
        }

        #endregion
    }
}
