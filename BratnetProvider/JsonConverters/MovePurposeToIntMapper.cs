using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="MovePurpose"/> to <see cref="int"/>
    /// </summary>
    public class MovePurposeToIntJsonConverter : BaseEnumToIntJsonConverter<MovePurpose>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MovePurposeToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MovePurpose, int> GetMapper() => BratnetProviderClientConstants.MovePurposeToIntMapper;

        #endregion
    }
}
