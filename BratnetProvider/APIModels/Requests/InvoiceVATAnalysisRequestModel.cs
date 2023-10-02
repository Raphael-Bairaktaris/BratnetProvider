namespace BratnetProvider
{
    /// <summary>
    /// Request model used for sending invoice VAT analysis to the Bratnet provider
    /// </summary>
    public class InvoiceVATAnalysisRequestModel
    {
        #region Public Property

        /// <summary>
        /// The vat category
        /// </summary>
        public VATCategory VATCategory { get; set; }

        /// <summary>
        /// The vat percent
        /// </summary>
        public decimal VATPercent { get; set; }

        /// <summary>
        /// The net value per vat
        /// </summary>
        public decimal NetAmount { get; set; }

        /// <summary>
        /// The vat amount
        /// </summary>
        public decimal VATAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceVATAnalysisRequestModel()
        {

        }

        #endregion
    }
}