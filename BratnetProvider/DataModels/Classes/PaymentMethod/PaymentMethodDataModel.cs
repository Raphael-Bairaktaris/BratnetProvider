using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a payment method data
    /// </summary>
    public class PaymentMethodDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PaymentMethods"/> property
        /// </summary>
        private IEnumerable<PaymentMethodDetailsDataModel>? mPaymentMethods;

        #endregion

        #region Public Property

        /// <summary>
        /// The payment method information
        /// </summary>
        [JsonProperty("paymentMethods")]
        public IEnumerable<PaymentMethodDetailsDataModel> PaymentMethods
        {
            get => mPaymentMethods ?? Enumerable.Empty<PaymentMethodDetailsDataModel>();

            set => mPaymentMethods = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PaymentMethodDataModel()
        {

        }

        #endregion
    }
}
