using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a taxes totals data
    /// </summary>
    public class TaxTotalsDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TaxDataModel"/> property
        /// </summary>
        private IEnumerable<TaxDataModel>? mTaxDataModel;

        #endregion

        #region Public Property

        /// <summary>
        /// The taxes totals
        /// </summary>
        [JsonProperty("taxesTotals")]
        public IEnumerable<TaxDataModel> Taxes
        {
            get => mTaxDataModel ?? Enumerable.Empty<TaxDataModel>();

            set => mTaxDataModel = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxTotalsDataModel()
        {

        }

        #endregion
    }
}
