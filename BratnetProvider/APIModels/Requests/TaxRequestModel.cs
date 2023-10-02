using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Request model used for sending invoice taxes to the Bratnet provider
    /// </summary>
    public class TaxRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The tax type
        /// </summary>
        public TaxType TaxType { get; set; }

        /// <summary>
        /// The tax category
        /// </summary>
        public VATCategory TaxCategory { get; set; }

        /// <summary>
        /// The underlying value
        /// Min Value 0
        /// Fraction digits 2
        /// </summary>
        public decimal UnderlyingValue { get; set; }

        /// <summary>
        /// The tax amount
        /// Min value 0
        /// Fraction digits 2
        /// Required
        /// </summary>
        public decimal TaxAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxRequestModel()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="TaxDataModel"/> from the current <see cref="TaxRequestModel"/>
        /// </summary>
        /// <returns></returns>
        public TaxDataModel TaxDataModel()
        {
            var result = new TaxDataModel()
            {
                TaxType = TaxType,
                TaxCategory = TaxCategory,
                UnderlyingValue = UnderlyingValue,
                TaxAmount = TaxAmount

            };

            return result;
        }

        #endregion
    }
}