using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a set of payment method details
    /// </summary>
    public class PaymentMethodDetailsDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="PaymentMethods"/> property
        /// </summary>
        private IEnumerable<PaymentMethodDetailDataModel>? mPaymentMethods;

        #endregion

        #region Public Property

        /// <summary>
        /// The payment method information
        /// </summary>
        [JsonProperty("paymentMethods")]
        public IEnumerable<PaymentMethodDetailDataModel> PaymentMethods
        {
            get => mPaymentMethods ?? Enumerable.Empty<PaymentMethodDetailDataModel>();

            set => mPaymentMethods = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PaymentMethodDetailsDataModel()
        {

        }

        #endregion
    }
}
