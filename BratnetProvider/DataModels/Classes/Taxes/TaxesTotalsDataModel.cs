using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    public class TaxesTotalsDataModel
    {
        #region Public Property

        /// <summary>
        /// The taxes totals
        /// </summary>
        [JsonProperty("taxesTotals")]
        public TaxesDataModel TaxesTotals { get; set; } 

        /// <summary>
        /// The taxes description totals
        /// </summary>
        public TaxesDescriptionDataModel TaxesTotals { get; set; }

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
