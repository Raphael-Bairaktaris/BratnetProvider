using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="FuelCodeCategoryType"/> to <see cref="int"/> 
    /// </summary>
    public class FuelCodeCategoryTypeToIntJsonConverter : BaseEnumToIntJsonConverter<FuelCodeCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FuelCodeCategoryTypeToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FuelCodeCategoryType, int> GetMapper() => BratnetProviderClientConstants.FuelCodeCategoryTypeToIntMapper;

        #endregion
    }
}
