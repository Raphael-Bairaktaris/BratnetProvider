using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="WithholdingTaxCategory"/> to <see cref="int"/>
    /// </summary>
    public class WithholdingTaxCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<WithholdingTaxCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public WithholdingTaxCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<WithholdingTaxCategory, int> GetMapper() => BratnetProviderClientConstants.WithholdingTaxCategoryToIntMapper;

        #endregion
    }
}