using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an invoice total discount data
    /// </summary>
    public class InvoiceTotalDiscountDataModel
    {
        #region Public property

        /// <summary>
        /// The total discount amount
        /// </summary>
        [JsonProperty("totalDiscountAmount")]
        public object TotalDiscountAmount { get; set; }

        /// <summary>
        /// The total discount percent
        /// </summary>
        [JsonProperty("totalDiscountPercent")]
        public object TotalDiscountPercent { get; set; }
        
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
