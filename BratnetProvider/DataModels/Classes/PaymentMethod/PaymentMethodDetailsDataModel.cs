using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent a payment method detail data
    /// </summary>
    public class PaymentMethodDetailsDataModel
    {
        #region Public Property

        /// <summary>
        /// The payment method type
        /// </summary>
        [JsonProperty("type")]
        public PaymentType? Type { get; set; }

        /// <summary>
        /// The payment amount required
        /// Fraction digits 2
        /// Min value 0
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The payment method information
        /// </summary>
        [AllowNull]
        [JsonProperty("paymentMethodInfo")]
        public string PaymentMethodInfo { get; set; }

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
