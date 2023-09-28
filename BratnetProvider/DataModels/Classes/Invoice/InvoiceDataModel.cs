using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents an invoice data
    /// </summary>
    public class InvoiceDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="InvoiceVATAnalysis"/> property
        /// </summary>
        private IEnumerable<InvoiceVATAnalysisDataModel>? mInvoiceVATAnalysis;

        /// <summary>
        /// The member of the <see cref="InvoiceTaxVATAnalysis"/> property
        /// </summary>
        private IEnumerable<InvoiceTaxVATAnalysisDataModel>? mInvoiceTaxVATAnalysis;

        /// <summary>
        /// The member of the <see cref="InvoiceDetails"/> property
        /// </summary>
        private IEnumerable<InvoiceDetailDataModel>? mInvoiceDetails;

        /// <summary>
        /// The member of the <see cref="TaxesDescriptions"/> property
        /// </summary>
        private IEnumerable<TaxesDescriptionDataModel>? mTaxesDescriptions;

        #endregion

        #region Public Property

        /// <summary>
        /// The unique auto incremented item uid
        /// </summary>
        [JsonProperty("uid")]
        public uint? UId { get; set; }

        /// <summary>
        /// The invoice unique mark
        /// </summary>
        [JsonProperty("mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// The invoice cancellation mark
        /// </summary>
        [JsonProperty("cancelledByMark")]
        public long? CancelledByMark { get; set; }

        /// <summary>
        /// The invoice authentication code
        /// </summary>
        [JsonProperty("authenticationCode")]
        public string? AuthenticationCode { get; set; }

        /// <summary>
        /// The invoice transmission failure
        /// </summary>
        [JsonProperty("transmissionFailure")]
        public string? TransmissionFailure { get; set; }

        /// <summary>
        /// The invoice issuer
        /// </summary>
        [JsonProperty("issuer")]
        public IssuerDetailDataModel? Issuer { get; set; }

        /// <summary>
        /// The invoice counterpart
        /// </summary>
        [JsonProperty("counterpart")]
        public CounterpartDataModel? Counterpart { get; set; }

        /// <summary>
        /// The invoice header
        /// </summary>
        [JsonProperty("invoiceHeader")]
        public InvoiceHeaderDataModel? InvoiceHeader { get; set; }

        /// <summary>
        /// The invoice payment methods
        /// </summary>
        [JsonProperty("paymentMethods")]
        public PaymentMethodDataModel? PaymentMethods { get; set; }

        /// <summary>
        /// The invoice detail
        /// </summary>
        [JsonProperty("invoiceDetails")]
        public IEnumerable<InvoiceDetailDataModel> InvoiceDetails
        {
            get => mInvoiceDetails ?? Enumerable.Empty<InvoiceDetailDataModel>();

            set => mInvoiceDetails = value;
        }

        /// <summary>
        /// The invoice taxes totals
        /// </summary>
        [JsonProperty("taxesTotals")]
        public TaxesTotalsDataModel? TaxesTotals { get; set; }

        /// <summary>
        /// The invoice taxes description
        /// </summary>
        [JsonProperty("taxesDescriptions")]
        public IEnumerable<TaxesDescriptionDataModel> TaxesDescriptions
        {
            get => mTaxesDescriptions ?? Enumerable.Empty<TaxesDescriptionDataModel>();

            set => mTaxesDescriptions = value;
        }

        /// <summary>
        /// The invoice summary
        /// </summary>
        [JsonProperty("invoiceSummary")]
        public InvoiceSummaryDataModel? InvoiceSummary { get; set; }

        /// <summary>
        /// The invoice total discount
        /// </summary>
        [JsonProperty("invoiceTotalDiscount")]
        public InvoiceTotalDiscountDataModel? InvoiceTotalDiscount { get; set; }

        /// <summary>
        /// The invoice VAT analysis
        /// </summary>
        [JsonProperty("invoiceVatAnalysis")]
        public IEnumerable<InvoiceVATAnalysisDataModel>? InvoiceVATAnalysis
        {
            get => mInvoiceVATAnalysis ?? Enumerable.Empty<InvoiceVATAnalysisDataModel>();

            set => mInvoiceVATAnalysis = value;
        }

        /// <summary>
        /// The invoice tax VAT analysis
        /// </summary>
        [JsonProperty("invoiceTaxVatAnalysis")]
        public IEnumerable<InvoiceTaxVATAnalysisDataModel> InvoiceTaxVATAnalysis
        {
            get => mInvoiceTaxVATAnalysis ?? Enumerable.Empty<InvoiceTaxVATAnalysisDataModel>();

            set => mInvoiceTaxVATAnalysis = value;
        }

        /// <summary>
        /// The invoice extras
        /// </summary>
        [JsonProperty("extra")]
        public ExtrasDataModel? Extras { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDataModel()
        {

        }

        #endregion
    }
}