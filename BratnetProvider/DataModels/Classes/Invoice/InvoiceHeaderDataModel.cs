using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an invoice header data
    /// </summary>
    public class InvoiceHeaderDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Series"/> property 
        /// </summary>
        private string? mSeries;

        /// <summary>
        /// The member of the <see cref="mCorrelatedInvoices"/> property
        /// </summary>
        private IEnumerable<long>? mCorrelatedInvoices;

        #endregion

        #region Public Property

        /// <summary>
        /// The invoice series number
        /// </summary>
        [AllowNull]
        [JsonProperty("series")]
        public string Series
        {
            get => mSeries ?? string.Empty;

            set => mSeries = value;
        }

        /// <summary>
        /// The invoice increasing serial number
        /// </summary>
        [JsonProperty("aa")]
        public uint AA { get; set; }

        /// <summary>
        /// The invoice date of issue
        /// </summary>
        [JsonProperty("issueDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly IssueDate { get; set; }

        /// <summary>
        /// The invoice type
        /// </summary>
        [JsonProperty("invoiceType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType InvoiceType { get; set; }

        /// <summary>
        /// The vat payment suspension indication
        /// </summary>
        [JsonProperty("vatPaymentSuspension")]
        public bool? VATPaymentSuspension { get; set; }

        /// <summary>
        /// The type of currency
        /// </summary>
        [JsonProperty("currency")]
        public CurrencyCode Currency { get; set; } = CurrencyCode.EUR;

        /// <summary>
        /// The exchange rate values0 - 50000
        /// Fraction digits 5
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The correlated invoice
        /// </summary>
        [AllowNull]
        [JsonProperty("correlatedInvoices")]
        public IEnumerable<long> CorrelatedInvoices
        {
            get => mCorrelatedInvoices ?? Enumerable.Empty<long>();

            set => mCorrelatedInvoices = value;
        }

        /// <summary>
        /// The self pricing indication
        /// </summary>
        [JsonProperty("selfPricing")]
        public bool? SelfPricing { get; set; }

        /// <summary>
        /// The date of dispatched invoice
        /// </summary>
        [JsonProperty("dispatchDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly? DispatchDate { get; set; }

        /// <summary>
        /// The time of dispatched invoice
        /// </summary>
        [JsonProperty("dispatchTime")]
        [JsonConverter(typeof(TimeOnlyToStringJsonConveter))]
        public TimeOnly? DispatchTime { get; set; }

        /// <summary>
        /// The vehicle license plate number
        /// </summary>
        [JsonProperty("vehicleNumber")]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// The move purpose index
        /// </summary>
        [JsonProperty("movePurpose")]
        [JsonConverter(typeof(MovePurposeToIntJsonConverter))]
        public MovePurpose? MovePurpose { get; set; }

        /// <summary>
        /// The fuel used index
        /// </summary>
        [JsonProperty("fuelInvoice")]
        [JsonConverter(typeof(FuelCodeCategoryTypeToIntJsonConverter))]
        public FuelCodeCategoryType? FuelInvoice { get; set; }

        /// <summary>
        /// The speific invoice cetegory
        /// </summary>
        [JsonProperty("specialInvoiceCategory")]
        [JsonConverter(typeof(SpecialInvoiceCategoryTypeToIntJsonConverter))]
        public SpecialInvoiceCategoryType? SpecialInvoiceCategory { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceHeaderDataModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Series + " - " + AA;

        #endregion
    }
}
