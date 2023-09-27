using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="MovePurpose"/> to <see cref="int"/>
    /// </summary>
    public class MovePurposeToGreekStringJsonConverter : JsonConverter<MovePurpose>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MovePurposeToGreekStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override MovePurpose ReadJson(JsonReader reader, Type objectType, MovePurpose existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            foreach (var pair in BratnetProviderClientConstants.MovePurposeToGreekStringMapper)
            {
                if (pair.Value == readerValue)
                    return pair.Key;
            }

            return default;
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, MovePurpose value, JsonSerializer serializer)
        {
            writer.WriteValue(BratnetProviderClientConstants.MovePurposeToGreekStringMapper[value]);
        }

        #endregion
    }
}
