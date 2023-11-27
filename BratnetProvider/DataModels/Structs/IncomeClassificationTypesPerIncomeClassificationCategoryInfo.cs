namespace BratnetProvider
{
    /// <summary>
    /// Contains all the <see cref="IncomeClassificationType"/>s that can be used in combination with a <see cref="Atom.Billing.MyData.IncomeClassificationCategory"/>
    /// </summary>
    public readonly record struct IncomeClassificationTypesPerIncomeClassificationCategoryInfo
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="IncomeClassificationCategory"/> property
        /// </summary>
        private readonly List<IncomeClassificationType> mIncomeClassificationTypes = new List<IncomeClassificationType>();

        #endregion

        #region Public Properties

        /// <summary>
        /// The income classification category
        /// </summary>
        public IncomeClassificationCategory IncomeClassificationCategory { get; }

        /// <summary>
        /// The income classification types linked to the <see cref="IncomeClassificationCategory"/>
        /// </summary>
        public IEnumerable<IncomeClassificationType> IncomeClassificationTypes => mIncomeClassificationTypes;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="incomeClassificationTypes">The income classification category</param>
        /// <param name="incomeClassificationCategory">The income classification types linked to the <see cref="IncomeClassificationCategory"/></param>
        public IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory incomeClassificationCategory, IEnumerable<IncomeClassificationType>? incomeClassificationTypes)
        {
            IncomeClassificationCategory = incomeClassificationCategory;
            mIncomeClassificationTypes.AddRange(incomeClassificationTypes ?? Enumerable.Empty<IncomeClassificationType>());
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Category: {IncomeClassificationCategory} -> Types: {IncomeClassificationTypes.Count()}";

        #endregion
    }

    /// <summary>
    /// Contains all the <see cref="IncomeClassificationTypesPerIncomeClassificationCategoryInfo"/> that can be used in combination with an <see cref="Atom.Billing.MyData.InvoiceType"/>
    /// </summary>
    public readonly record struct IncomeClassificationCategoriesPerInvoceTypeInfo
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="IncomeClassificationCategories"/> properties
        /// </summary>
        private readonly List<IncomeClassificationTypesPerIncomeClassificationCategoryInfo> mIncomeClassificationCategories = new List<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>();

        #endregion

        #region Public Properties

        /// <summary>
        /// The invoice type
        /// </summary>
        public InvoiceType InvoiceType { get; }

        /// <summary>
        /// The income classification categories linked to the <see cref="InvoiceType"/>
        /// </summary>
        public IEnumerable<IncomeClassificationTypesPerIncomeClassificationCategoryInfo> IncomeClassificationCategories => mIncomeClassificationCategories;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="invoiceType">The invoice type</param>
        /// <param name="incomeClassificationCategories">The income classification categories linked to the <see cref="InvoiceType"/></param>
        public IncomeClassificationCategoriesPerInvoceTypeInfo(InvoiceType invoiceType, IEnumerable<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>? incomeClassificationCategories)
        {
            InvoiceType = invoiceType;
            mIncomeClassificationCategories.AddRange(incomeClassificationCategories ?? Enumerable.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>());
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Invoice type: {InvoiceType} -> Categories: {IncomeClassificationCategories.Count()}";

        #endregion
    }

}
