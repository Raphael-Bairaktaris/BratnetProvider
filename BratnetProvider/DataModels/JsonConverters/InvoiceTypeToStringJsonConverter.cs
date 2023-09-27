using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="InvoiceType"/> to <see cref="string"/>
    /// </summary>
    public class InvoiceTypeToStringJsonConverter : JsonConverter<InvoiceType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceTypeToStringJsonConverter()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override InvoiceType ReadJson(JsonReader reader, Type objectType, InvoiceType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            foreach(var pair in BratnetProviderClientConstants.InvoiceTypeToStringMapper)
            {
                if (pair.Value == readerValue)
                    return pair.Key;
            }

            return default;
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, InvoiceType value, JsonSerializer serializer)
        {
            writer.WriteValue(BratnetProviderClientConstants.InvoiceTypeToStringMapper[value]);
        }

        #endregion
    }
}
