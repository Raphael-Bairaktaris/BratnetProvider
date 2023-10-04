using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represent a taxes details descriptio. data
    /// </summary>
    public class TaxDescriptionDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TaxDescription"/> property
        /// </summary>
        private string? mTaxDescription;

        #endregion

        #region Public Property

        /// <summary>
        /// The line id
        /// </summary>
        [JsonProperty("lineid")]
        public int LineId { get; set; }

        /// <summary>
        /// The tax description
        /// </summary>
        [AllowNull]
        [JsonProperty("taxDescription")]
        public string TaxDescription
        {
            get => mTaxDescription ?? string.Empty;

            set => mTaxDescription = value;
        }

        /// <summary>
        /// The tax amount
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// The tax vat amount
        /// </summary>
        [JsonProperty("taxVatAmount")]
        public decimal TaxVATAmount { get; set; }

        /// <summary>
        /// The vat category
        /// </summary>
        [JsonProperty("VatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory VATCategory { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxDescriptionDataModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => TaxDescription;

        #endregion
    }
}
