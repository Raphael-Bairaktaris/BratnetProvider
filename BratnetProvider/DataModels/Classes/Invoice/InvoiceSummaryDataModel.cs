using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents the invoice summary data
    /// </summary>
    public class InvoiceSummaryDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="IncomeClassifications"/> property
        /// </summary>
        private IEnumerable<IncomeClassificationDataModel>? mIncomeClassifications;

        /// <summary>
        /// The member of the <see cref="ExpenseClassifications"/> property
        /// </summary>
        private IEnumerable<ExpenseClassificationDataModel>? mExpenseClassifications;

        #endregion

        #region Public Property

        /// <summary>
        /// The total net value
        /// </summary>
        [JsonProperty("totalNetValue")]
        public decimal TotalNetAmount { get; set; }

        /// <summary>
        /// The total vat amount
        /// </summary>
        [JsonProperty("totalVatAmount")]
        public decimal TotalVATAmount { get; set; }

        /// <summary>
        /// The total withhled amount
        /// </summary>
        [JsonProperty("totalWithheldAmount")]
        public decimal TotalWithheldAmount { get; set; }

        /// <summary>
        /// The total fees amount
        /// </summary>
        [JsonProperty("totalFeesAmount")]
        public decimal TotalFeesAmount { get; set; }

        /// <summary>
        /// The total stamp duty amount
        /// </summary>
        [JsonProperty("totalStampDutyAmount")]
        public decimal TotalStampDutyAmount { get; set; }

        /// <summary>
        /// The total of other taxes amount
        /// </summary>
        [JsonProperty("totalOtherTaxesAmount")]
        public decimal TotalOtherTaxesAmount { get; set; }

        /// <summary>
        /// The total deduction amount
        /// </summary>
        [JsonProperty("totalDeductionsAmount")]
        public decimal TotalDeductionsAmount { get; set; }

        /// <summary>
        /// The total gross value
        /// </summary>
        [JsonProperty("totalGrossValue")]
        public decimal TotalGrossAmount { get; set; }

        /// <summary>
        /// The total print gross value
        /// </summary>
        [JsonProperty("totalPrintGrossValue")]
        public decimal PrintGrossAmount { get; set; }

        /// <summary>
        /// The income classifications
        /// </summary>
        [JsonProperty("incomeClassification")]
        public IEnumerable<IncomeClassificationDataModel> IncomeClassifications
        {
            get => mIncomeClassifications ?? Enumerable.Empty<IncomeClassificationDataModel>();

            set => mIncomeClassifications = value;
        }

        /// <summary>
        /// The expense classifications
        /// </summary>
        [JsonProperty("expenseClassification")]
        public IEnumerable<ExpenseClassificationDataModel> ExpenseClassifications
        {
            get => mExpenseClassifications ?? Enumerable.Empty<ExpenseClassificationDataModel>();

            set => mExpenseClassifications = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceSummaryDataModel()
        {

        }

        #endregion
    }
}
