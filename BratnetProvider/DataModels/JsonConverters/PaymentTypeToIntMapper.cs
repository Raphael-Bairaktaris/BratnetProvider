using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentType"/> to <see cref="int"/>
    /// </summary>
    public class PaymentTypeToIntMapper : JsonConverter<PaymentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTypeToIntMapper()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override PaymentType ReadJson(JsonReader reader, Type objectType, PaymentType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var readerValue = serializer.Deserialize<int>(reader)!;

            foreach (var pair in BratnetProviderClientConstants.PaymentTypeToIntMapper)
            {
                if (pair.Value == readerValue)
                    return pair.Key;
            }

            return default;
        }

        /// <inheritdoc/> 
        public override void WriteJson(JsonWriter writer, PaymentType value, JsonSerializer serializer)
        {
            writer.WriteValue(BratnetProviderClientConstants.PaymentTypeToIntMapper[value]);
        }

        #endregion
    }
}
