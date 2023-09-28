using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="MovePurpose"/> to <see cref="string"/>
    /// </summary>
    public class MovePurposeToGreekStringJsonConverter : BaseEnumToStringJsonConverter<MovePurpose>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MovePurposeToGreekStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MovePurpose, string> GetMapper() => BratnetProviderClientConstants.MovePurposeToGreekStringMapper;

        #endregion
    }
}
