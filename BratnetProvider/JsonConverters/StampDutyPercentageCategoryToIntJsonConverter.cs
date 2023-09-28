using Newtonsoft.Json;

namespace BratnetProvider.JsonConverters
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="StampDutyPercentageCategory"/> to <see cref="int"/>
    /// </summary>
    public class StampDutyPercentageCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<StampDutyPercentageCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public StampDutyPercentageCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<StampDutyPercentageCategory, int> GetMapper() => BratnetProviderClientConstants.StampDutyPercentageCategoryToIntMapper;

        #endregion
    }
}
