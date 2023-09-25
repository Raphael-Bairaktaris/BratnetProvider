﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represents an income classification data
    /// </summary>
    public class IncomeClassificationDataModel
    {
        #region Public Property

        /// <summary>
        /// The classification type
        /// </summary>
        public IncomeClassificationType ClassificationType { get; set; }

        /// <summary>
        /// The classification category
        /// </summary>
        public IncomeClassificationCategory ClassificationCategory { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The Id
        /// </summary>
        public byte? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationDataModel()
        {
            
        }

        #endregion
    }
}
