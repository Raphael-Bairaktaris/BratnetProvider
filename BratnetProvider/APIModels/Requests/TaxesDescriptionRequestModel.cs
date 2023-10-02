namespace BratnetProvider
{
    /// <summary>
    /// Request model used for taxes description invoices to the Bratnet provider
    /// </summary>
    public class TaxesDescriptionRequestModel
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
        public int LineId { get; set; }

        /// <summary>
        /// The tax description
        /// </summary>
        public string TaxDescription
        {
            get => mTaxDescription ?? string.Empty;

            set => mTaxDescription = value;
        }

        /// <summary>
        /// The tax amount
        /// </summary>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// The tax vat amount
        /// </summary>
        public decimal TaxVATAmount { get; set; }

        /// <summary>
        /// The vat category
        /// </summary>
        public VATCategory VATCategory { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxesDescriptionRequestModel()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="TaxDataModel"/> from the current <see cref="TaxRequestModel"/>
        /// </summary>
        /// <returns></returns>
        public TaxDescriptionDataModel TaxDescriptionDataModel()
        {
            var result = new TaxDescriptionDataModel()
            {
                TaxDescription = TaxDescription,
                TaxAmount = TaxAmount,
                TaxVATAmount = TaxVATAmount,
                VATCategory = VATCategory
            };

            return result;
        }

        #endregion
    }
}