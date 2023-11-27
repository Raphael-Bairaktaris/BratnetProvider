namespace BratnetProvider
{
    /// <summary>
    /// Contains all the <see cref="ExpenseClassificationType"/>s that can be used in combination with an <see cref="ExpenseClassificationCategory"/>
    /// </summary>
    public readonly record struct ExpenseClassificationTypesPerExpenseClassificationCategoryInfo
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ExpenseClassificationTypes"/>
        /// </summary>
        private readonly List<ExpenseClassificationType> mExpenseClassificationTypes = new();

        #endregion

        #region Public Properties

        /// <summary>
        /// The expense classification category
        /// </summary>
        public ExpenseClassificationCategory ExpenseClassificationCategory { get; }

        /// <summary>
        /// The expense classification types linked to the <see cref="ExpenseClassificationCategory"/>
        /// </summary>
        public IEnumerable<ExpenseClassificationType> ExpenseClassificationTypes => mExpenseClassificationTypes;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="expenseClassificationCategory">The expense classification category</param>
        /// <param name="expenseClassificationTypes">The expense classification type linkedd to the <see cref="ExpenseClassificationCategory"/> </param>
        public ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory expenseClassificationCategory, IEnumerable<ExpenseClassificationType>? expenseClassificationTypes)
        {
            ExpenseClassificationCategory = expenseClassificationCategory;
            mExpenseClassificationTypes.AddRange(expenseClassificationTypes ?? Enumerable.Empty<ExpenseClassificationType>());
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Category: {ExpenseClassificationCategory} -> Types: {ExpenseClassificationTypes.Count()}";

        #endregion
    }

    /// <summary>
    /// Contains all the <see cref="ExpenseClassificationTypesPerExpenseClassificationCategoryInfo"/> that can be used in combination with an <see cref="InvoiceType"/>
    /// </summary>
    public readonly record struct ExpenseClassificationCategoriesPerInvoiceTypeInfo
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ExpenseClassificationCategory"/>
        /// </summary>
        private readonly List<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo> mExpenseClassificationCategories = new();

        #endregion

        #region Public Properties

        /// <summary>
        /// The invoice type
        /// </summary>
        public InvoiceType InvoiceType { get; }

        /// <summary>
        /// The expense classification categories linked to the <see cref="InvoiceType"/>
        /// </summary>
        public IEnumerable<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo> ExpenseClassificationCategories => mExpenseClassificationCategories;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="invoiceType">The invoice type</param>
        /// <param name="expenseClassificationCategories">The expense classification categories linked to the <see cref="InvoiceType"/></param>
        public ExpenseClassificationCategoriesPerInvoiceTypeInfo(InvoiceType invoiceType, IEnumerable<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>? expenseClassificationCategories)
        {
            InvoiceType = invoiceType;
            mExpenseClassificationCategories.AddRange(expenseClassificationCategories ?? Enumerable.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>());
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"Invoice type: {InvoiceType} -> Categories: {ExpenseClassificationCategories.Count()}";

        #endregion
    }
}
