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
    /// Represent an invoice header data
    /// </summary>
    public class InvoiceHeaderDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Series"/> property 
        /// </summary>
        private string? mSeries;

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
        /// The invoice serial number
        /// </summary>
        [JsonProperty("aa")]
        public uint AA { get; set; }

        /// <summary>
        /// The invoice date of issue
        /// </summary>
        [JsonProperty("issueDate")]
        public DateOnly IssueDate { get; set; }

        /// <summary>
        /// The invoice type
        /// </summary>
        [JsonProperty("invoiceType")]
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
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The correlated invoice
        /// </summary>
        [JsonProperty("correlatedInvoices")]
        public long? CorrelatedInvoices { get; set; }

        /// <summary>
        /// The self pricing indication
        /// </summary>
        [JsonProperty("selfPricing")]
        public bool? SelfPricing { get; set; }

        /// <summary>
        /// The date of dispatched invoice
        /// </summary>
        [JsonProperty("dispatchDate")]
        public DateOnly? DispatchDate { get; set; }

        /// <summary>
        /// The time of dispatched invoice
        /// </summary>
        [JsonProperty("dispatchTime")]
        public TimeOnly? DispatchTime { get; set; }

        /// <summary>
        /// The vehicle license plate number
        /// </summary>
        [AllowNull]
        [JsonProperty("vehicleNumber")]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// The move purpose index
        /// </summary>
        [JsonProperty("movePurpose")]
        public MovePurpose? MovePurpose { get; set; }

        /// <summary>
        /// The fuel used index
        /// </summary>
        public FuelCodeCategoryType FuelInvoice { get; set; }

        /// <summary>
        /// The speific invoice cetegory
        /// </summary>
        [JsonProperty("specialInvoiceCategory")]
        public SpecialInvoiceCategoryType SpecialInvoiceCategory { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceHeaderDataModel()
        {
            
        }

        #endregion
    }
}
