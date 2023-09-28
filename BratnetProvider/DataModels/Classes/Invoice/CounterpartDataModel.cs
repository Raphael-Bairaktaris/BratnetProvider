using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represent a set of counterpart details
    /// </summary>
    public class CounterpartDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Address"/> property
        /// </summary>
        private AddressDataModel? mAddress;

        #endregion

        #region Public Property

        /// <summary>
        /// The VAT number
        /// </summary>
        [JsonProperty("vatNumber")]
        public string? VATNumber { get; set; }

        /// <summary>
        /// The country information
        /// </summary>
        [JsonProperty("country")]
        public CountryCode Country { get; set; } = CountryCode.GR;

        /// <summary>
        /// The branch
        /// </summary>
        [JsonProperty("branch")]
        public uint Branch { get; set; }

        /// <summary>
        /// The address
        /// </summary>
        [JsonProperty("address")]
        public AddressDataModel Address
        {
            get => mAddress ??= new();

            set => mAddress = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public CounterpartDataModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => VATNumber + " - " + Address;

        #endregion
    }
}
