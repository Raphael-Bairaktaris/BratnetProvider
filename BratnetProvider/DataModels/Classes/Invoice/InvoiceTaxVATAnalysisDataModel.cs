using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an invoice tax analysis data
    /// </summary>
    public class InvoiceTaxVATAnalysisDataModel
    {
        #region Public Property

        /// <summary>
        /// The vat category
        /// </summary>
        [JsonProperty("vatCategory")]
        public VATCategory VATCategory { get; set; }

        /// <summary>
        /// The vat percent
        /// </summary>
        [JsonProperty("vatPercent")]
        public decimal VATPercent { get; set; }

        /// <summary>
        /// The net value per vat
        /// </summary>
        [JsonProperty("netValuePerVat")]
        public decimal NetAmount { get; set; }

        /// <summary>
        /// The vat amount
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal VATAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTaxVATAnalysisDataModel()
        {

        }

        #endregion
    }
}
