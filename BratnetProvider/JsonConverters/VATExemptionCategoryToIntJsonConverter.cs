using Newtonsoft.Json;

namespace BratnetProvider.JsonConverters
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="VATExemptionCategory"/> to <see cref="string"/>
    /// </summary>
    public class VATExmpetionCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<VATExemptionCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATExmpetionCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATExemptionCategory, int> GetMapper() => BratnetProviderClientConstants.VATExemptionCategoryToIntMapper;

        #endregion
    }
}