using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents an invoice total discount data
    /// </summary>
    public class InvoiceTotalDiscountDataModel
    {
        #region Public property

        /// <summary>
        /// The total discount amount
        /// </summary>
        [JsonProperty("totalDiscountAmount")]
        public decimal? TotalDiscountAmount { get; set; }

        /// <summary>
        /// The total discount percent
        /// </summary>
        [JsonProperty("totalDiscountPercent")]
        public decimal? TotalDiscountPercent { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTotalDiscountDataModel()
        {

        }

        #endregion
    }
}
