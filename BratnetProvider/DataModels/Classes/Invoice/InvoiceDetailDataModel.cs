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
        /// The member of the <see cref="Quantity"/> property
        /// </summary>
        private decimal mQuantity = 1;

        /// <summary>
        /// The member of the <see cref="VATExemptionType"/>
        /// </summary>
        private VATExemptionType? mVATExemptionType;

        private string? mLineComments;

        #endregion

        #region Public Property

        /// <summary>
        /// Indicates the name of product
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates the product code
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// The type of line
        /// </summary>
        [AllowNull]
        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; } = 1;

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recType")]
        public object recType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fuelCode")]
        public FuelCodeCategoryType FuelCode { get; set; }

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
        /// The measurment unti
        /// </summary>
        [JsonProperty("measurementUnit")]
        public MeasurementUnit? MeasurementUnit { get; set; }

        /// <summary>
        /// The type of invoice
        /// </summary>
        public InvoiceType? InvoiceDetailType { get; set; }

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
        public VATCategory? VATCategory 
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vatAmount")]
        public int VATAmount { get; set; }

        /// <summary>
        /// The vat exemption type
        /// </summary>
        [JsonProperty("vatExemptionCategory")]
        public VATExemptionType? VATExemptionCategory { get; set; }

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
        public WithheldPercentageCategory? WithheldPercentCategory { get; set; }

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
        /// The other taxes amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        [JsonProperty("otherTaxesAmount")]
        public decimal? OtherTaxesAmount { get; set; } 

        /// <summary>
        /// The other taxes percent category
        /// </summary>
        public OtherTaxesPercentageCategory? OtherTaxesPercentCategory { get; set; }

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
        public string LineComments 
        { 
            get => mLineComments ?? string.Empty;
            
            set => mLineComments = value;
        }

        /// <summary>
        /// The income classification type
        /// </summary>
        public IncomeClassificationDataModel IncomeClassificationType { get; set; }

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
