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

        /// <summary>
        /// The member of the <see cref="FuelCode"/>
        /// </summary>
        private IEnumerable<FuelCodeCategoryType>? mFuelCode;

        /// <summary>
        /// The member of the <see cref="Quantity"/> property
        /// </summary>
        private decimal mQuantity = 1;

        /// <summary>
        /// The member of the <see cref="MeasurementUnit"/> 
        /// </summary>
        private IEnumerable<MeasurementUnit>? mMeasurementUnit;

        /// <summary>
        /// The member of the <see cref="InvoiceDetailType"/> property
        /// </summary>
        private IEnumerable<InvoiceType>? mInvoiceDetailtype;

        /// <summary>
        /// The member of the <see cref="VATCategory"/> property
        /// </summary>
        private IEnumerable<VATCategory>? mVATCategory;

        /// <summary>
        /// The member of the <see cref="VATExemptionCategory"/> property
        /// </summary>
        private IEnumerable<VATExemptionCategory>? mVATExemptionCategory;

        /// <summary>
        /// The member of the <see cref="WithheldPercentCategory"/> property
        /// </summary>
        private IEnumerable<WithholdingTaxCategory>? mWithheldPercentCategory;

        /// <summary>
        /// The member of the <see cref="StamputyPercentCategory"/> property
        /// </summary>
        private IEnumerable<StampDutyPercentageCategory>? mStampDutyPercentCategory;

        /// <summary>
        /// The member of the <see cref="FeesPercentCategory"/> property
        /// </summary>
        private IEnumerable<FeesPercentageCategory>? mFeesPercentCategory;

        /// <summary>
        /// The member of the <see cref="OtherTaxesPercentCategory"/>
        /// </summary>
        private IEnumerable<OtherTaxesPercentageCategory>? mOtherTaxesPercentCategory;

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
        /// 
        /// </summary>
        [JsonProperty("recType")]
        public string? RecType { get; set; }

        /// <summary>
        /// The fuel code
        /// </summary>
        [AllowNull]
        [JsonProperty("fuelCode")]
        public IEnumerable<FuelCodeCategoryType> FuelCode 
        { 
            get => mFuelCode ?? Enumerable.Empty<FuelCodeCategoryType>();

            set => mFuelCode = value;
        }

        /// <summary>
        /// The product quantity
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity 
        {
            get => mQuantity;

            set
            {
                if (value < 0)
                    mQuantity = 0;
                else 
                    mQuantity = value;
            }
        }

        /// <summary>
        /// The measurment unit
        /// </summary>
        [AllowNull]
        [JsonProperty("measurementUnit")]
        public IEnumerable<MeasurementUnit> MeasurementUnit 
        { 
            get => mMeasurementUnit ?? Enumerable.Empty<MeasurementUnit>();
            
            set => mMeasurementUnit = value;
        }

        /// <summary>
        /// The type of invoice
        /// </summary>
        [AllowNull]
        [JsonProperty("invoiceDetailType")]
        public IEnumerable<InvoiceType> InvoiceDetailType 
        {
            get => mInvoiceDetailtype ?? Enumerable.Empty<InvoiceType>();

            set => mInvoiceDetailtype = value;
        }

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
        [AllowNull]
        [JsonProperty("vatCategory")]
        public IEnumerable<VATCategory> VATCategory 
        { 
            get => mVATCategory ?? Enumerable.Empty<VATCategory>();

            set => mVATCategory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal VATAmount { get; set; }

        /// <summary>
        /// The vat exemption type
        /// </summary>
        [AllowNull]
        [JsonProperty("vatExemptionCategory")]
        public IEnumerable<VATExemptionCategory> VATExemptionCategory
        {
            get => mVATExemptionCategory ?? Enumerable.Empty<VATExemptionCategory>();

            set => mVATExemptionCategory = value;
        }

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
        [AllowNull]
        [JsonProperty("withheldPercentCategory")]
        public IEnumerable<WithholdingTaxCategory> WithheldPercentCategory
        { 
            get => mWithheldPercentCategory ?? Enumerable.Empty<WithholdingTaxCategory>();

            set => mWithheldPercentCategory = value;
        }

        /// <summary>
        /// The stamp duty amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        public decimal? StamDutyAmount { get; set; }

        /// <summary>
        /// The stamp duty percent category
        /// </summary>
        [AllowNull]
        [JsonProperty("stampDutyPercentCategory")]
        public IEnumerable<StampDutyPercentageCategory> StamputyPercentCategory
        {
            get => mStampDutyPercentCategory ?? Enumerable.Empty<StampDutyPercentageCategory>();

            set => mStampDutyPercentCategory = value;
        }

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
        [AllowNull]
        [JsonProperty("feesPercentCategory")]
        public IEnumerable<FeesPercentageCategory> FeesPercentCategory 
        { 
            get => mFeesPercentCategory ?? Enumerable.Empty<FeesPercentageCategory>();

            set => mFeesPercentCategory = value;
        }

        /// <summary>
        /// The other taxes percent category
        /// </summary>
        [AllowNull]
        [JsonProperty("otherTaxesPercentCategory")]
        public IEnumerable<OtherTaxesPercentageCategory> OtherTaxesPercentCategory 
        {
            get => mOtherTaxesPercentCategory ?? Enumerable.Empty<OtherTaxesPercentageCategory>();

            set => mOtherTaxesPercentCategory = value;
        }

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
        public IncomeClassificationDataModel IncomeClassifications 
        {
            get;

            set; 
        }

        /// <summary>
        /// The expense classifications
        /// </summary>
        [AllowNull]
        [JsonProperty("expenseClassification")]
        public ExpenseClassificationDataModel ExpenseClassifications 
        { 
            get; 

            set; 
        }

        /// <summary>
        /// The quantity
        /// </summary>
        [JsonProperty("quantity15")]
        public uint Quantity15 { get; set; }

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
        public int Price { get; set; }

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
