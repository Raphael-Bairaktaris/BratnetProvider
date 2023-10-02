using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a payment method detail
    /// </summary>
    public class PaymentMethodDetailDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PaymentMethodInfo"/> property
        /// </summary>
        private string? mPaymentMethodInfo;

        #endregion

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
        [AllowNull]
        [JsonProperty("paymentMethodInfo")]
        public string PaymentMethodInfo
        {
            get => mPaymentMethodInfo ?? string.Empty;

            set => mPaymentMethodInfo = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodDetailDataModel()
        {

        }

        #endregion
    }
}
