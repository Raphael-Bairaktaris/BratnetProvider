using Newtonsoft.Json;

namespace BratnetProvider
{
    public class TaxesTotalsDataModel
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
        public TaxesTotalsDataModel()
        {
            
        }

        #endregion
    }
}
