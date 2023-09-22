using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent a payment method data
    /// </summary>
    public class PaymentMethodDataModel
    {
        #region Public Property

        /// <summary>
        /// The payment method information
        /// </summary>
        [JsonProperty("paymentMethods")]
        public PaymentMethodDetailsDataModel? PaymentMethods { get; set; }

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
