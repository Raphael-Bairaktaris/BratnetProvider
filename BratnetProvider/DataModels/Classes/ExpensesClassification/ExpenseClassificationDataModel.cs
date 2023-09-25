using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an esxpense classification model
    /// </summary>
    public class ExpenseClassificationDataModel
    {
        #region Public Property

        /// <summary>
        /// The classification type
        /// </summary>
        public ExpenseClassificationType ClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        public ExpenseClassificationCategory ClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// Required
        /// Min value 0
        /// fraction digits 2
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The unique id
        /// </summary>
        public byte? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExpenseClassificationDataModel()
        {
            
        }

        #endregion
    }
}
