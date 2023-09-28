using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a taxes totals data
    /// </summary>
    public class TaxesTotalsDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TaxesDataModel"/> property
        /// </summary>
        private IEnumerable<TaxesDataModel>? mTaxDataModel;

        #endregion

        #region Public Property

        /// <summary>
        /// The taxes totals
        /// </summary>
        [JsonProperty("taxesTotals")]
        public IEnumerable<TaxesDataModel> Taxes
        {
            get => mTaxDataModel ?? Enumerable.Empty<TaxesDataModel>();

            set => mTaxDataModel = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxesTotalsDataModel()
        {

        }

        #endregion
    }
}
