using System;

namespace BratnetProvider
{
    /// <summary>
    /// The helper methods for the MyData enums
    /// </summary>
    public static class MyDataEnumHelpers
    {
        #region Public Methods

        /// <summary>
        /// Returns the <see cref="InvoiceType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The invoice type</param>
        /// <returns></returns>
        public static InvoiceType ToInvoiceType(string value)
        {
            switch (value)
            {
                case "1.1": return InvoiceType.SalesInvoice;
                case "1.2": return InvoiceType.SalesInvoiceForIntraCommunity;
                case "1.3": return InvoiceType.SalesInvoiceForThirdPartyCountries;
                case "1.4": return InvoiceType.SalesInvoiceForThirdParty;
                case "1.5": return InvoiceType.SalesInvoiceForThirdPartySalesAndClearance;
                case "1.6": return InvoiceType.SalesInvoiceForAdditionalCases;

                case "2.1": return InvoiceType.ProvisionOfServicesInvoice;
                case "2.2": return InvoiceType.ProvisionOfServicesInvoiceForIntraCommunity;
                case "2.3": return InvoiceType.ProvisionOfServicesInvoiceForThirdCountries;
                case "2.4": return InvoiceType.ProvisionOfServicesInvoiceForAdditionalCases;

                case "3.1": return InvoiceType.DeadOfOwnershipForNonObligatoryIssuer;
                case "3.2": return InvoiceType.DeadOfOwnershipWithDenialFromObligatoryIssuer;

                case "5.1": return InvoiceType.CorrelatedDebitInvoice;
                case "5.2": return InvoiceType.NonCorrelatedDebitInvoice;

                case "6.1": return InvoiceType.SelfDeliveryReceipt;
                case "6.2": return InvoiceType.SelfUseReceipt;

                case "8.1": return InvoiceType.RentIncome;
                case "8.2": return InvoiceType.ReceiptOfAccommodationTaxCollection;

                case "11.1": return InvoiceType.SalesReceipt;
                case "11.2": return InvoiceType.ProvisionOfServicesReceipt;
                case "11.3": return InvoiceType.SimplifiedInvoice;
                case "11.4": return InvoiceType.SalesDebitReceipt;
                case "11.5": return InvoiceType.SalesReceiptForThirdParty;

                case "13.1": return InvoiceType.ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic;
                case "13.2": return InvoiceType.RetailTransactionsSubmissionForDomesticAndNonDomestic;
                case "13.3": return InvoiceType.SharedCommonExpenses;
                case "13.4": return InvoiceType.Subscriptions;
                case "13.30": return InvoiceType.EntityReceiptAsSpecifiedByTheOriginator;
                case "13.31": return InvoiceType.SalesDebitReceiptForDomesticAndNonDomestic;

                case "14.1": return InvoiceType.SalesInvoiceForIntraCommunityAcquisitions;
                case "14.2": return InvoiceType.SalesInvoiceForThirdCountriesAcquisitions;
                case "14.3": return InvoiceType.ProvisionOfServicesInvoiceForIntraCommunityAcquisitions;
                case "14.4": return InvoiceType.ProvisionOfServicesInvoiceForThirdCountriesAcquisitions;
                case "14.5": return InvoiceType.EFKAAndInsuranceOrganizations;
                case "14.30": return InvoiceType.EntityReceiptAsSpecifiedByTheOriginator;
                case "14.31": return InvoiceType.DebitInvoiceForDomesticAndNonDomestic;

                case "15.1": return InvoiceType.ContractExpense;

                case "16.1": return InvoiceType.RentExpense;

                case "17.1": return InvoiceType.Payroll;
                case "17.2": return InvoiceType.Deprecations;
                case "17.3": return InvoiceType.VariousIncomeArrangementsForAccountingBase;
                case "17.4": return InvoiceType.VariousIncomeArrangementsForTaxBase;
                case "17.5": return InvoiceType.VariousExpenseArrangementsForAccountingBase;
                case "17.6": return InvoiceType.VariousExpenseArrangementsForTaxBase;

                default: throw new InvalidOperationException($"The {value} is not a valid invoice type.");
            }
        }

        /// <summary>
        /// Returns the <see cref="MovePurpose"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The move purpose</param>
        /// <returns></returns>
        public static MovePurpose? ToMovePurpose(int? value)
        {
            switch (value)
            {
                case 1: return MovePurpose.Sale;
                case 2: return MovePurpose.SaleforThirdPartyAccount;
                case 3: return MovePurpose.Sampling;
                case 4: return MovePurpose.Exhibition;
                case 5: return MovePurpose.Return;
                case 6: return MovePurpose.Storage;
                case 7: return MovePurpose.ProcessingAssembly;
                case 8: return MovePurpose.BetweenEntityFacilities;
                default: return null;
            };
        }

        /// <summary>
        /// Returns the <see cref="PaymentType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The payment type</param>
        /// <returns></returns>
        public static PaymentType ToPaymentType(int value)
        {
            switch (value)
            {
                case 1: return PaymentType.BusinessHomePaymentAccount;
                case 2: return PaymentType.BusinessForeignPaymentAccount;
                case 3: return PaymentType.Cash;
                case 4: return PaymentType.Check;
                case 5: return PaymentType.OnCredit;
                case 6: return PaymentType.WebBanking;
                case 7: return PaymentType.POSOrEPOS;
                default: throw new InvalidOperationException($"The {value} is not a payment type.");
            }
        }

        /// <summary>
        /// Returns the <see cref="LineItemType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The line item type</param>
        /// <returns></returns>
        public static LineItemType? ToLineItemType(int? value)
        {
            switch (value)
            {
                case 2: return LineItemType.EndLineWithVAT;
                case 3: return LineItemType.OtherTaxLineWithVAT;
                case 6: return LineItemType.Giftcard;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="MeasurementUnit"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The measurement unit</param>
        /// <returns></returns>
        public static MeasurementUnit? ToMeasurementUnit(int? value)
        {
            switch (value)
            {
                case 1: return MeasurementUnit.Pieces;
                case 2: return MeasurementUnit.Kilos;
                case 3: return MeasurementUnit.Liters;
                default: return null;
            };
        }

        /// <summary>
        /// Returns the <see cref="InvoiceDetailType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The detail type</param>
        /// <returns></returns>
        public static InvoiceDetailType? ToDetailType(int? value)
        {
            switch (value)
            {
                case 1: return InvoiceDetailType.ThirdPartySalesClearance;
                case 2: return InvoiceDetailType.FeeFromThirdPartySales;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="VATCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The VAT category</param>
        /// <returns></returns>
        public static VATCategory ToVATCategory(int value)
        {
            switch (value)
            {
                case 1: return VATCategory.VATRate24;
                case 2: return VATCategory.VATRate13;
                case 3: return VATCategory.VATRate6;
                case 4: return VATCategory.VATRate17;
                case 5: return VATCategory.VATRate9;
                case 6: return VATCategory.VATRate4;
                case 7: return VATCategory.ExcludingVAT;
                case 8: return VATCategory.EntriesWithoutVAT;
                default: throw new InvalidOperationException($"The {value} is not a valid VAT category.");
            }
        }

        /// <summary>
        /// Returns the <see cref="VATCategory"/> that represents the specified rate.
        /// </summary>
        /// <param name="rate">
        /// The VAT rate.
        /// Ex.: 24, 13, 6, 0.
        /// </param>
        /// <returns></returns>
        public static VATCategory FromRate(decimal rate)
        {
            switch (rate)
            {
                case 24: return VATCategory.VATRate24;
                case 13: return VATCategory.VATRate13;
                case 6: return VATCategory.VATRate6;
                case 17: return VATCategory.VATRate17;
                case 9: return VATCategory.VATRate9;
                case 4: return VATCategory.VATRate4;
                case 0: return VATCategory.ExcludingVAT;
                default: return VATCategory.VATRate24;
            }
        }

        /// <summary>
        /// Returns the <see cref="VATExemptionCategory"/> that is associated with <paramref name="value"/> 
        /// NOTE: Based on VAT Code articles
        /// </summary>
        /// <param name="value">The VAT exemption</param>
        /// <returns></returns>
        public static VATExemptionCategory? ToVATExemptionType(int? value)
        {
            switch (value)
            {
                case 1: return VATExemptionCategory.Articles2And3;
                case 2: return VATExemptionCategory.Article5;
                case 3: return VATExemptionCategory.Article13;
                case 4: return VATExemptionCategory.Article14;
                case 5: return VATExemptionCategory.Article16;
                case 6: return VATExemptionCategory.Article19;
                case 7: return VATExemptionCategory.Article22;
                case 8: return VATExemptionCategory.Article24;
                case 9: return VATExemptionCategory.Article25;
                case 10: return VATExemptionCategory.Article26;
                case 11: return VATExemptionCategory.Article27;
                case 12: return VATExemptionCategory.Article27ForOpenSeaShips;
                case 13: return VATExemptionCategory.Article27Point1Gamma;
                case 14: return VATExemptionCategory.Article28;
                case 15: return VATExemptionCategory.Article39;
                case 16: return VATExemptionCategory.Article39A;
                case 17: return VATExemptionCategory.Article40;
                case 18: return VATExemptionCategory.Article41;
                case 19: return VATExemptionCategory.Article47;
                case 20: return VATExemptionCategory.Article43IncludingVAT;
                case 21: return VATExemptionCategory.Article44IncludingVAT;
                case 22: return VATExemptionCategory.Article45IncludingVAT;
                case 23: return VATExemptionCategory.Article46IncludingVAT;
                case 24: return VATExemptionCategory.Article6;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="TransmissionFailure"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The transmission failure</param>
        /// <returns></returns>
        public static TransmissionFailure? ToTransmissionFailure(byte? value)
        {
            switch (value)
            {
                case 1: return TransmissionFailure.ProviderError;
                case 2: return TransmissionFailure.MyDataError;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="WithholdingTaxCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The withheld percentage category</param>
        /// <returns></returns>
        public static WithholdingTaxCategory? ToWithheldPercentageCategory(int? value)
        {
            switch (value)
            {
                case 1: return WithholdingTaxCategory.CaseBTax15Percent;
                case 2: return WithholdingTaxCategory.CaseCRights20Percent;
                case 3: return WithholdingTaxCategory.CaseDManagementAdviceFees20Percent;
                case 4: return WithholdingTaxCategory.CaseDTechnicalWorks3Percent;
                case 5: return WithholdingTaxCategory.LiquidFuelsAndTobaccoProducts1Percent;
                case 6: return WithholdingTaxCategory.OtherGoods4Percent;
                case 7: return WithholdingTaxCategory.Services8Percent;
                case 8: return WithholdingTaxCategory.AdvancePayment4Percent;
                case 9: return WithholdingTaxCategory.AdvancePayment10Percent;
                case 10: return WithholdingTaxCategory.AdvancePayment15Percent;
                case 11: return WithholdingTaxCategory.WithholdingTaxPercent;
                case 12: return WithholdingTaxCategory.WithholdingTax15Percent;
                case 13: return WithholdingTaxCategory.WithholdingTax10Percent;
                case 14: return WithholdingTaxCategory.WithholdingSpecialSolidarityContribution;
                case 15: return WithholdingTaxCategory.WithholdingTerminationOfEmployment;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="StampDutyPercentageCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The stamp duty percentage category</param>
        /// <returns></returns>
        public static StampDutyPercentageCategory? ToStampDutyPercentageCategory(int? value)
        {
            switch (value)
            {
                case 1: return StampDutyPercentageCategory.Rate1Point2;
                case 2: return StampDutyPercentageCategory.Rate2Point4;
                case 3: return StampDutyPercentageCategory.Rate3Point6;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="TaxType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The tax type</param>
        /// <returns></returns>
        public static TaxType ToTaxType(byte value)
        {
            switch (value)
            {
                case 1: return TaxType.WithholdingTax;
                case 2: return TaxType.Fees;
                case 3: return TaxType.OtherTaxes;
                case 4: return TaxType.Stamp;
                case 5: return TaxType.Reservations;
                default: throw new InvalidOperationException($"The {value} is not a valid tax type.");
            }
        }

        /// <summary>
        /// Returns the <see cref="FeesPercentageCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The fees percentage category</param>
        /// <returns></returns>
        public static FeesPercentageCategory? ToFeesPercentageCategory(int? value)
        {
            switch (value)
            {
                case 1: return FeesPercentageCategory.MonthlyBill12Percent;
                case 2: return FeesPercentageCategory.MonthlyBill15Percent;
                case 3: return FeesPercentageCategory.MonthlyBill18Percent;
                case 4: return FeesPercentageCategory.MonthlyBill20Percent;
                case 5: return FeesPercentageCategory.MobileCalls12Percent;
                case 6: return FeesPercentageCategory.CableTV10Percent;
                case 7: return FeesPercentageCategory.Telephone5Percent;
                case 8: return FeesPercentageCategory.EnvironmentalFeePercentForPlasticBag;
                case 9: return FeesPercentageCategory.Homicide2Percent;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="OtherTaxesPercentageCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The other taxes percentage category</param>
        /// <returns></returns>
        public static OtherTaxesPercentageCategory? ToOtherTaxesPercentageCategory(int? value)
        {
            switch (value)
            {
                case 1: return OtherTaxesPercentageCategory.FireInsurancePremiums20To15Percent;
                case 2: return OtherTaxesPercentageCategory.FireInsurancePremiums20To5Percent;
                case 3: return OtherTaxesPercentageCategory.LifeInsurancePremiums4Percent;
                case 4: return OtherTaxesPercentageCategory.OtherInsurancePremiums15Percent;
                case 5: return OtherTaxesPercentageCategory.PremiumTaxExemptions0Percent;
                case 6: return OtherTaxesPercentageCategory.Hotel1To2Stars0Point50Euro;
                case 7: return OtherTaxesPercentageCategory.Hotel3Stars1Point50Euro;
                case 8: return OtherTaxesPercentageCategory.Hotel4Stars3Euro;
                case 9: return OtherTaxesPercentageCategory.Hotel4Stars4Euro;
                case 10: return OtherTaxesPercentageCategory.RoomsToLetFurnishedRoomsApartments0Point50Euro;
                case 11: return OtherTaxesPercentageCategory.EFTV5Percent;
                case 12: return OtherTaxesPercentageCategory.LuxuryOnTheTaxableValueForIntraCommunityAcquiredAndImportedFromThirdCountries10Percent;
                case 13: return OtherTaxesPercentageCategory.LuxuryOnTheSalePriceBeforeVATForDomesticallyProducedItems10Percent;
                case 14: return OtherTaxesPercentageCategory.PublicRightToCasinoTickets80Percent;
                default: return null;
            }
        }

        /// <summary>
        /// Returns the <see cref="IncomeClassificationType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The income classification type</param>
        /// <returns></returns>
        public static IncomeClassificationType ToIncomeClassificationType(string value)
        {
            switch (value)
            {
                case "E3_106": return IncomeClassificationType.E3_106;
                case "E3_205": return IncomeClassificationType.E3_205;
                case "E3_210": return IncomeClassificationType.E3_210;
                case "E3_305": return IncomeClassificationType.E3_305;
                case "E3_310": return IncomeClassificationType.E3_310;
                case "E3_318": return IncomeClassificationType.E3_318;
                case "E3_561_001": return IncomeClassificationType.E3_561_001;
                case "E3_561_002": return IncomeClassificationType.E3_561_002;
                case "E3_561_003": return IncomeClassificationType.E3_561_003;
                case "E3_561_004": return IncomeClassificationType.E3_561_004;
                case "E3_561_005": return IncomeClassificationType.E3_561_005;
                case "E3_561_006": return IncomeClassificationType.E3_561_006;
                case "E3_561_007": return IncomeClassificationType.E3_561_007;
                case "E3_562": return IncomeClassificationType.E3_562;
                case "E3_563": return IncomeClassificationType.E3_563;
                case "E3_564": return IncomeClassificationType.E3_564;
                case "E3_565": return IncomeClassificationType.E3_565;
                case "E3_566": return IncomeClassificationType.E3_566;
                case "E3_567": return IncomeClassificationType.E3_567;
                case "E3_568": return IncomeClassificationType.E3_568;
                case "E3_570": return IncomeClassificationType.E3_570;
                case "E3_595": return IncomeClassificationType.E3_595;
                case "E3_596": return IncomeClassificationType.E3_596;
                case "E3_597": return IncomeClassificationType.E3_597;
                case "E3_880_001": return IncomeClassificationType.E3_880_001;
                case "E3_880_002": return IncomeClassificationType.E3_880_002;
                case "E3_880_003": return IncomeClassificationType.E3_880_003;
                case "E3_880_004": return IncomeClassificationType.E3_880_004;
                case "E3_881_001": return IncomeClassificationType.E3_881_001;
                case "E3_881_002": return IncomeClassificationType.E3_881_002;
                case "E3_881_003": return IncomeClassificationType.E3_881_003;
                case "E3_881_004": return IncomeClassificationType.E3_881_004;
                default: throw new InvalidOperationException($"The {value} is not a income classification type.");
            }
        }

        /// <summary>
        /// Returns the <see cref="IncomeClassificationCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The income classification category</param>
        /// <returns></returns>
        public static IncomeClassificationCategory ToIncomeClassificationCategory(string value)
        {
            switch (value)
            {
                case "category1_1": return IncomeClassificationCategory.Category1_1;
                case "category1_2": return IncomeClassificationCategory.Category1_2;
                case "category1_3": return IncomeClassificationCategory.Category1_3;
                case "category1_4": return IncomeClassificationCategory.Category1_4;
                case "category1_5": return IncomeClassificationCategory.Category1_5;
                case "category1_6": return IncomeClassificationCategory.Category1_6;
                case "category1_7": return IncomeClassificationCategory.Category1_7;
                case "category1_8": return IncomeClassificationCategory.Category1_8;
                case "category1_9": return IncomeClassificationCategory.Category1_9;
                case "category1_10": return IncomeClassificationCategory.Category1_10;
                case "category1_95": return IncomeClassificationCategory.Category1_95;
                default: throw new InvalidOperationException($"The {value} is not a income classification category.");
            }
        }

        /// <summary>
        /// Returns the <see cref="ExpenseClassificationType"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The expenses classification type</param>
        /// <returns></returns>
        public static ExpenseClassificationType ToExpensesClassificationType(string value)
        {
            switch (value)
            {
                case "E3_101": return ExpenseClassificationType.E3_101;
                case "E3_102_001": return ExpenseClassificationType.E3_102_001;
                case "E3_102_002": return ExpenseClassificationType.E3_102_002;
                case "E3_102_003": return ExpenseClassificationType.E3_102_003;
                case "E3_102_004": return ExpenseClassificationType.E3_102_004;
                case "E3_102_005": return ExpenseClassificationType.E3_102_005;
                case "E3_102_006": return ExpenseClassificationType.E3_102_006;
                case "E3_104": return ExpenseClassificationType.E3_104;
                case "E3_201": return ExpenseClassificationType.E3_201;
                case "E3_202_001": return ExpenseClassificationType.E3_202_001;
                case "E3_202_002": return ExpenseClassificationType.E3_202_002;
                case "E3_202_003": return ExpenseClassificationType.E3_202_003;
                case "E3_202_004": return ExpenseClassificationType.E3_202_004;
                case "E3_202_005": return ExpenseClassificationType.E3_202_005;
                case "E3_204": return ExpenseClassificationType.E3_204;
                case "E3_207": return ExpenseClassificationType.E3_207;
                case "E3_209": return ExpenseClassificationType.E3_209;
                case "E3_301": return ExpenseClassificationType.E3_301;
                case "E3_302_001": return ExpenseClassificationType.E3_302_001;
                case "E3_302_002": return ExpenseClassificationType.E3_302_002;
                case "E3_302_003": return ExpenseClassificationType.E3_302_003;
                case "E3_302_004": return ExpenseClassificationType.E3_302_004;
                case "E3_302_005": return ExpenseClassificationType.E3_302_005;
                case "E3_304": return ExpenseClassificationType.E3_304;
                case "E3_307": return ExpenseClassificationType.E3_307;
                case "E3_309": return ExpenseClassificationType.E3_309;
                case "E3_312": return ExpenseClassificationType.E3_312;
                case "E3_313_001": return ExpenseClassificationType.E3_313_001;
                case "E3_313_002": return ExpenseClassificationType.E3_313_002;
                case "E3_313_003": return ExpenseClassificationType.E3_313_003;
                case "E3_313_004": return ExpenseClassificationType.E3_313_004;
                case "E3_313_005": return ExpenseClassificationType.E3_313_005;
                case "E3_315": return ExpenseClassificationType.E3_315;
                case "E3_581_001": return ExpenseClassificationType.E3_581_001;
                case "E3_581_002": return ExpenseClassificationType.E3_581_002;
                case "E3_581_003": return ExpenseClassificationType.E3_581_003;
                case "E3_582": return ExpenseClassificationType.E3_582;
                case "E3_583": return ExpenseClassificationType.E3_583;
                case "E3_584": return ExpenseClassificationType.E3_584;
                case "E3_585_001": return ExpenseClassificationType.E3_585_001;
                case "E3_585_002": return ExpenseClassificationType.E3_585_002;
                case "E3_585_003": return ExpenseClassificationType.E3_585_003;
                case "E3_585_004": return ExpenseClassificationType.E3_585_004;
                case "E3_585_005": return ExpenseClassificationType.E3_585_005;
                case "E3_585_006": return ExpenseClassificationType.E3_585_006;
                case "E3_585_007": return ExpenseClassificationType.E3_585_007;
                case "E3_585_008": return ExpenseClassificationType.E3_585_008;
                case "E3_585_009": return ExpenseClassificationType.E3_585_009;
                case "E3_585_010": return ExpenseClassificationType.E3_585_010;
                case "E3_585_011": return ExpenseClassificationType.E3_585_011;
                case "E3_585_012": return ExpenseClassificationType.E3_585_012;
                case "E3_585_013": return ExpenseClassificationType.E3_585_013;
                case "E3_585_014": return ExpenseClassificationType.E3_585_014;
                case "E3_585_015": return ExpenseClassificationType.E3_585_015;
                case "E3_585_016": return ExpenseClassificationType.E3_585_016;
                case "E3_586": return ExpenseClassificationType.E3_586;
                case "E3_587": return ExpenseClassificationType.E3_587;
                case "E3_588": return ExpenseClassificationType.E3_588;
                case "E3_589": return ExpenseClassificationType.E3_589;
                case "E3_882_001": return ExpenseClassificationType.E3_882_001;
                case "E3_882_002": return ExpenseClassificationType.E3_882_002;
                case "E3_882_003": return ExpenseClassificationType.E3_882_003;
                case "E3_882_004": return ExpenseClassificationType.E3_882_004;
                case "E3_883_001": return ExpenseClassificationType.E3_883_001;
                case "E3_883_002": return ExpenseClassificationType.E3_883_002;
                case "E3_883_003": return ExpenseClassificationType.E3_883_003;
                case "E3_883_004": return ExpenseClassificationType.E3_883_004;
                case "VAT_361": return ExpenseClassificationType.VAT_361;
                case "VAT_362": return ExpenseClassificationType.VAT_362;
                case "VAT_363": return ExpenseClassificationType.VAT_363;
                case "VAT_364": return ExpenseClassificationType.VAT_364;
                case "VAT_365": return ExpenseClassificationType.VAT_365;
                case "VAT_366": return ExpenseClassificationType.VAT_366;
                default: throw new InvalidOperationException($"The {value} is not a income classification type.");
            }
        }

        /// <summary>
        /// Returns the <see cref="ExpenseClassificationCategory"/> that is associated with <paramref name="value"/> 
        /// </summary>
        /// <param name="value">The expenses classification category</param>
        /// <returns></returns>
        public static ExpenseClassificationCategory ToExpensesClassificationCategory(string value)
        {
            switch (value)
            {
                case "category2_1": return ExpenseClassificationCategory.Category2_1;
                case "category2_2": return ExpenseClassificationCategory.Category2_2;
                case "category2_3": return ExpenseClassificationCategory.Category2_3;
                case "category2_4": return ExpenseClassificationCategory.Category2_4;
                case "category2_5": return ExpenseClassificationCategory.Category2_5;
                case "category2_6": return ExpenseClassificationCategory.Category2_6;
                case "category2_7": return ExpenseClassificationCategory.Category2_7;
                case "category2_8": return ExpenseClassificationCategory.Category2_8;
                case "category2_9": return ExpenseClassificationCategory.Category2_9;
                case "category2_10": return ExpenseClassificationCategory.Category2_10;
                case "category2_11": return ExpenseClassificationCategory.Category2_11;
                case "category2_12": return ExpenseClassificationCategory.Category2_12;
                case "category2_13": return ExpenseClassificationCategory.Category2_13;
                case "category2_14": return ExpenseClassificationCategory.Category2_14;
                case "category2_95": return ExpenseClassificationCategory.Category2_95;
                default: throw new InvalidOperationException($"The {value} is not a income classification category.");
            }
        }

        #endregion
    }
}