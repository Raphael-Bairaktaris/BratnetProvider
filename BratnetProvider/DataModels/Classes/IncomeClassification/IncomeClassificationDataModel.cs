using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents an income classification data
    /// </summary>
    public class IncomeClassificationDataModel
    {
        #region Public Property

        /// <summary>
        /// The classification type
        /// </summary>
        [JsonProperty("classificationType")]
        public IncomeClassificationType IncomeClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public IncomeClassificationCategory IncomeClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The TaxId
        /// </summary>
        [JsonProperty("id")]
        public byte? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationDataModel()
        {

        }

        #endregion
    }
}
