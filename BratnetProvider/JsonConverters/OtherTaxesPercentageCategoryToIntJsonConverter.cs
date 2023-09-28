using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="OtherTaxesPercentageCategory"/> to <see cref="int"/>
    /// </summary>
    public class OtherTaxesPercentageCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<OtherTaxesPercentageCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OtherTaxesPercentageCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<OtherTaxesPercentageCategory, int> GetMapper() => BratnetProviderClientConstants.OtherTaxesPercentageCategoryToIntMapper;

        #endregion
    }
}
