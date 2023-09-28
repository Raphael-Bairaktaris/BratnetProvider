namespace BratnetProvider
{
    /// <summary>
    /// The withheld tax percentage category
    /// </summary>
    public enum WithholdingTaxCategory
    {
        /// <summary>
        /// Approx. b'- Interest - 15%
        /// </summary>
        CaseBTax15Percent,

        /// <summary>
        /// Approx. c' - Rights - 20%
        /// </summary>
        CaseCRights20Percent,

        /// <summary>
        /// Approx. d' - Management Consulting Fees - 20%
        /// </summary>
        CaseDManagementAdviceFees20Percent,

        /// <summary>
        /// Approx. d' - Technical Works - 3%
        /// </summary>
        CaseDTechnicalWorks3Percent,

        /// <summary>
        /// Liquid fuels and tobacco industry products 1%
        /// </summary>
        LiquidFuelsAndTobaccoProducts1Percent,

        /// <summary>
        /// Other Goods 4%
        /// </summary>
        OtherGoods4Percent,

        /// <summary>
        /// Service Delivery 8%
        /// </summary>
        Services8Percent,

        /// <summary>
        /// Architects' and Engineers' Prepaid Tax on Contracts Fees, 
        /// for Preparation of Studies and Plans 4%
        /// </summary>
        AdvancePayment4Percent,

        /// <summary>
        /// Architects' and Engineers' Prepaid Tax on Contracts
        /// Fees, related to projects of any other nature 10%
        /// </summary>
        AdvancePayment10Percent,

        /// <summary>
        /// Withholding Tax on Attorneys' Fees 15%
        /// </summary>
        AdvancePayment15Percent,

        /// <summary>
        /// Wage Tax withholding para. 1 no. 15 n. 4172/2013
        /// </summary>
        WithholdingTaxPercent,

        /// <summary>
        /// Wage Tax Withholding para. 2 no. 15 Law 4172/2013 -
        /// Merchant Marine Officers
        /// </summary>
        WithholdingTax15Percent,

        /// <summary>
        /// Wage Tax Withholding para. 2 no. 15 Law 4172/2013 -
        /// Junior Crew of the Merchant Navy
        /// </summary>
        WithholdingTax10Percent,

        /// <summary>
        /// Withholding special solidarity contribution
        /// </summary>
        WithholdingSpecialSolidarityContribution,

        /// <summary>
        /// Withholding termination of employment
        /// </summary>
        WithholdingTerminationOfEmployment,

        /// <summary>
        /// Withholdings on foreign transactions based on avoidance 
        /// agreements double taxation (S.A.D.F.)
        /// </summary>
        WithholdingForeignTransaction,

        /// <summary>
        /// Other Withholding Taxes
        /// </summary>
        OtherWithholdingTaxes,

        /// <summary>
        /// Withholding Tax Dividends per para. 1 no. 64 n. 4172/2013
        /// </summary>
        WitholdingTaxDividend
    }
}
