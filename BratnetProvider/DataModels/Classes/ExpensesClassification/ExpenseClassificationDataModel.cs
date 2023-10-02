using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an esxpense classification model
    /// </summary>
    public class ExpenseClassificationDataModel
    {
        #region Public Property

        /// <summary>
        /// The classification type
        /// </summary>
        [JsonProperty("classificationType")]
        public ExpenseClassificationType ExpenseClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public ExpenseClassificationCategory ExpenseClassificationCategory { get; set; }

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
        public ExpenseClassificationDataModel()
        {

        }

        #endregion
    }
}
