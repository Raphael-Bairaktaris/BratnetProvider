using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;


namespace BratnetProvider
{
    /// <summary>
    /// Represent an invoice vat analysis data
    /// </summary>
    public class InvoiceVATAnalysisDataModel
    {
        #region Public Property

        /// <summary>
        /// The vat category
        /// </summary>
        [AllowNull]
        [JsonProperty("vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory VATCategory { get; set; }

        /// <summary>
        /// The vat percent
        /// </summary>
        [JsonProperty("vatPercent")]
        public decimal? VATPercent { get; set; }

        /// <summary>
        /// The net value per vat
        /// </summary>
        [JsonProperty("netValuePerVat")]
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// The vat amount
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal? VATAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceVATAnalysisDataModel()
        {
            
        }

        #endregion
    }
}
