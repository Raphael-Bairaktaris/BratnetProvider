using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a set of issuer details 
    /// </summary>
    public class IssuerDetailDataModel : CounterpartDataModel
    {
        #region Public Properties

        /// <summary>
        /// The name
        /// Max lenght = 150
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IssuerDetailDataModel()
        {

        }

        #endregion
    }
}
