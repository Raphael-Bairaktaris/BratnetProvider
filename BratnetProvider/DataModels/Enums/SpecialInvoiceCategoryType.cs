namespace BratnetProvider
{
    /// <summary>
    /// Special invoice category type enum
    /// </summary>
    public enum SpecialInvoiceCategoryType
    {
        /// <summary>
        /// Subsidies - grants
        /// </summary>
        SubsidiesGrants,

        /// <summary>
        /// Hotel retail revenue - charging room
        /// </summary>
        HotelRetailRevenueChargesRoom,

        /// <summary>
        /// Acounting entry
        /// </summary>
        AccountingEntry,

        /// <summary>
        /// Price valid only for transmission via erp or version 
        /// through provider or invoice
        /// </summary>
        TaxFree
    }
}
