namespace BratnetProvider
{
    /// <summary>
    /// The VAT category enum
    /// </summary>
    public enum VATCategory
    {
        /// <summary>
        /// VAT rate 24%
        /// </summary>
        VATRate24 = 1,

        /// <summary>
        /// VAT rate 13%
        /// </summary>
        VATRate13 = 2,

        /// <summary>
        /// VAT rate 6%
        /// </summary>
        VATRate6 = 3,

        /// <summary>
        /// VAT rate 17%
        /// </summary>
        VATRate17 = 4,

        /// <summary>
        /// VAT rate 9%
        /// </summary>
        VATRate9 = 5,

        /// <summary>
        /// VAT rate 4%
        /// </summary>
        VATRate4 = 6,

        /// <summary>
        /// VAT excluded
        /// </summary>
        ExcludingVAT = 7,

        /// <summary>
        /// Registrations without VAT
        /// </summary>
        /// <example>
        /// Payroll, Depreciation etc.
        /// </example>
        EntriesWithoutVAT = 8
    }
}
