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
    /// Represent an invoice data model
    /// </summary>
    public class InvoicesDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Invoices"/> property
        /// </summary>
        private IEnumerable<InvoiceDataModel>? mInvoices;

        #endregion

        #region Public Properties

        /// <summary>
        /// The invoices
        /// </summary>
        [AllowNull]
        [JsonProperty("invoice")]
        public IEnumerable<InvoiceDataModel> Invoices
        {
            get => mInvoices ?? Enumerable.Empty<InvoiceDataModel>();

            set => mInvoices = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoicesDataModel()
        {
                
        }

        #endregion
    }
}
