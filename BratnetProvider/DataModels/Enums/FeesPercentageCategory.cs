namespace BratnetProvider
{
    /// <summary>
    /// The fees percentage category
    /// </summary>
    public enum FeesPercentageCategory
    {
        /// <summary>
        /// For a monthly bill up to 50 euros 12%
        /// </summary>
        MonthlyBill12Percent,

        /// <summary>
        /// For a monthly bill from 50.01 up to 100 euros 15%
        /// </summary>
        MonthlyBill15Percent,

        /// <summary>
        /// For a monthly bill from 100.01 up to 150 euros 18%
        /// </summary>
        MonthlyBill18Percent,

        /// <summary>
        /// For a monthly bill from 150.01 euros and above 20%
        /// </summary>
        MonthlyBill20Percent,

        /// <summary>
        /// Mobile calls fee 12%
        /// </summary>
        MobileCalls12Percent,

        /// <summary>
        /// Cable TV 10% off
        /// </summary>
        CableTV10Percent,

        /// <summary>
        /// 5% landline subscriber fee
        /// </summary>
        Telephone5Percent,

        /// <summary>
        /// Environmental Fee and plastic bag Law 2339/2001 no. 6a 0.07 euros per piece
        /// </summary>
        EnvironmentalFeePercentForPlasticBag,

        /// <summary>
        /// Homicide Levy 2%
        /// </summary>
        Homicide2Percent,

        /// <summary>
        /// Other Fees
        /// </summary>
        OtherFees,

        /// <summary>
        /// Other tax fees
        /// </summary>
        OtherTaxFees,

        /// <summary>
        /// Homicide contribution
        /// </summary>
        HomicideContribution,

        /// <summary>
        /// For monthly bill of each connection (10%)
        /// </summary>
        MonthlyBillOfEachConnection10Percent,

        /// <summary>
        /// Mobile calls fee 10%
        /// </summary>
        MobileCalls10Percent,

        /// <summary>
        /// Mobile and prepaid fee for natural persons aged 15-29 0%
        /// </summary>
        MobileAndPrepaidFee0Percent,

        /// <summary>
        /// Contribution of environmental protection of plastic products 
        /// 0.04 euros per piece [Article 4 of Law 4736/2020
        /// </summary>
        EnvironmentalFeePercentForPlasticProducts,

        /// <summary>
        /// Recycling fee 0.08 cents per piece [Article 80 of Law 4819/2021]
        /// </summary>
        RecyclingFee,

        /// <summary>
        /// Accommodation fee for transients
        /// </summary>
        AccommodationFee,

        /// <summary>
        /// Tax on the gross revenues of restaurants and related shops
        /// </summary>
        GrossRevenueTaxOfRestaurants,

        /// <summary>
        /// Fee on the gross receipts of entertainment centers
        /// </summary>
        GrossReceiptFeeOfEntertainmentCenters,

        /// <summary>
        /// Tax on casino gross receipts
        /// </summary>
        CasinoGrossReceiptsTax,

        /// <summary>
        /// Other fees on gross receipts
        /// </summary>
        OtherFeeOnGrossReceipts
    }
}
