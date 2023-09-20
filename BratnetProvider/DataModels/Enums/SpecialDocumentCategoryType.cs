using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    public enum SpecialDocumentCategoryType
    {
        /// <summary>
        /// Subsidies - grants
        /// </summary>
        SubsidiesGrants,

        /// <summary>
        /// Hotel retail revenue - charging room
        /// </summary>
        HotelRetailRevenueChargesRoom,

        /// <summary>
        /// Acounting entry
        /// </summary>
        AccountingEntry,

        /// <summary>
        /// Price valid only for transmission via erp or version 
        /// through provider or invoice
        /// </summary>
        TaxFree
    }
}
