using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        #region Public Property

        /// <summary>
        /// The line id
        /// </summary>
        [JsonProperty("lineid")]
        public int LindId { get; set; }

        /// <summary>
        /// The tax description
        /// </summary>
        [JsonProperty("taxDescription")]
        public string TaxDescription { get; set; }

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
        [JsonProperty("VatCategory")]
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
