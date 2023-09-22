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

        /// <summary>
        /// The member of the <see cref="AuthenticationCode"/> property
        /// </summary>
        private string? mAuthenticationCode;

        #endregion

        #region Public Property

        /// <summary>
        /// The unique auto incremented item uid
        /// </summary>
        [AllowNull]
        [JsonProperty("uid")]
        public uint UId { get; set; }

        /// <summary>
        /// The invoice unique mark
        /// </summary>
        [AllowNull]
        [JsonProperty("mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// The invoice cancellation mark
        /// </summary>
        [AllowNull]
        [JsonProperty("cancelledByMark")]
        public long? CancelledByMark { get; set; }

        /// <summary>
        /// The invoice authentication code
        /// </summary>
        [AllowNull]
        [JsonProperty("authenticationCode")]
        public string AuthenticationCode 
        { 
            get => mAuthenticationCode ?? string.Empty;
            set => mAuthenticationCode = value;
        }

        /// <summary>
        /// The invoice transmission failure
        /// </summary>
        [JsonProperty("transmissionFailure")]
        public object TransmissionFailure { get; set; }

        /// <summary>
        /// The invoice issuer
        /// </summary>
        [AllowNull]
        [JsonProperty("issuer")]
        public VATNumberDataModel Issuer { get; set; }

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