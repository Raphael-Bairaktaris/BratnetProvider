using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentType"/> to <see cref="string"/>
    /// </summary>
    public class PaymentTypeToGreekStringJsonConverter : BaseEnumToStringJsonConverter<PaymentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTypeToGreekStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentType, string> GetMapper() => BratnetProviderClientConstants.PaymentTypeToGreekStringMapper;

        #endregion
    }
}
