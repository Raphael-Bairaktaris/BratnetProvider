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
        public ExpenseClassificationType ClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public ExpenseClassificationCategory ClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// Required
        /// Min value 0
        /// fraction digits 2
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The unique id
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
