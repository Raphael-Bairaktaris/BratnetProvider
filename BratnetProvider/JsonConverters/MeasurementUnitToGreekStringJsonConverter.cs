using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="MeasurementUnit"/> to <see cref="string"/> 
    /// </summary>
    public class MeasurementUnitToGreekStringJsonConverter : BaseEnumToStringJsonConverter<MeasurementUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitToGreekStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurementUnit, string> GetMapper() => BratnetProviderClientConstants.MeasurementUnitToGreekStringMapper;

        #endregion
    }
}
