using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="CurrencyCode"/> to <see cref="string"/>
    /// </summary>
    public class CurrencyCodeToStringJsonConverter : JsonConverter<CurrencyCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyCodeToStringJsonConverter()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override CurrencyCode ReadJson(JsonReader reader, Type objectType, CurrencyCode existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            return Enum.Parse<CurrencyCode>(readerValue);
        }

        ///<inheritdoc/>
        public override void WriteJson(JsonWriter writer, CurrencyCode value, JsonSerializer serializer) 
        {
            writer.WriteValue(value.ToString());
        }

        #endregion
    }
}
