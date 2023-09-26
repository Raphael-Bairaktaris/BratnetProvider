using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="DocumentDeviationType"/> to <see cref="int"/>
    /// </summary>
    public class DocumentDeviationTypeToIntJsonConverter : JsonConverter<DocumentDeviationType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DocumentDeviationTypeToIntJsonConverter()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override DocumentDeviationType ReadJson(JsonReader reader, Type objectType, DocumentDeviationType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<int>(reader)!;

            return Enum.Parse<DocumentDeviationType>(readerValue);
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, DocumentDeviationType value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        #endregion
    }
}
