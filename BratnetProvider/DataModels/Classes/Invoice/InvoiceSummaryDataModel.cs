using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represents the invoice summary data
    /// </summary>
    public class InvoiceSummaryDataModel
    {
        #region Public Property

        /// <summary>
        /// The total net value
        /// </summary>
        [JsonProperty("totalNetValue")]
        public decimal TotalNetValue { get; set; }

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
        public decimal TotalGrossValue { get; set; }

        /// <summary>
        /// The total print gross value
        /// </summary>
        [JsonProperty("totalPrintGrossValue")]
        public decimal PrintGrossValue { get; set; }

        /// <summary>
        /// The income classifications
        /// </summary>
        [JsonProperty("incomeClassification")]
        public IncomeClassificationDataModel IncomeClassifications { get; set; }

        /// <summary>
        /// The expense classifications
        /// </summary>
        [JsonProperty("expenseClassification")]
        public ExpenseClassificationDataModel ExpenseClassifications { get; set; }

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
