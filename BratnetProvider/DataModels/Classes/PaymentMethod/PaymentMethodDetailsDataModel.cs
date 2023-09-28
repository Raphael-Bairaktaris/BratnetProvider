using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a payment method detail data
    /// </summary>
    public class PaymentMethodDetailsDataModel
    {

        #region Public Property

        /// <summary>
        /// The payment method type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(PaymentTypeToGreekStringJsonConverter))]
        public PaymentType Type { get; set; }

        /// <summary>
        /// The payment amount required
        /// Fraction digits 2
        /// Min value 0
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The payment method information
        /// </summary>
        [JsonProperty("paymentMethodInfo")]
        public string? PaymentMethodInfo { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodDetailsDataModel()
        {

        }

        #endregion
    }
}
