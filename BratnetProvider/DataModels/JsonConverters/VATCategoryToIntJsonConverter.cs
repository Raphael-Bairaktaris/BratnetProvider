using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="VATCategory"/> to <see cref="int"/>
    /// </summary>
    public class VATCategoryToIntJsonConverter : JsonConverter<VATCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override VATCategory ReadJson(JsonReader reader, Type objectType, VATCategory existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<int>(reader)!;

            foreach (var pair in BratnetProviderClientConstants.VATCategoryToIntMapper)
            {
                if (pair.Value == readerValue)
                    return pair.Key;
            }

            return default;
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, VATCategory value, JsonSerializer serializer)
        {
            writer.WriteValue(BratnetProviderClientConstants.VATCategoryToIntMapper[value]);
        }

        #endregion
    }
}