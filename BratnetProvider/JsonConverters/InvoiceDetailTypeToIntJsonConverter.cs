using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="InvoiceDetailType"/> to <see cref="int"/>
    /// </summary>
    public class InvoiceDetailTypeToIntJsonConverter : BaseEnumToIntJsonConverter<InvoiceDetailType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailTypeToIntJsonConverter()
        {
            
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<InvoiceDetailType, int> GetMapper() => BratnetProviderClientConstants.InvoiceDetailTypeToIntMapper;

        #endregion
    }
}
