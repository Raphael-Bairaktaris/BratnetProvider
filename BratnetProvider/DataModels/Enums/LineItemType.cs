namespace BratnetProvider
{
    /// <summary>
    /// The line item type enum
    /// </summary>
    public enum LineItemType
    {
        //codes 1 - 4 - 5 for future use
        //code 7 valid for spicific invoices
        /// <summary>
        /// Special withholding tax line
        /// </summary>
        SpecialWithholdingTaxLine,

        /// <summary>
        /// Stamp duty special tax line
        /// </summary>
        StampDutySpecialLine,

        /// <summary>
        /// Special reservation line
        /// </summary>
        SpecialReservationLine,

        /// <summary>
        /// End line iwth VAT
        /// </summary>
        EndLineWithVAT,

        /// <summary>
        /// Other tax line with VAT
        /// </summary>
        OtherTaxLineWithVAT,

        /// <summary>
        /// Giftcard
        /// </summary>
        Giftcard,

        /// <summary>
        /// Negative sign of values
        /// </summary>
        NegativeSignOfValues
    }
}
