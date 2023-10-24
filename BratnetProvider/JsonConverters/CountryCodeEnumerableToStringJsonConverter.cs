using Newtonsoft.Json;

namespace BratnetProvider 
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CountryCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryCodeEnumerableToStringConverter : BaseEnumEnumerableJsonConverter<CountryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryCodeEnumerableToStringConverter()
        {

        }
        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CountryCode, string> GetMapper() => new Dictionary<CountryCode, string>();

        #endregion
    }
}