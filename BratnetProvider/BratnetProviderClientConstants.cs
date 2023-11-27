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
            { InvoiceType.DeedOfOwnershipForNonObligatoryIssuer, "3.1" },
            { InvoiceType.DeedOfOwnershipWithDenialFromObligatoryIssuer, "3.2" },

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

        public static IReadOnlyCollection<IncomeClassificationCategoriesPerInvoceTypeInfo> IncomeClassificationCategoriesPerInvoiceTypes { get; } = new List<IncomeClassificationCategoriesPerInvoceTypeInfo>()
{
            // 1.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoice,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_001,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_563,
                        IncomeClassificationType.E3_564,
                        IncomeClassificationType.E3_565,
                        IncomeClassificationType.E3_566,
                        IncomeClassificationType.E3_567,
                        IncomeClassificationType.E3_568,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, new []
                    {
                        IncomeClassificationType.E3_596,
                        IncomeClassificationType.E3_597,
                    })
                }),

            // 1.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForIntraCommunity,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_005,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_005,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_005,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_003,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 1.3
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForThirdPartyCountries,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_006,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_006,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_006,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_7, new []
                    {
                        IncomeClassificationType.E3_881_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 1.4
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForThirdParty,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_7, new []
                    {
                        IncomeClassificationType.E3_881_001,
                        IncomeClassificationType.E3_881_003
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 1.5
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForThirdPartySalesAndClearance,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_007
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_001,
                        IncomeClassificationType.E3_880_003,
                        IncomeClassificationType.E3_880_004
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                }),
            
            // 1.6
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForAdditionalCases,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 2.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoice,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_563,
                        IncomeClassificationType.E3_564,
                        IncomeClassificationType.E3_565,
                        IncomeClassificationType.E3_566,
                        IncomeClassificationType.E3_567,
                        IncomeClassificationType.E3_568,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 2.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForIntraCommunity,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 2.3
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForThirdCountries,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_006,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 2.4
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForAdditionalCases,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 3.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.DeedOfOwnershipForNonObligatoryIssuer,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_007,
                    }),
                }),

            // 3.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.DeedOfOwnershipWithDenialFromObligatoryIssuer,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_001,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_563,
                        IncomeClassificationType.E3_564,
                        IncomeClassificationType.E3_565,
                        IncomeClassificationType.E3_566,
                        IncomeClassificationType.E3_567,
                        IncomeClassificationType.E3_568,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 5.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.CorrelatedDebitInvoice,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 5.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.NonCorrelatedDebitInvoice,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_001,
                        IncomeClassificationType.E3_880_003,
                        IncomeClassificationType.E3_880_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_563,
                        IncomeClassificationType.E3_564,
                        IncomeClassificationType.E3_565,
                        IncomeClassificationType.E3_566,
                        IncomeClassificationType.E3_567,
                        IncomeClassificationType.E3_568,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_7, new []
                    {
                        IncomeClassificationType.E3_881_001,
                        IncomeClassificationType.E3_881_003,
                        IncomeClassificationType.E3_881_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 6.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SelfDeliveryReceipt,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_6, new []
                    {
                        IncomeClassificationType.E3_595,
                    }),
                }),

            // 6.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SelfUseReceipt,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_6, new []
                    {
                        IncomeClassificationType.E3_595,
                    }),
                }),

            // 7.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ContractIncome,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_007,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_001,
                        IncomeClassificationType.E3_880_003,
                        IncomeClassificationType.E3_880_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 8.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.RentIncome,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 8.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ReceiptOfAccommodationTaxCollection,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_7, new []
                    {
                        IncomeClassificationType.E3_881_001,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 11.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesReceipt,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_004,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_004,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_003,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_002,
                        IncomeClassificationType.E3_880_003,
                        IncomeClassificationType.E3_880_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 11.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesReceipt,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 11.3
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SimplifiedInvoice,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_1, new []
                    {
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_004,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_2, new []
                    {
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_004,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_4, new []
                    {
                        IncomeClassificationType.E3_880_002,
                        IncomeClassificationType.E3_880_003,
                        IncomeClassificationType.E3_880_004,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_5, new []
                    {
                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 11.4
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesDebitReceipt,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_3, new []
                    {
                        IncomeClassificationType.E3_561_006
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_7, new []
                    {
                        IncomeClassificationType.E3_881_002,
                        IncomeClassificationType.E3_881_003,
                        IncomeClassificationType.E3_881_004
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 11.5
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesReceiptForThirdParty,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_7, new []
                    {
                        IncomeClassificationType.E3_881_002,
                        IncomeClassificationType.E3_881_003,
                        IncomeClassificationType.E3_881_004
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 13.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 13.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.RetailTransactionsSubmissionForDomesticAndNonDomestic,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 13.3
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SharedCommonExpenses,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 13.4
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.Subscriptions,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 13.30
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.EntityReceiptAsSpecifiedByTheOriginator,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 13.31
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesDebitReceiptForDomesticAndNonDomestic,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 14.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForIntraCommunityAcquisitions,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 14.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.SalesInvoiceForThirdCountriesAcquisitions,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 14.3
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForIntraCommunityAcquisitions,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 14.4
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForThirdCountriesAcquisitions,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 14.5
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.EFKAAndInsuranceOrganizations,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 14.30

            // 14.31
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.DebitInvoiceForDomesticAndNonDomestic,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 15.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.ContractExpense,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 16.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.RentExpense,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 17.1
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.Payroll,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 17.2
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.Deprecations,
                Array.Empty<IncomeClassificationTypesPerIncomeClassificationCategoryInfo>()),

            // 17.3
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.VariousIncomeArrangementsForAccountingBase,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_8, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_9, Array.Empty<IncomeClassificationType>()),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_10, new []
                    {
                        IncomeClassificationType.E3_561_001,
                        IncomeClassificationType.E3_561_002,
                        IncomeClassificationType.E3_561_003,
                        IncomeClassificationType.E3_561_004,
                        IncomeClassificationType.E3_561_005,
                        IncomeClassificationType.E3_561_006,
                        IncomeClassificationType.E3_561_007,

                        IncomeClassificationType.E3_562,
                        IncomeClassificationType.E3_563,
                        IncomeClassificationType.E3_595,
                        IncomeClassificationType.E3_596,
                        IncomeClassificationType.E3_597,

                        IncomeClassificationType.E3_880_001,
                        IncomeClassificationType.E3_880_002,
                        IncomeClassificationType.E3_880_003,
                        IncomeClassificationType.E3_880_004,

                        IncomeClassificationType.E3_881_001,
                        IncomeClassificationType.E3_881_002,
                        IncomeClassificationType.E3_881_003,
                        IncomeClassificationType.E3_881_004,

                        IncomeClassificationType.E3_564,
                        IncomeClassificationType.E3_565,
                        IncomeClassificationType.E3_566,
                        IncomeClassificationType.E3_567,
                        IncomeClassificationType.E3_568,
                        IncomeClassificationType.E3_570,
                    }),
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 17.4
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.VariousIncomeArrangementsForTaxBase,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 17.5
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.VariousExpenseArrangementsForAccountingBase,
                new[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),

            // 17.6
            new IncomeClassificationCategoriesPerInvoceTypeInfo(
                InvoiceType.VariousExpenseArrangementsForTaxBase,
                new IncomeClassificationTypesPerIncomeClassificationCategoryInfo[]
                {
                    new IncomeClassificationTypesPerIncomeClassificationCategoryInfo(IncomeClassificationCategory.Category1_95, Array.Empty<IncomeClassificationType>())
                }),
        }.ToImmutableArray();

        /// <summary>
        /// Contains all possible combinations of <see cref="ExpenseClassificationCategory"/> and <see cref="ExpenseClassificationType"/>
        /// </summary>
        public static IReadOnlyCollection<ExpenseClassificationCategoriesPerInvoiceTypeInfo> ExpenseClassificationCategoriesPerInvoiceType { get; } = new List<ExpenseClassificationCategoriesPerInvoiceTypeInfo>()
        {
            // 1.1 Sales invoice
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoice,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new []
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new []
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_883_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),
            // 1.3 Sales invoice for third party countries
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoiceForThirdPartyCountries,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 1.4 Sales invoice for third party
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoiceForThirdParty,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_883_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>())
                }),

            // 1.5 Sales invoice for third party sales and clearance
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoiceForThirdPartySalesAndClearance,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_009
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_009
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_009
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_9, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                }),

            // 1.6 Sales invoice for additional cases
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoiceForAdditionalCases,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 2.1 Provision of services invoice
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoice,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_003,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 2.2 Provision of services invoice for intra community
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForIntraCommunity,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 2.3 Provision of services invoice for third countries
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForThirdCountries,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 2.4 Provision of services invoice for additional cases
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForAdditionalCases,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 3.1 Deed of ownership for non obligatory issuer
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.DeedOfOwnershipForNonObligatoryIssuer,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new []
                    {
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new []
                    {
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_883_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>())
                }),

            // 3.2 Deed of ownership with denial from obligatory issuer
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.DeedOfOwnershipWithDenialFromObligatoryIssuer,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_016,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_883_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>())
                }),

            // 5.1 Correlated debit invoice
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.CorrelatedDebitInvoice,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),
            // 5.2 Non correlated debit invoice
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.NonCorrelatedDebitInvoice,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_001, 
                        ExpenseClassificationType.E3_102_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_016,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_883_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>())
                }),

            // 6.1 Self delivery receipt
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SelfDeliveryReceipt,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 6.2 Self use receipt
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SelfUseReceipt,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 7.1 Contract income
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ContractIncome,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_313_001
                    }),

                     new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_016
                    }),

                     new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                     {
                         ExpenseClassificationType.E3_585_001,
                         ExpenseClassificationType.E3_585_002,
                         ExpenseClassificationType.E3_585_004,
                         ExpenseClassificationType.E3_585_005,
                         ExpenseClassificationType.E3_585_006,
                         ExpenseClassificationType.E3_585_008,
                         ExpenseClassificationType.E3_585_009,
                         ExpenseClassificationType.E3_585_011,
                         ExpenseClassificationType.E3_585_012,
                         ExpenseClassificationType.E3_585_013,
                         ExpenseClassificationType.E3_585_015,
                         ExpenseClassificationType.E3_585_016,
                         ExpenseClassificationType.E3_586
                     }),

                     new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                     {
                         ExpenseClassificationType.E3_585_001,
                         ExpenseClassificationType.E3_585_002,
                         ExpenseClassificationType.E3_585_004,
                         ExpenseClassificationType.E3_585_005,
                         ExpenseClassificationType.E3_585_006,
                         ExpenseClassificationType.E3_585_008,
                         ExpenseClassificationType.E3_585_009,
                         ExpenseClassificationType.E3_585_011,
                         ExpenseClassificationType.E3_585_012,
                         ExpenseClassificationType.E3_585_013,
                         ExpenseClassificationType.E3_585_015,
                         ExpenseClassificationType.E3_585_016,
                         ExpenseClassificationType.E3_586
                     }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_883_001
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 8.1 Rent income
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.RentIncome,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_004,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                }),

            // 8.2 Receipt of accommodation tax collection
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ReceiptOfAccommodationTaxCollection,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_008
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                }),

            // 11.1 Sales receipt
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesReceipt,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 11.2 Provision of services receipt
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesReceipt,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

             // 11.3 Simplified invoice
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SimplifiedInvoice,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

             // 11.4 Sales debit receipt
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesDebitReceipt,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),
            
             // 11.5 Provision of services receipt
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesReceiptForThirdParty,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

             // 13.1 Expenses purchases and retail transactions for domestic and non domestic
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_002,
                        ExpenseClassificationType.E3_102_006
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_002,
                        ExpenseClassificationType.E3_302_002,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_002,
                        ExpenseClassificationType.E3_883_002
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 13.2 Retail transactions submission for domestic and non domestic
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.RetailTransactionsSubmissionForDomesticAndNonDomestic,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 13.3 Shared common expenses
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SharedCommonExpenses,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_016,
                    }),

                     new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_016,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 13.4 Subscriptions
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.Subscriptions,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_016,
                    }),

                     new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_016,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

             // 13.4 Entity receipt as specified by the originator
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.EntityReceiptAsSpecifiedByTheOriginator,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_016,
                    }),

                     new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_016,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 13.31 Sales debit receipt for domestic and non domestic 
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesDebitReceiptForDomesticAndNonDomestic,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_002,
                        ExpenseClassificationType.E3_102_006
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_002,
                        ExpenseClassificationType.E3_302_002
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_002,
                        ExpenseClassificationType.E3_883_002
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 14.1
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoiceForIntraCommunityAcquisitions,
                new []
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_004,
                        ExpenseClassificationType.E3_102_006,
                        ExpenseClassificationType.E3_313_003,
                        ExpenseClassificationType.E3_313_005
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_003,
                        ExpenseClassificationType.E3_202_005,
                        ExpenseClassificationType.E3_302_003,
                        ExpenseClassificationType.E3_302_005
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_883_003,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_883_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 14.2 
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.SalesInvoiceForThirdCountriesAcquisitions,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_005,
                        ExpenseClassificationType.E3_102_006,
                        ExpenseClassificationType.E3_313_004,
                        ExpenseClassificationType.E3_313_005,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_004,
                        ExpenseClassificationType.E3_202_005,
                        ExpenseClassificationType.E3_302_004,
                        ExpenseClassificationType.E3_302_005,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 14.3 Provision of services invoice for intra community acquisitions
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForIntraCommunityAcquisitions,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586,
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_883_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_883_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 14.3 Provision of services invoice for third countries acquisitions
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ProvisionOfServicesInvoiceForThirdCountriesAcquisitions,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586,
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 14.5 EFKA and insurance organizations
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.EFKAAndInsuranceOrganizations,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_007
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 14.30

            //14.31 Debit invoice for domestic and non domestic
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.DebitInvoiceForDomesticAndNonDomestic,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_004,
                        ExpenseClassificationType.E3_102_005,
                        ExpenseClassificationType.E3_102_006,
                        ExpenseClassificationType.E3_313_003,
                        ExpenseClassificationType.E3_313_004,
                        ExpenseClassificationType.E3_313_005,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_003,
                        ExpenseClassificationType.E3_202_004,
                        ExpenseClassificationType.E3_202_005,
                        ExpenseClassificationType.E3_302_003,
                        ExpenseClassificationType.E3_302_004,
                        ExpenseClassificationType.E3_302_005,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_4, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586,
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_003,
                        ExpenseClassificationType.E3_883_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_003,
                        ExpenseClassificationType.E3_883_004
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 15.1 Contract expense
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.ContractExpense,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_1, new[]
                    {
                        ExpenseClassificationType.E3_102_002,
                        ExpenseClassificationType.E3_102_006,
                        ExpenseClassificationType.E3_313_002,
                        ExpenseClassificationType.E3_313_005,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_2, new[]
                    {
                        ExpenseClassificationType.E3_202_002,
                        ExpenseClassificationType.E3_202_005,
                        ExpenseClassificationType.E3_202_002,
                        ExpenseClassificationType.E3_302_005,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_3, new[]
                    {
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_016
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_7, new[]
                    {
                        ExpenseClassificationType.E3_882_002,
                        ExpenseClassificationType.E3_883_002
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 16.1 Rent expense
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.RentExpense,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_5, new[]
                    {
                        ExpenseClassificationType.E3_585_014
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 17.1 Payroll
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.Payroll,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_6, new[]
                    {
                        ExpenseClassificationType.E3_581_001,
                        ExpenseClassificationType.E3_581_002,
                        ExpenseClassificationType.E3_581_003
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 17.2 Deprecations
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.Deprecations,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_6, new[]
                    {
                        ExpenseClassificationType.E3_587
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 17.3 Various expense arrangements for accounting base
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.VariousExpenseArrangementsForAccountingBase,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 17.4 Various income arrangements for tax base
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.VariousIncomeArrangementsForTaxBase,
                Array.Empty<ExpenseClassificationTypesPerExpenseClassificationCategoryInfo>()),

            // 17.5 Various income arrangements for accounting base
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.VariousIncomeArrangementsForAccountingBase,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_10, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_11, Array.Empty<ExpenseClassificationType>()),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_12, new[]
                    {
                        ExpenseClassificationType.E3_102_001,
                        ExpenseClassificationType.E3_102_002,
                        ExpenseClassificationType.E3_102_003,
                        ExpenseClassificationType.E3_102_004,
                        ExpenseClassificationType.E3_102_005,
                        ExpenseClassificationType.E3_202_001,
                        ExpenseClassificationType.E3_202_002,
                        ExpenseClassificationType.E3_202_003,
                        ExpenseClassificationType.E3_202_004,
                        ExpenseClassificationType.E3_202_005,
                        ExpenseClassificationType.E3_302_001,
                        ExpenseClassificationType.E3_302_002,
                        ExpenseClassificationType.E3_302_003,
                        ExpenseClassificationType.E3_302_004,
                        ExpenseClassificationType.E3_302_005,
                        ExpenseClassificationType.E3_313_001,
                        ExpenseClassificationType.E3_313_002,
                        ExpenseClassificationType.E3_313_003,
                        ExpenseClassificationType.E3_313_004,
                        ExpenseClassificationType.E3_313_005,
                        ExpenseClassificationType.E3_585_001,
                        ExpenseClassificationType.E3_585_002,
                        ExpenseClassificationType.E3_585_003,
                        ExpenseClassificationType.E3_585_004,
                        ExpenseClassificationType.E3_585_005,
                        ExpenseClassificationType.E3_585_006,
                        ExpenseClassificationType.E3_585_007,
                        ExpenseClassificationType.E3_585_008,
                        ExpenseClassificationType.E3_585_009,
                        ExpenseClassificationType.E3_585_010,
                        ExpenseClassificationType.E3_585_011,
                        ExpenseClassificationType.E3_585_012,
                        ExpenseClassificationType.E3_585_013,
                        ExpenseClassificationType.E3_585_014,
                        ExpenseClassificationType.E3_585_015,
                        ExpenseClassificationType.E3_585_016,
                        ExpenseClassificationType.E3_586,
                        ExpenseClassificationType.E3_587,
                        ExpenseClassificationType.E3_882_001,
                        ExpenseClassificationType.E3_882_002,
                        ExpenseClassificationType.E3_882_003,
                        ExpenseClassificationType.E3_882_004,
                        ExpenseClassificationType.E3_883_001,
                        ExpenseClassificationType.E3_883_002,
                        ExpenseClassificationType.E3_883_003,
                        ExpenseClassificationType.E3_883_004,
                        ExpenseClassificationType.E3_582,
                        ExpenseClassificationType.E3_583,
                        ExpenseClassificationType.E3_584,
                        ExpenseClassificationType.E3_588,
                        ExpenseClassificationType.E3_589,
                    }), 
                    
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_13, new[]
                    {
                        ExpenseClassificationType.E3_101,
                        ExpenseClassificationType.E3_201,
                        ExpenseClassificationType.E3_301,
                        ExpenseClassificationType.E3_207,
                        ExpenseClassificationType.E3_307,
                        ExpenseClassificationType.E3_312,
                    }),

                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),

            // 17.6 Various expense arrangements for tax base
            new ExpenseClassificationCategoriesPerInvoiceTypeInfo(
                InvoiceType.VariousExpenseArrangementsForTaxBase,
                new[]
                {
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_12, Array.Empty<ExpenseClassificationType>()),
                    new ExpenseClassificationTypesPerExpenseClassificationCategoryInfo(ExpenseClassificationCategory.Category2_95, Array.Empty<ExpenseClassificationType>()),
                }),
        }.ToImmutableArray();
    }
}