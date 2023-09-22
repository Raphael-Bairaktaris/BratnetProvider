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
        public int TotalNetValue { get; set; }

        /// <summary>
        /// The total vat amount
        /// </summary>
        [JsonProperty("totalVatAmount")]
        public int TotalVATAmount { get; set; }

        /// <summary>
        /// The total withhled amount
        /// </summary>
        [JsonProperty("totalWithheldAmount")]
        public WithheldPercentageCategory TotalWithheldAmount { get; set; }

        /// <summary>
        /// The total fees amount
        /// </summary>
        [JsonProperty("totalFeesAmount")]
        public decimal TotalFeesAmount { get; set; }

        /// <summary>
        /// The total stamp duty amount
        /// </summary>
        [JsonProperty("totalStampDutyAmount")]
        public int TotalStampDutyAmount { get; set; }

        /// <summary>
        /// The total of other taxes amount
        /// </summary>
        [JsonProperty("totalOtherTaxesAmount")]
        public OtherTaxesPercentageCategory TotalOtherTaxesAmount { get; set; }

        /// <summary>
        /// The total deduction amount
        /// </summary>
        [JsonProperty("totalDeductionsAmount")]
        public int TotalDeductionsAmount { get; set; }

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
        /// The income classification type
        /// </summary>
        public IncomeClassificationType classificationType { get; set; }

        /// <summary>
        /// The income classification category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public IncomeClassificationCategory ClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The unique id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

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
