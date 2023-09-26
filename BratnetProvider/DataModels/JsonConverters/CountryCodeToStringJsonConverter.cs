using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="CountryCodeToStringJsonConverter{T}"/> that converts a <see cref="CountryCode"/> to <see cref="string"/>
    /// </summary>
    public class CountryCodeToStringJsonConverter : JsonConverter<CountryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CountryCodeToStringJsonConverter()
        {
            
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override CountryCode ReadJson(JsonReader reader, Type objectType, CountryCode existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            return Enum.Parse<CountryCode>(readerValue);
        }

        ///<inheritdoc/>
        public override void WriteJson(JsonWriter writer, CountryCode value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        #endregion
    }
}
