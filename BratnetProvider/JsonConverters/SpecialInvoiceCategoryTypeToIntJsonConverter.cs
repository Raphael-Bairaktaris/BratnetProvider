using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="SpecialInvoiceCategoryType"/> to <see cref="int"/> 
    /// </summary>
    public class SpecialInvoiceCategoryTypeToIntJsonConverter : BaseEnumToIntJsonConverter<SpecialInvoiceCategoryType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SpecialInvoiceCategoryTypeToIntJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<SpecialInvoiceCategoryType, int> GetMapper() => BratnetProviderClientConstants.SpecialInvoiceCategotyTypeToIntMapper;

        #endregion
    }
}
