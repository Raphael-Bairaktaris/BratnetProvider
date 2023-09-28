using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="TaxType"/> to <see cref="int"/>
    /// </summary>
    public class TaxTypeToIntJsonConverter : BaseEnumToIntJsonConverter<TaxType>
    {


        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxTypeToIntJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TaxType, int> GetMapper() => BratnetProviderClientConstants.TaxTypeToIntMapper;

        #endregion
    }
}
