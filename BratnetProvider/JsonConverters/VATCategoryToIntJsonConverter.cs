using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="VATCategory"/> to <see cref="int"/>
    /// </summary>
    public class VATCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<VATCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATCategory, int> GetMapper() => BratnetProviderClientConstants.VATCategoryToIntMapper;

        #endregion
    }
}