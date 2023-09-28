using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="FeesPercentageCategory"/> to <see cref="int"/>
    /// </summary>
    public class FeesPercentageCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<FeesPercentageCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FeesPercentageCategoryToIntJsonConverter()
        {

        }

        #endregion


        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FeesPercentageCategory, int> GetMapper() => BratnetProviderClientConstants.FeesPercentageCategoryToIntMapper;

        #endregion
    }
}
