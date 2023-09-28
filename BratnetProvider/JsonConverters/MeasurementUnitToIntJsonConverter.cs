using Newtonsoft.Json;


namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="MeasurementUnit"/> to <see cref="int"/> 
    /// </summary>
    public class MeasurementUnitToIntJsonConverter : BaseEnumToIntJsonConverter<MeasurementUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurementUnit, int> GetMapper() => BratnetProviderClientConstants.MeasurementUnitToIntMapper;

        #endregion
    }
}
