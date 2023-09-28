using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentType"/> to <see cref="int"/>
    /// </summary>
    public class PaymentTypeToIntMapper : BaseEnumToIntJsonConverter<PaymentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTypeToIntMapper()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentType, int> GetMapper() => BratnetProviderClientConstants.PaymentTypeToIntMapper;

        #endregion
    }
}
