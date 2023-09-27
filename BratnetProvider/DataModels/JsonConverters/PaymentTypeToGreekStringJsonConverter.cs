using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentType"/> to <see cref="string"/>
    /// </summary>
    public class PaymentTypeToGreekStringJsonConverter : JsonConverter<PaymentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTypeToGreekStringJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override PaymentType ReadJson(JsonReader reader, Type objectType, PaymentType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<string>(reader)!;

            foreach (var pair in BratnetProviderClientConstants.PaymentTypeToGreekStringMapper)
            {
                if (pair.Value == readerValue)
                    return pair.Key;
            }

            return default;
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, PaymentType value, JsonSerializer serializer)
        {
            writer.WriteValue(BratnetProviderClientConstants.PaymentTypeToGreekStringMapper[value]);
        }

        #endregion
    }
}
