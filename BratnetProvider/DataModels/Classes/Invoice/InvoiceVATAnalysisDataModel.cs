using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an invoice vat analysis data
    /// </summary>
    public class InvoiceVATAnalysisDataModel
    {
        #region Public Property

        /// <summary>
        /// The vat category
        /// </summary>
        [JsonProperty("vatCategory")]
        public VATCategory VATCategory { get; set; }

        /// <summary>
        /// The vat percent
        /// </summary>
        [JsonProperty("vatPercent")]
        public object VATPercent { get; set; }

        /// <summary>
        /// The net value per vat
        /// </summary>
        [JsonProperty("netValuePerVat")]
        public object NetValuePerVat { get; set; }

        /// <summary>
        /// The vat amount
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal VATAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceVATAnalysisDataModel()
        {
            
        }

        #endregion
    }
}
