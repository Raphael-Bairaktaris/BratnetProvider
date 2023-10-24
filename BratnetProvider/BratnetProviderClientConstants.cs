using System.Collections.Immutable;

namespace BratnetProvider
{
    /// <summary>
    /// Constants related to the bratnet provider client
    /// </summary>
    public static class BratnetProviderClientConstants
    {
        /// <summary>
        /// Maps the <see cref="DocumentDeviationType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DocumentDeviationType, int> DocumentDeviationTypeToIntMapper { get; } = new Dictionary<DocumentDeviationType, int>()
        {
            { DocumentDeviationType.RecipientOmissionTransmission, 1 },
            { DocumentDeviationType.IssuerOmissionTransmission, 2 },
            { DocumentDeviationType.TransmissionOfDeviationFromReceiver, 3 },
            { DocumentDeviationType.TransmissionOfDeviationFromPublisher, 4 }

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="FeesPercentageCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<FeesPercentageCategory, int> FeesPercentageCategoryToIntMapper { get; } = new Dictionary<FeesPercentageCategory, int>()
        {
            { FeesPercentageCategory.MonthlyBill12Percent, 1 },
            { FeesPercentageCategory.MonthlyBill15Percent, 2 },
            { FeesPercentageCategory.MonthlyBill18Percent, 3 },
            { FeesPercentageCategory.MonthlyBill20Percent, 4 },
            { FeesPercentageCategory.MobileCalls12Percent, 5 },
            { FeesPercentageCategory.CableTV10Percent, 6 },
            { FeesPercentageCategory.Telephone5Percent, 7 },
            { FeesPercentageCategory.EnvironmentalFeePercentForPlasticBag, 8 },
            { FeesPercentageCategory.Homicide2Percent, 9 },
            { FeesPercentageCategory.OtherFees, 10 },
            { FeesPercentageCategory.OtherTaxFees, 11 },
            { FeesPercentageCategory.HomicideContribution, 12 },
            { FeesPercentageCategory.MonthlyBillOfEachConnection10Percent, 13 },
            { FeesPercentageCategory.MobileCalls10Percent, 14 },
            { FeesPercentageCategory.MobileAndPrepaidFee0Percent, 15 },
            { FeesPercentageCategory.EnvironmentalFeePercentForPlasticProducts, 16 },
            { FeesPercentageCategory.RecyclingFee, 17 },
            { FeesPercentageCategory.AccommodationFee, 18 },
            { FeesPercentageCategory.GrossRevenueTaxOfRestaurants, 19 },
            { FeesPercentageCategory.GrossReceiptFeeOfEntertainmentCenters, 20 },
            { FeesPercentageCategory.CasinoGrossReceiptsTax, 21 },
            { FeesPercentageCategory.OtherFeeOnGrossReceipts, 22 }

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="FuelCodeCategoryType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<FuelCodeCategoryType, int> FuelCodeCategoryTypeToIntMapper { get; } = new Dictionary<FuelCodeCategoryType, int>()
        {
            // Benzine
            { FuelCodeCategoryType.Benzine95RON, 10},
            { FuelCodeCategoryType.Benzine95RONPlus, 11},
            { FuelCodeCategoryType.Benzine100RON, 12},
            { FuelCodeCategoryType.BenzineLRP, 13},
            { FuelCodeCategoryType.AirplaneBenzine, 14},

            // Diesel
            { FuelCodeCategoryType.SpecialJetFuel, 15},
            { FuelCodeCategoryType.Diesel, 20},
            { FuelCodeCategoryType.DieselPremium, 21},
            { FuelCodeCategoryType.DieselHeatnn, 30},
            { FuelCodeCategoryType.DieaselHeatPremium, 31},
            { FuelCodeCategoryType.DieselLight, 32},
            { FuelCodeCategoryType.OtherUseDiesel, 33},
            { FuelCodeCategoryType.NavyDiesel, 34},

            // Kerosene
            { FuelCodeCategoryType.KerosenJP1, 35},
            { FuelCodeCategoryType.OtherUseKerosene, 36},
            { FuelCodeCategoryType.FuelOil, 37},

            // Oil
            { FuelCodeCategoryType.NavyFuelOil, 38},

            // LPG (liquid gas)
            { FuelCodeCategoryType.LPG, 40},
            { FuelCodeCategoryType.LPGAndMethaneIndustial, 41},
            { FuelCodeCategoryType.LPGAndMethaneHeating, 42},
            { FuelCodeCategoryType.LPGAndMethaneCommercialEngines, 43},
            { FuelCodeCategoryType.LPGAndMethaneHeatingOtherUse, 44},

            // CNG (Compressed Natural Gas)
            { FuelCodeCategoryType.CNG, 50},

            // Hydrocarbons
            { FuelCodeCategoryType.AromaticHydrocarbons, 60},
            { FuelCodeCategoryType.CyclicHydrocarbons, 61},

            // Light oils
            { FuelCodeCategoryType.LightPetrol, 70},
            { FuelCodeCategoryType.LightOil, 71},

            // Biodiesel
            { FuelCodeCategoryType.Biodiesel, 72},

            // Other service charges
            { FuelCodeCategoryType.OtherServiceCharges, 999}

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="InvoiceDetailType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<InvoiceDetailType, int> InvoiceDetailTypeToIntMapper { get; } = new Dictionary<InvoiceDetailType, int>()
        {
            { InvoiceDetailType.ThirdPartySalesClearance, 1 },
            { InvoiceDetailType.FeeFromThirdPartySales, 2 }

        }.ToImmutableDictionary();


        /// <summary>
        /// Maps the <see cref="InvoiceType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<InvoiceType, string> InvoiceTypeToStringMapper { get; } = new Dictionary<InvoiceType, string>()
        {
            // Sales invoices
            { InvoiceType.SalesInvoice, "1.1" },
            { InvoiceType.SalesInvoiceForIntraCommunity, "1.2" },
            { InvoiceType.SalesInvoiceForThirdPartyCountries, "1.3" },
            { InvoiceType.SalesInvoiceForThirdParty, "1.4"},
            { InvoiceType.SalesInvoiceForThirdPartySalesAndClearance, "1.5" },
            { InvoiceType.SalesInvoiceForAdditionalCases, "1.6" },

            // Provision of service invoices
            { InvoiceType.ProvisionOfServicesInvoice, "2.1" },
            { InvoiceType.ProvisionOfServicesInvoiceForIntraCommunity, "2.2" },
            { InvoiceType.ProvisionOfServicesInvoiceForThirdCountries, "2.3" },
            { InvoiceType.ProvisionOfServicesInvoiceForAdditionalCases, "2.4" },

            // Deeds of ownership
            { InvoiceType.DeadOfOwnershipForNonObligatoryIssuer, "3.1" },
            { InvoiceType.DeadOfOwnershipWithDenialFromObligatoryIssuer, "3.2" },

            // Correlated debit invoice
            { InvoiceType.CorrelatedDebitInvoice, "5.1" },
            { InvoiceType.NonCorrelatedDebitInvoice, "5.2" },

            // Self delivery invoices
            { InvoiceType.SelfDeliveryReceipt, "6.1" },
            {InvoiceType.SelfUseReceipt, "6.2" },

            // Contract income invoice
            { InvoiceType.ContractIncome, "7.1" },

            // Special item (income) invoice
            { InvoiceType.RentIncome, "8.1" },
            { InvoiceType.ReceiptOfAccommodationTaxCollection, "8.2" },

            // Retail receipts invoices
            { InvoiceType.SalesReceipt, "11.1" },
            { InvoiceType.ProvisionOfServicesReceipt, "11.2"},
            { InvoiceType.SimplifiedInvoice, "11.3" },
            { InvoiceType.SalesDebitReceipt, "11.4" },
            { InvoiceType.SalesReceiptForThirdParty, "11.5" },

            // Obtaining retail receipts invoice
            { InvoiceType.ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic, "13.1" },
            { InvoiceType.RetailTransactionsSubmissionForDomesticAndNonDomestic, "13.2" },
            { InvoiceType.SharedCommonExpenses, "13.3" },
            { InvoiceType.Subscriptions, "13.4" },
            { InvoiceType.EntityReceiptAsSpecifiedByTheOriginator, "13.30" },
            { InvoiceType. SalesDebitReceiptForDomesticAndNonDomestic, "13.31" },

            // Exemption invoices of domestic / foreign countries
            { InvoiceType.SalesInvoiceForIntraCommunityAcquisitions, "14.1"},
            { InvoiceType.SalesInvoiceForThirdCountriesAcquisitions, "14.2"},
            { InvoiceType.ProvisionOfServicesInvoiceForIntraCommunityAcquisitions, "14.3"},
            { InvoiceType.ProvisionOfServicesInvoiceForThirdCountriesAcquisitions, "14.4"},
            { InvoiceType.EFKAAndInsuranceOrganizations, "14.5"},
            { InvoiceType.DebitInvoiceForDomesticAndNonDomestic, "14.31"},

            // Contract expense invoice
            { InvoiceType.ContractExpense, "15.1" },

            // Rent expense invoice
            { InvoiceType.RentExpense, "16.1" },

            // Entity records invoices
            { InvoiceType.Payroll, "17.1" },
            { InvoiceType.Deprecations, "17.2" },
            { InvoiceType.VariousIncomeArrangementsForAccountingBase, "17.3" } ,
            { InvoiceType.VariousIncomeArrangementsForTaxBase, "17.4" },
            { InvoiceType.VariousExpenseArrangementsForAccountingBase, "17.5" },
            { InvoiceType.VariousExpenseArrangementsForTaxBase, "17.6" }
        }.ToImmutableDictionary();



        /// <summary>
        /// Maps the <see cref="LineItemType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<LineItemType, int> LineItemTypeToIntMapper { get; } = new Dictionary<LineItemType, int>()
        {
            { LineItemType.EndLineWithVAT, 2 },
            { LineItemType.OtherTaxLineWithVAT, 3 },
            { LineItemType.Giftcard, 6 },
            { LineItemType.NegativeSignOfValues, 7 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MeasurementUnit"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<MeasurementUnit, string> MeasurementUnitToGreekStringMapper { get; } = new Dictionary<MeasurementUnit, string>()
        {
            { MeasurementUnit.Pieces, "ΤΕΜ" },
            { MeasurementUnit.Kilos, "" },
            { MeasurementUnit.Liters, "" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MeasurementUnit"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<MeasurementUnit, int> MeasurementUnitToIntMapper { get; } = new Dictionary<MeasurementUnit, int>()
        {
            { MeasurementUnit.Pieces, 1 },
            { MeasurementUnit.Kilos, 2 },
            { MeasurementUnit.Liters, 3 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MovePurpose"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<MovePurpose, int> MovePurposeToIntMapper { get; } = new Dictionary<MovePurpose, int>()
        {
            {MovePurpose.Sale, 1 },
            {MovePurpose.SaleforThirdPartyAccount, 2 },
            {MovePurpose.Sampling, 3 },
            {MovePurpose.Exhibition, 4 },
            {MovePurpose.Return, 5 },
            {MovePurpose.Storage, 6 },
            {MovePurpose.ProcessingAssembly, 7 },
            {MovePurpose.BetweenEntityFacilities, 8 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MovePurpose"/>s to their related greek <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<MovePurpose, string> MovePurposeToGreekStringMapper { get; } = new Dictionary<MovePurpose, string>()
        {
            {MovePurpose.Sale, "Προς Πώληση" },
            {MovePurpose.SaleforThirdPartyAccount, "" },
            {MovePurpose.Sampling, "" },
            {MovePurpose.Exhibition, "" },
            {MovePurpose.Return, "" },
            {MovePurpose.Storage, "" },
            {MovePurpose.ProcessingAssembly, "" },
            {MovePurpose.BetweenEntityFacilities, "" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="OtherTaxesPercentageCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<OtherTaxesPercentageCategory, int> OtherTaxesPercentageCategoryToIntMapper { get; } = new Dictionary<OtherTaxesPercentageCategory, int>()
        {
            // Fire insurance premiums
            { OtherTaxesPercentageCategory.FireInsurancePremiums20To15Percent, 1 },
            { OtherTaxesPercentageCategory.FireInsurancePremiums20To5Percent, 2 },

            // Life insurance premiums
            { OtherTaxesPercentageCategory.LifeInsurancePremiums4Percent, 3 },
            { OtherTaxesPercentageCategory.OtherInsurancePremiums15Percent, 4 },

            // Premium tax exemptions
            { OtherTaxesPercentageCategory.PremiumTaxExemptions0Percent, 5 },

            // Hotels 2 to 4 stars tax
            { OtherTaxesPercentageCategory.Hotel1To2Stars0Point50Euro, 6 },
            { OtherTaxesPercentageCategory.Hotel3Stars1Point50Euro, 7 },
            { OtherTaxesPercentageCategory.Hotel4Stars3Euro, 8 },
            { OtherTaxesPercentageCategory.Hotel4Stars4Euro, 9 },
            { OtherTaxesPercentageCategory.RoomsToLetFurnishedRoomsApartments0Point50Euro, 10 },

            // Excise tax on advertisements that are shown on television
            { OtherTaxesPercentageCategory.EFTV5Percent, 11 },

            // Luxury tax on the taxable person
            { OtherTaxesPercentageCategory.LuxuryOnTheTaxableValueForIntraCommunityAcquiredAndImportedFromThirdCountries10Percent, 12 },
            { OtherTaxesPercentageCategory.LuxuryOnTheSalePriceBeforeVATForDomesticallyProducedItems10Percent, 13 },

            // State's right to casinos tickets
            { OtherTaxesPercentageCategory.PublicRightToCasinoTickets80Percent, 14 },

            // Fire insurance premiums
            { OtherTaxesPercentageCategory.FireInsurancePremiums20Percent, 15 },

            // Other taxes
            { OtherTaxesPercentageCategory.OtherCustomsDutiesTaxes, 16 },
            { OtherTaxesPercentageCategory.OtherTaxes, 17 },
            { OtherTaxesPercentageCategory.ChargesOfOtherTaxes, 18 },

            // SCT (Special Consumption Tax)
            { OtherTaxesPercentageCategory.EFC, 19 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PaymentType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<PaymentType, int> PaymentTypeToIntMapper { get; } = new Dictionary<PaymentType, int>()
        {
            { PaymentType.BusinessHomePaymentAccount, 1 },
            { PaymentType.BusinessForeignPaymentAccount, 2 },
            { PaymentType.Cash, 3 },
            { PaymentType.Check, 4 },
            { PaymentType.OnCredit, 5 },
            { PaymentType.WebBanking, 6 },
            { PaymentType.POSOrEPOS, 7 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PaymentType"/>s to their related greek <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<PaymentType, string> PaymentTypeToGreekStringMapper { get; } = new Dictionary<PaymentType, string>()
        {
            { PaymentType.BusinessHomePaymentAccount, "" },
            { PaymentType.BusinessForeignPaymentAccount, "" },
            { PaymentType.Cash, "Τοίς Μετρητοίς" },
            { PaymentType.Check, "" },
            { PaymentType.OnCredit, "" },
            { PaymentType.WebBanking, "" },
            { PaymentType.POSOrEPOS, "" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="SpecialInvoiceCategoryType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<SpecialInvoiceCategoryType, int> SpecialInvoiceCategotyTypeToIntMapper { get; } = new Dictionary<SpecialInvoiceCategoryType, int>()
        {
            { SpecialInvoiceCategoryType.SubsidiesGrants, 1 },
            { SpecialInvoiceCategoryType.HotelRetailRevenueChargesRoom, 2 },
            { SpecialInvoiceCategoryType.AccountingEntry, 3 },
            { SpecialInvoiceCategoryType.TaxFree, 4 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="StampDutyPercentageCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<StampDutyPercentageCategory, int> StampDutyPercentageCategoryToIntMapper { get; } = new Dictionary<StampDutyPercentageCategory, int>()
        {
            { StampDutyPercentageCategory.Rate1Point2, 1},
            { StampDutyPercentageCategory.Rate2Point4, 2},
            { StampDutyPercentageCategory.Rate3Point6, 3},
            { StampDutyPercentageCategory.OtherCasesOfStampDuty, 4}
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TaxType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<TaxType, int> TaxTypeToIntMapper { get; } = new Dictionary<TaxType, int>()
        {
            {TaxType.WithholdingTax, 1},
            {TaxType.Fees, 2},
            {TaxType.OtherTaxes, 3},
            {TaxType.Stamp, 4},
            {TaxType.Reservations, 5}
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TransmissionFailure"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<TransmissionFailure, string> TransmissionFailureToStringMapper { get; } = new Dictionary<TransmissionFailure, string>()
        {
            { TransmissionFailure.ProviderError, "providerError"},
            { TransmissionFailure.MyDataError, "myDataError" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="VATCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<VATCategory, int> VATCategoryToIntMapper { get; } = new Dictionary<VATCategory, int>()
        {
            { VATCategory.VATRate24, 1 },
            { VATCategory.VATRate13, 2 },
            { VATCategory.VATRate6, 3 },
            { VATCategory.VATRate17, 4 },
            { VATCategory.VATRate9, 5 },
            { VATCategory.VATRate4, 6 },
            { VATCategory.ExcludingVAT, 7 },
            { VATCategory.EntriesWithoutVAT, 8 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="VATExemptionCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<VATExemptionCategory, int> VATExemptionCategoryToIntMapper { get; } = new Dictionary<VATExemptionCategory, int>()
        {
            // Articles excluding VAT
            { VATExemptionCategory.Articles2And3, 1 },
            { VATExemptionCategory.Article5, 2 },
            { VATExemptionCategory.Article13, 3 },
            { VATExemptionCategory.Article14, 4 },
            { VATExemptionCategory.Article16, 5 },
            { VATExemptionCategory.Article19, 6 },
            { VATExemptionCategory.Article22, 7 },
            { VATExemptionCategory.Article24, 8 },
            { VATExemptionCategory.Article25, 9 },
            { VATExemptionCategory.Article26, 10 },
            { VATExemptionCategory.Article27, 11 },
            { VATExemptionCategory.Article27ForOpenSeaShips, 12 },
            { VATExemptionCategory.Article27Point1Gamma, 13 },
            { VATExemptionCategory.Article28, 14 },
            { VATExemptionCategory.Article39, 15 },
            { VATExemptionCategory.Article39A, 16 },
            { VATExemptionCategory.Article40, 17 },
            { VATExemptionCategory.Article41, 18 },
            { VATExemptionCategory.Article47, 19 },

            // Article including VAT
            { VATExemptionCategory.Article43IncludingVAT, 20 },
            { VATExemptionCategory.Article44IncludingVAT, 21 },
            { VATExemptionCategory.Article45IncludingVAT, 22 },
            { VATExemptionCategory.Article46IncludingVAT, 23 },

            // Article including VAT
            { VATExemptionCategory.Article6, 24 },

            // Policies excluding VAT
            { VATExemptionCategory.Policy1029_1995, 25 },
            { VATExemptionCategory.Policy1167_2015, 26 },

            // Other VAT exemptions
            { VATExemptionCategory.OtherVATExemptions, 27 },

            // Articles excluding VAT (OSS EU status)
            { VATExemptionCategory.Article24b1, 28 },
            { VATExemptionCategory.Article47b, 29 },
            { VATExemptionCategory.Article47c, 30 },
            { VATExemptionCategory.Article47d, 31 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="WithholdingTaxCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<WithholdingTaxCategory, int> WithholdingTaxCategoryToIntMapper { get; } = new Dictionary<WithholdingTaxCategory, int>()
        {
            // Withholding tax cases
            { WithholdingTaxCategory.CaseBTax15Percent, 1 },
            { WithholdingTaxCategory.CaseCRights20Percent, 2 },
            { WithholdingTaxCategory.CaseDManagementAdviceFees20Percent, 3 },
            { WithholdingTaxCategory.CaseDTechnicalWorks3Percent, 4 },

            // Liquid fuels and tobacco products
            { WithholdingTaxCategory.LiquidFuelsAndTobaccoProducts1Percent, 5 },

            // Other goods
            { WithholdingTaxCategory.OtherGoods4Percent, 6 },

            // Delivery service
            { WithholdingTaxCategory.Services8Percent, 7 },

            // Advanced payments
            { WithholdingTaxCategory.AdvancePayment4Percent, 8 },
            { WithholdingTaxCategory.AdvancePayment10Percent, 9 },
            { WithholdingTaxCategory.AdvancePayment15Percent, 10 },

            // Withholding tax percent
            { WithholdingTaxCategory.WithholdingTaxPercent, 11 },
            { WithholdingTaxCategory.WithholdingTax15Percent, 12 },
            { WithholdingTaxCategory.WithholdingTax10Percent, 13 },

            // Withholding special solidarity contribution
            { WithholdingTaxCategory.WithholdingSpecialSolidarityContribution, 14 },

            // Withholding termination of employment
            { WithholdingTaxCategory.WithholdingTerminationOfEmployment, 15 },

            // Withholding foreign transactions
            { WithholdingTaxCategory.WithholdingForeignTransaction, 16 },

            // Other withholding taxes
            { WithholdingTaxCategory.OtherWithholdingTaxes, 17 },

            // Withholding tax dividends
            { WithholdingTaxCategory.WitholdingTaxDividend, 18 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CountryCode"/> to their related <see cref="string"/>
        /// </summary>
        public static IReadOnlyDictionary<CountryCode, string> CountryCodeToStringMapper { get; } = new Dictionary<CountryCode, string>()
        {
            { CountryCode.AD, "andorra" },
            { CountryCode.AE, "uae" },
            { CountryCode.AF, "afghanistan" },
            { CountryCode.AG, "antigua_and_barbuda" },
            { CountryCode.AI, "anguilla" },
            { CountryCode.AL, "albanian" },
            { CountryCode.AM, "armenian" },
            { CountryCode.AN, "netherlands_antilles" },
            { CountryCode.AO, "angola" },
            { CountryCode.AQ, "antartica" },
            { CountryCode.AR, "argentinian" },
            { CountryCode.AS, "american_samoa" },
            { CountryCode.AT, "austrian" },
            { CountryCode.AU, "australian" },
            { CountryCode.AW, "aruba" },
            { CountryCode.AX, "aland_islands" },
            { CountryCode.AZ, "azerbaijani" },
            { CountryCode.BA, "bosnia_herzegovina" },
            { CountryCode.BB, "barbados" },
            { CountryCode.BD, "bangladesh" },
            { CountryCode.BE, "belgian" },
            { CountryCode.BF, "burkina_faso" },
            { CountryCode.BG, "bulgarian" },
            { CountryCode.BH, "bahrain" },
            { CountryCode.BI, "burundi" },
            { CountryCode.BJ, "benin" },
            { CountryCode.BL, "saint_barthelemy" },
            { CountryCode.BM, "bermuda" },
            { CountryCode.BN, "brunei" },
            { CountryCode.BO, "bolivia" },
            { CountryCode.BR, "brazil" },
            { CountryCode.BS, "bahamas" },
            { CountryCode.BT, "bhutan" },
            { CountryCode.BV, "bouvet_island" },
            { CountryCode.BW, "botswana" },
            { CountryCode.BY, "belarus" },
            { CountryCode.BZ, "belize" },
            { CountryCode.CA, "canadian" },
            { CountryCode.CC, "cocos_islans" },
            { CountryCode.CD, "democratic_republic_of_congo" },
            { CountryCode.CF, "central_african_republic" },
            { CountryCode.CG, "republic_of_congo" },
            { CountryCode.CH, "switzerland" },
            { CountryCode.CI, "ivory_coast" },
            { CountryCode.CK, "cook_islands" },
            { CountryCode.CL, "chile" },
            { CountryCode.CM, "cameroon" },
            { CountryCode.CN, "china" },
            { CountryCode.CO, "colombia" },
            { CountryCode.CR, "costa_rica" },
            { CountryCode.CU, "cuba" },
            { CountryCode.CV, "cape_verde" },
            { CountryCode.CX, "christmas_island" },
            { CountryCode.CY, "cyprus" },
            { CountryCode.CZ, "czech_republic" },
            { CountryCode.DE, "germany" },
            { CountryCode.DJ, "djibouti" },
            { CountryCode.DK, "denmark" },
            { CountryCode.DM, "dominican" },
            { CountryCode.DM, "dominican_republic" },
            { CountryCode.DZ, "algeria" },
            { CountryCode.EC, "ecuador" },
            { CountryCode.EE, "estonia" },
            { CountryCode.EG, "egypt" },
            { CountryCode.EH, "western_sahara" },
            { CountryCode.ER, "eritrea" },
            { CountryCode.ES, "spain" },
            { CountryCode.ET, "ethiopia" },
            { CountryCode.FI, "finland" },
            { CountryCode.FJ, "fiji" },
            { CountryCode.FK, "falkland_islands" },
            { CountryCode.FR, "france" },
            { CountryCode.GA, "gabon" },
            { CountryCode.GB, "united_kingdon" },
            { CountryCode.GD, "grenada" },
            { CountryCode.GE, "georgia" },
            { CountryCode.GF, "french_guiana" },
            { CountryCode.GG, "guernsey" },
            { CountryCode.GH, "ghana" },
            { CountryCode.GI, "gibraltar" },
            { CountryCode.GL, "greenland" },
            { CountryCode.GM, "gambia" },
            { CountryCode.GN, "guinea" },
            { CountryCode.GP, "guadeloupe" },
            { CountryCode.GQ, "equatorial_guinea" },
            { CountryCode.GR, "greece" },
            { CountryCode.GS, "south_georgia_and_south_sandwich_islands" },
            { CountryCode.GT, "guatemala" },
            { CountryCode.GU, "guam" },
            { CountryCode.GW, "guinea_bissau" },
            { CountryCode.GY, "guaya" },
            { CountryCode.HK, "hong_kong" },
            { CountryCode.HM, "heard_island_and_mcdonald_islands" },
            { CountryCode.HN, "honduras" },
            { CountryCode.HR, "croatia" },
            { CountryCode.HT, "haiti" },
            { CountryCode.HU, "hungary" },
            { CountryCode.ID, "indonesia" },
            { CountryCode.IE, "ireland" },
            { CountryCode.IL, "israel" },
            { CountryCode.IM, "isle_of_man" },
            { CountryCode.IN, "india" },
            { CountryCode.IO, "british_indian_ocean_territory" },
            { CountryCode.IQ, "iraq" },
            { CountryCode.IR, "iran" },
            { CountryCode.IS, "iceland" },
            { CountryCode.IT, "italy" },
            { CountryCode.JE, "jersey" },
            { CountryCode.JM, "jamaica" },
            { CountryCode.JO, "jordan" },
            { CountryCode.JP, "japan" },
            { CountryCode.KE, "kenya" },
            { CountryCode.KG, "kyrgystan" },
            { CountryCode.KH, "cambodia" },
            { CountryCode.KI, "kiribati" },
            { CountryCode.KM, "comoros" },
            { CountryCode.KN, "saint_kitts_and_nevis" },
            { CountryCode.KP, "north_korea" },
            { CountryCode.KR, "south_korea" },
            { CountryCode.KW, "kuwait" },
            { CountryCode.KY, "cayman_islands" },
            { CountryCode.KZ, "kazakhstan" },
            { CountryCode.LA, "laos" },
            { CountryCode.LB, "lebanon" },
            { CountryCode.LC, "saint_lucia" },
            { CountryCode.LI, "lichtenstein" },
            { CountryCode.LK, "sri_lanka" },
            { CountryCode.LR, "liberia" },
            { CountryCode.LS, "lesotho" },
            { CountryCode.LT, "lithuania" },
            { CountryCode.LU, "luxemburg" },
            { CountryCode.LV, "latvia" },
            { CountryCode.LY, "libya" },
            { CountryCode.MA, "morocco" },
            { CountryCode.MC, "monaco" },
            { CountryCode.MD, "moldova" },
            { CountryCode.ME, "montenegro" },
            { CountryCode.MF, "saint_martin" },
            { CountryCode.MG, "madagascar" },
            { CountryCode.MH, "marshall_islands" },
            { CountryCode.MK, "macedonia" },
            { CountryCode.ML, "mali" },
            { CountryCode.MM, "myanmar" },
            { CountryCode.MN, "mongolia" },
            { CountryCode.MO, "macau" },
            { CountryCode.MP, "northern_mariana_islands" },
            { CountryCode.MQ, "martinique" },
            { CountryCode.MR, "mauritania" },
            { CountryCode.MS, "montserrat" },
            { CountryCode.MT, "malta" },
            { CountryCode.MU, "mauritius" },
            { CountryCode.MV, "maldives" },
            { CountryCode.MW, "malawi" },
            { CountryCode.MX, "mexico" },
            { CountryCode.MY, "malaysia" },
            { CountryCode.MZ, "mozambique" },
            { CountryCode.NA, "namimbia" },
            { CountryCode.NC, "new_caledonia" },
            { CountryCode.NE, "niger" },
            { CountryCode.NF, "norfolk_island" },
            { CountryCode.NG, "nigeria" },
            { CountryCode.NI, "nicaragua" },
            { CountryCode.NL, "netherlands" },
            { CountryCode.NO, "norway" },
            { CountryCode.NP, "nepal" },
            { CountryCode.NR, "nauru" },
            { CountryCode.NU, "niue" },
            { CountryCode.NZ, "new_zealand" },
            { CountryCode.OM, "oman" },
            { CountryCode.PA, "panama" },
            { CountryCode.PE, "peru" },
            { CountryCode.PF, "french_polynesia" },
            { CountryCode.PG, "papua_new_guinea" },
            { CountryCode.PH, "philippines" },
            { CountryCode.PK, "pakistan" },
            { CountryCode.PL, "poland" },
            { CountryCode.PM, "saint_pierre_and_miquelon" },
            { CountryCode.PN, "pitcairn" },
            { CountryCode.PR, "puerto_rico" },
            { CountryCode.PS, "palestine" },
            { CountryCode.PT, "portugal" },
            { CountryCode.PW, "palau" },
            { CountryCode.PY, "paraguay" },
            { CountryCode.QA, "qatar" },
            { CountryCode.RE, "reunion" },
            { CountryCode.RO, "romania" },
            { CountryCode.RS, "serbia" },
            { CountryCode.RU, "russia" },
            { CountryCode.RW, "rwanda" },
            { CountryCode.SA, "saudi_arabia" },
            { CountryCode.SB, "solomon_islands" },
            { CountryCode.SC, "seychelles" },
            { CountryCode.SD, "sudan" },
            { CountryCode.SE, "sweden" },
            { CountryCode.SG, "singapore" },
            { CountryCode.SH, "saint_helena" },
            { CountryCode.SI, "slovenia" },
            { CountryCode.SJ, "svalbard_and_jan_mayen" },
            { CountryCode.SK, "slovakia" },
            { CountryCode.SL, "sierra_leone" },
            { CountryCode.SM, "san_marino" },
            { CountryCode.SN, "senegal" },
            { CountryCode.SO, "somalia" },
            { CountryCode.SR, "suriname" },
            { CountryCode.ST, "sao_tome_and_principe" },
            { CountryCode.SV, "el_salvador" },
            { CountryCode.SY, "syria" },
            { CountryCode.SZ, "swaziland" },
            { CountryCode.TC, "turks_and_caicos_islands" },
            { CountryCode.TD, "chad" },
            { CountryCode.TF, "french_southern_territories" },
            { CountryCode.TG, "togo" },
            { CountryCode.TH, "thailand" },
            { CountryCode.TJ, "tajikistan" },
            { CountryCode.TK, "tokelau" },
            { CountryCode.TL, "east_timor" },
            { CountryCode.TM, "turkmenistan" },
            { CountryCode.TN, "tunisia" },
            { CountryCode.TO, "tonga" },
            { CountryCode.TR, "turkey" },
            { CountryCode.TT, "trinidad_and_tobago" },
            { CountryCode.TV, "tuvalu" },
            { CountryCode.TW, "taiwan" },
            { CountryCode.TZ, "tanzania" },
            { CountryCode.UG, "uganda" },
            { CountryCode.UM, "united_stated_minor_outlying_islands" },
            { CountryCode.US, "united_states" },
            { CountryCode.UY, "uruguay" },
            { CountryCode.UZ, "uzbekistan" },
            { CountryCode.VA, "vatican" },
            { CountryCode.VC, "saint_vincent_and_the_grenadines" },
            { CountryCode.VE, "venezuela" },
            { CountryCode.VG, "british_virgin_islands" },
            { CountryCode.VI, "us_virgin_islands" },
            { CountryCode.VN, "vietnam" },
            { CountryCode.VU, "vanuatu" },
            { CountryCode.WF, "wallis_and_futuna" },
            { CountryCode.WS, "samoa" },
            { CountryCode.YE, "yemen" },
            { CountryCode.YT, "mayotte" },
            { CountryCode.ZA, "south_africa" },
            { CountryCode.ZM, "zambia" },
            { CountryCode.ZW, "zimbabwe" },


        }.ToImmutableDictionary();
    }
}
