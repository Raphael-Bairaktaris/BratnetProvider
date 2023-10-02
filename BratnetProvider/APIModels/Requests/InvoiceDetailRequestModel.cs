using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Request model used for sending detail invoices to the Bratnet provider
    /// </summary>
    public class InvoiceDetailRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name
        /// </summary>
        public string Name 
        {
            get => mName ?? string.Empty;

            set => mName = value;
        }

        /// <summary>
        /// The code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The rec type
        /// </summary>
        public string? RecType { get; set; }

        /// <summary>
        /// The fuel code
        /// </summary>
        public FuelCodeCategoryType? FuelCode { get; set; }

        /// <summary>
        /// The quantity
        /// </summary>
        public uint Quantity { get; set; }

        /// <summary>
        /// The measurment unit
        /// </summary>
        public MeasurementUnit MeasurementUnit { get; set; }

        /// <summary>
        /// The type of invoice
        /// </summary>
        public InvoiceDetailType? InvoiceDetailType { get; set; }

        /// <summary>
        /// Product value before discount
        /// </summary>
        public decimal NetValueBeforeDiscount { get; set; }

        /// <summary>
        /// The net value
        /// </summary>
        public decimal NetValue { get; set; }

        /// <summary>
        /// The vat number category
        /// </summary>
        public VATCategory VATCategory { get; set; }

        /// <summary>
        /// The VAT amount
        /// </summary>
        public decimal VATAmount { get; set; }

        /// <summary>
        /// The vat exemption type
        /// </summary>
        public VATExemptionCategory? VATExemptionCategory { get; set; }

        /// <summary>
        /// The conduct
        /// </summary>
        public bool? Conduct { get; set; }

        /// <summary>
        /// The discount optiong discrimination
        /// </summary>
        public bool? DiscountOption { get; set; }

        /// <summary>
        /// The tax withholding amount
        /// Min value 0 
        /// Fraction digits 2
        /// </summary>
        public decimal? WithheldAmmount { get; set; }

        /// <summary>
        /// The withheld percent category
        /// </summary>
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
        public StampDutyPercentageCategory? StamputyPercentCategory { get; set; }

        /// <summary>
        /// The fees amount
        /// Min value 0
        /// Fraction digits
        /// </summary>
        public decimal? FeesAmount { get; set; }

        /// <summary>
        /// The fees percent category
        /// </summary>
        public FeesPercentageCategory? FeesPercentCategory { get; set; }

        /// <summary>
        /// The other taxes percent category
        /// </summary>
        public OtherTaxesPercentageCategory? OtherTaxesPercentCategory { get; set; }

        /// <summary>
        /// The other taxes amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        public decimal? OtherTaxesAmount { get; set; }

        /// <summary>
        /// The deduction amount
        /// Min value 0
        /// Fraction digits 2
        /// </summary>
        public decimal? DeductionsAmount { get; set; }

        /// <summary>
        /// The comns for the line
        /// </summary>
        public string? LineComments { get; set; }

        /// <summary>
        /// The classification type
        /// </summary>
        public IncomeClassificationType IncomeClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        public IncomeClassificationCategory IncomeClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        public decimal IncomeClassificationAmount { get; set; }

        /// <summary>
        /// The classification type
        /// </summary>
        public ExpenseClassificationType ExpenseClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        public ExpenseClassificationCategory ExpenseClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        public decimal ExpenseClassificationAmount { get; set; }

        /// <summary>
        /// The quantity
        /// </summary>
        public uint? Quantity15 { get; set; }

        /// <summary>
        /// The item's description 
        /// </summary>
        [AllowNull]
        public string ItemDespcription { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The amount of discount
        /// </summary>
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// The percentage of discount
        /// </summary>
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// The measurement unit name
        /// </summary>
        public MeasurementUnit MeasurementUnitName { get; set; }

        /// <summary>
        /// The percentage of VAT
        /// </summary>
        public decimal VATPercent { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailRequestModel()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="InvoiceDetailDataModel"/> from the current <see cref="InvoiceDetailRequestModel"/>
        /// </summary>
        /// <returns></returns>
        public InvoiceDetailDataModel ToInvoiceDetailDataModel()
        {
            var result = new InvoiceDetailDataModel()
            {
                Name = Name,
                RecType = RecType,
                FuelCode = FuelCode,
                Quantity = Quantity,
                Code = Code,
                MeasurementUnit = MeasurementUnit,
                InvoiceDetailType = InvoiceDetailType,
                NetValueBeforeDiscount = NetValueBeforeDiscount,
                NetValue = NetValue,
                VATCategory = VATCategory,
                VATAmount = VATAmount,
                VATExemptionCategory = VATExemptionCategory,
                Conduct = Conduct,
                DiscountOption = DiscountOption,
                WithheldAmmount = WithheldAmmount,
                WithheldPercentCategory = WithheldPercentCategory,
                StamDutyAmount = StamDutyAmount,
                StamputyPercentCategory = StamputyPercentCategory,
                FeesAmount = FeesAmount,
                FeesPercentCategory = FeesPercentCategory,
                OtherTaxesPercentCategory = OtherTaxesPercentCategory,
                OtherTaxesAmount = OtherTaxesAmount,
                DeductionsAmount = DeductionsAmount,
                LineComments = LineComments,
                
                Quantity15 = Quantity15,
                ItemDespcription = ItemDespcription,
                Price = Price,
                DiscountAmount = DiscountAmount,
                DiscountPercent = DiscountPercent,
                MeasurementUnitName = MeasurementUnitName,
                VATPercent = VATPercent

            };

            return result;
        }

        #endregion
    }
}