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
    /// Represents an income classification data
    /// </summary>
    public class IncomeClassificationDataModel
    {
        #region Public Property

        /// <summary>
        /// The classification type
        /// </summary>
        [JsonProperty("classificationType")]
        public IncomeClassificationType ClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public IncomeClassificationCategory ClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The TaxId
        /// </summary>
        [JsonProperty("id")]
        public byte? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationDataModel()
        {
            
        }

        #endregion
    }
}
