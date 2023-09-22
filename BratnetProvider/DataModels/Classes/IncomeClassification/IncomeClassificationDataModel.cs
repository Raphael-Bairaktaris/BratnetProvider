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
        /// The income classification type
        /// </summary>
        [JsonProperty("classificationType")]
        public IncomeClassificationType ClassificationType { get; set; }

        /// <summary>
        /// The income classification category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public IncomeClassificationCategory ClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The id
        /// </summary>
        [JsonProperty("id")]
        public byte? Id { get; set; }

        /// <summary>
        /// The quantity
        /// </summary>
        [JsonProperty("quantity15")]
        public int Quantity { get; set; }

        /// <summary>
        /// The item description
        /// </summary>
        [JsonProperty("itemDescr")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The discount amount
        /// </summary>
        [JsonProperty("discountAmount")]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// The discount percent
        /// </summary>
        [JsonProperty("discountPercent")]
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// The type of measurement
        /// </summary>
        [JsonProperty("measurementUnitName")]
        public MeasurementUnit MeasurementUnitName { get; set; }

        /// <summary>
        /// The vat percent
        /// </summary>
        [JsonProperty("vatPercent")]
        public decimal VATPercent { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationDataModel()
        {
            
        }

        #endregion
    }
}
