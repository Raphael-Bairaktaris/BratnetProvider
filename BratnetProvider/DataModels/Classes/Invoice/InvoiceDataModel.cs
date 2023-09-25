using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace BratnetProvider
{
    /// <summary>
    /// Represents an invoice data
    /// </summary>
    public class InvoiceDataModel
    {
        #region Private Members


        #endregion

        #region Public Property

        /// <summary>
        /// The unique auto incremented item uid
        /// </summary>
        [JsonProperty("uid")]
        public uint UId { get; set; }

        /// <summary>
        /// The invoice unique mark
        /// </summary>
        [JsonProperty("mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// The invoice cancellation mark
        /// </summary>
        [JsonProperty("cancelledByMark")]
        public long? CancelledByMark { get; set; }

        /// <summary>
        /// The invoice authentication code
        /// </summary>
        [JsonProperty("authenticationCode")]
        public string? AuthenticationCode { get; set; }

        /// <summary>
        /// The invoice transmission failure
        /// </summary>
        [JsonProperty("transmissionFailure")]
        public string? TransmissionFailure { get; set; }

        /// <summary>
        /// The invoice issuer
        /// </summary>
        [JsonProperty("issuer")]
        public VATNumberDataModel? Issuer { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDataModel()
        {
            
        }

        #endregion
    }
}