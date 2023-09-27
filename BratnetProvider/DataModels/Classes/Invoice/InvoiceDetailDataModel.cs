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
    /// represent an invoice detail data
    /// </summary>
    public class InvoiceDetailDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Property

        /// <summary>
        /// Indicates the name of product
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name 
        {
            get => mName ?? string.Empty;
            
            set => mName = value;
        }

        /// <summary>
        /// Indicates the product code
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// The type of line
        /// </summary>
        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; } = 1;

        /// <summary>
        /// The rec type
        /// </summary>
        [JsonProperty("recType")]
        public string? RecType { get; set; }

        /// <summary>
        /// The fuel code
        /// </summary>
        [JsonProperty("fuelCode")]
        public FuelCodeCategoryType? FuelCode { get; set; }

        /// <summary>
        /// The product quantity
        /// </summary>
        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// The measurment unit
        /// </summary>
        [JsonProperty("measurementUnit")]
        public MeasurementUnit MeasurementUnit { get; set; }

        /// <summary>
        /// The type of invoice
        /// </summary>
        [JsonProperty("invoiceDetailType")]
        public string? InvoiceDetailType { get; set; }

        /// <summary>
        /// Product value before discount
        /// </summary>
        [JsonProperty("netValueBeforeDiscount")]
        public int? NetValueBeforeDiscount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("netValue")]
        public int? NetValue { get; set; }

        /// <summary>
        /// The vat number category
        /// </summary>
        [JsonProperty("vatCategory")]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal VATAmount { get; set; }

        /// <summary>
        /// The vat exemption type
        /// </summary>
        [JsonProperty("vatExemptionCategory")]
        public VATExemptionCategory? VATExemptionCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dienergeia")]
        public bool? Dienergeia { get; set; }

        /// <summary>
        /// The discount optiong discrimination
        /// </summary>
        [JsonProperty("discountOption")]
        public bool? DiscountOption { get; set; }

        /// <summary>
        /// The tax withholding amount
        /// Min value 0 
        /// Fraction digits 2
        /// </summary>
        [JsonProperty("withheldAmount")]
        public decimal? WithheldAmmount { get; set; }

        /// <summary>
        /// The withheld percent category
        /// </summary>
        [JsonProperty("withheldPercentCategory")]
        public WithholdingTaxCategory? WithheldPercentCategory { get; set; }

        /// <summary>
        /// The stamp duty amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        public decimal? StamDutyAmount { get; set; }

        /// <summary>
        /// The stamp duty percent category
        /// </summary>
        [JsonProperty("stampDutyPercentCategory")]
        public StampDutyPercentageCategory? StamputyPercentCategory { get; set; }

        /// <summary>
        /// The fees amount
        /// Min value 0
        /// Fraction digits
        /// </summary>
        [JsonProperty("feesAmount")]
        public decimal? FeesAmount { get; set; }

        /// <summary>
        /// The fees percent category
        /// </summary>
        [JsonProperty("feesPercentCategory")]
        public FeesPercentageCategory? FeesPercentCategory { get; set; }

        /// <summary>
        /// The other taxes percent category
        /// </summary>
        [JsonProperty("otherTaxesPercentCategory")]
        public OtherTaxesPercentageCategory? OtherTaxesPercentCategory { get; set; }

        /// <summary>
        /// The other taxes amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        [JsonProperty("otherTaxesAmount")]
        public decimal? OtherTaxesAmount { get; set; } 

        /// <summary>
        /// The deduction amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        [JsonProperty("deductionsAmount")]
        public decimal? DeductionsAmount { get; set; }

        /// <summary>
        /// The comns for the line
        /// </summary>
        [JsonProperty("lineComments")]
        public string? LineComments { get; set; }

        /// <summary>
        /// The income classifications
        /// </summary>
        [AllowNull]
        [JsonProperty("incomeClassification")]
        public IEnumerable<IncomeClassificationDataModel> IncomeClassifications { get; set; }

        /// <summary>
        /// The expense classifications
        /// </summary>
        [AllowNull]
        [JsonProperty("expenseClassification")]
        public IEnumerable<ExpenseClassificationDataModel> ExpenseClassifications { get; set; }

        /// <summary>
        /// The quantity
        /// </summary>
        [JsonProperty("quantity15")]
        public uint? Quantity15 { get; set; }

        /// <summary>
        /// The item's description 
        /// </summary>
        [AllowNull]
        [JsonProperty("itemDescr")]
        public string ItemDespcription { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// The amount of discount
        /// </summary>
        [JsonProperty("discountAmount")]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// The percentage of discount
        /// </summary>
        [JsonProperty("discountPercent")]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("measurementUnitName")]
        public MeasurementUnit MeasurementUnitName { get; set; }

        /// <summary>
        /// The percentage of VAT
        /// </summary>
        public decimal? VATPercent { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailDataModel()
        {

        }

        #endregion
    }
}
