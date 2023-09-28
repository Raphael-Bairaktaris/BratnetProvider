using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="TimeOnly"/> to <see cref="string"/>
    /// </summary>
    public class TimeOnlyToStringJsonConveter : BaseFormattableValueToStringJsonConverter<TimeOnly>
    {
        #region Constants

        /// <summary>
        /// The format that is used for serializing and deserializing times
        /// </summary>
        public const string TimeFormat = "hh:mm:ss";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeOnlyToStringJsonConveter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override string GetFormat() => TimeFormat;

        #endregion
    }
}