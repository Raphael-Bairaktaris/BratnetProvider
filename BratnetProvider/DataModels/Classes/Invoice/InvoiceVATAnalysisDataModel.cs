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
    /// Represent an invoice vat analysis data
    /// </summary>
    public class InvoiceVATAnalysisDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="VATCategory"/> property
        /// </summary>
        private IEnumerable<VATCategory>? mVATCategory;

        #endregion

        #region Public Property

        /// <summary>
        /// The vat category
        /// </summary>
        [AllowNull]
        [JsonProperty("vatCategory")]
        public IEnumerable<VATCategory> VATCategory
        {
            get => mVATCategory ?? Enumerable.Empty<VATCategory>();

            set => mVATCategory = value;
        }

        /// <summary>
        /// The vat percent
        /// </summary>
        [JsonProperty("vatPercent")]
        public decimal VATPercent { get; set; }

        /// <summary>
        /// The net value per vat
        /// </summary>
        [JsonProperty("netValuePerVat")]
        public decimal NetAmount { get; set; }

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
