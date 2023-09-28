using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="InvoiceType"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceTypeToStringJsonConverter : BaseEnumToStringJsonConverter<InvoiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTypeToStringJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceType, string> GetMapper() => BratnetProviderClientConstants.InvoiceTypeToStringMapper;

        #endregion
    }
}
