using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;

namespace BratnetProvider
{
    /// <summary>
    /// Request model used for sending invoices to the Bratnet provider
    /// </summary>
    public class InvoiceRequestModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Series"/> property 
        /// </summary>
        private string? mSeries;

        /// <summary>
        /// The member of the <see cref="mCorrelatedInvoices"/> property
        /// </summary>
        private IEnumerable<long>? mCorrelatedInvoices;

        /// <summary>
        /// The member of the <see cref="PaymentMethods"/> property
        /// </summary>
        private IEnumerable<PaymentMethodDetailDataModel>? mPaymentMethods;

        /// <summary>
        /// The member of the <see cref="Taxes"/> property
        /// </summary>
        private IEnumerable<TaxRequestModel>? mTaxDataModel;

        /// <summary>
        /// The member of the <see cref="InvoiceDetails"/> property
        /// </summary>
        private IEnumerable<InvoiceDetailRequestModel>? mInvoiceDetails;

        /// <summary>
        /// The member of the <see cref="IssuerVATNumber"/> property
        /// </summary>
        private string? mIssuerVATNumber;

        /// <summary>
        /// The member of the <see cref="IssuerAddress"/> property
        /// </summary>
        private AddressDataModel? mIssuerAddress;

        /// <summary>
        /// The member of the <see cref="CounterpartVATNumber"/> property
        /// </summary>
        private string? mCounterpartVATNumber;

        /// <summary>
        /// The member of the <see cref="CounterpartAddress"/> property
        /// </summary>
        private AddressDataModel? mCounterpartAddress;

        /// <summary>
        /// The property of <see cref="ExtrasDataModel"/> property
        /// </summary>
        private ExtrasDataModel? mExtras;

        #endregion

        #region Public Properties

        #region Issuer Properties

        /// <summary>
        /// The issuer name
        /// Max length = 150
        /// </summary>
        public string? IssuerName { get; set; }

        /// <summary>
        /// The issuer VAT number
        /// </summary>
        public string IssuerVATNumber 
        { 
            get => mIssuerVATNumber ?? string.Empty;

            set => mIssuerVATNumber = value;
        }

        /// <summary>
        /// The country information
        /// </summary>
        public CountryCode IssuerCountry { get; set; } = CountryCode.GR;

        /// <summary>
        /// The issuer branch
        /// </summary>
        public uint IssuerBranch { get; set; }

        /// <summary>
        /// The issuer address
        /// </summary>
        public AddressDataModel IssuerAddress
        {
            get => mIssuerAddress ??= new();

            set => mIssuerAddress = value;
        }

        #endregion

        #region Counterpart Properties

        /// <summary>
        /// The counterpart VAT number
        /// </summary>
        public string CounterpartVATNumber 
        {
            get => mCounterpartVATNumber ?? string.Empty;
            
            set => mCounterpartVATNumber = value;
        }

        /// <summary>
        /// The counterpart country information
        /// </summary>
        public CountryCode CounterpartCountry { get; set; } = CountryCode.GR;

        /// <summary>
        /// The counterpart branch
        /// </summary>
        public uint CounterpartBranch { get; set; }

        /// <summary>
        /// The counterpart address
        /// </summary>
        public AddressDataModel CounterpartAddress
        {
            get => mCounterpartAddress ??= new();

            set => mCounterpartAddress = value;
        }

        #endregion

        #region Invoice Header

        /// <summary>
        /// The invoice series number
        /// </summary>
        [AllowNull]
        public string Series
        {
            get => mSeries ?? string.Empty;

            set => mSeries = value;
        }

        /// <summary>
        /// The invoice increasing serial number
        /// </summary>
        public uint AA { get; set; }

        /// <summary>
        /// The invoice date of issue
        /// </summary>
        public DateOnly IssueDate { get; set; }

        /// <summary>
        /// The invoice type
        /// </summary>
        public InvoiceType InvoiceType { get; set; }

        /// <summary>
        /// The vat payment suspension indication
        /// </summary>
        public bool? VATPaymentSuspension { get; set; }

        /// <summary>
        /// The type of currency
        /// </summary>
        public CurrencyCode Currency { get; set; } = CurrencyCode.EUR;

        /// <summary>
        /// The exchange rate values0 - 50000
        /// Fraction digits 5
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The correlated invoice
        /// </summary>
        [AllowNull]
        public IEnumerable<long> CorrelatedInvoices
        {
            get => mCorrelatedInvoices ?? Enumerable.Empty<long>();

            set => mCorrelatedInvoices = value;
        }

        /// <summary>
        /// The self pricing indication
        /// </summary>
        public bool? SelfPricing { get; set; }

        /// <summary>
        /// The date of dispatched invoice
        /// </summary>
        public DateOnly? DispatchDate { get; set; }

        /// <summary>
        /// The time of dispatched invoice
        /// </summary>
        public TimeOnly? DispatchTime { get; set; }

        /// <summary>
        /// The vehicle license plate number
        /// </summary>
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// The move purpose index
        /// </summary>
        public MovePurpose? MovePurpose { get; set; }

        /// <summary>
        /// The fuel used index
        /// </summary>
        public FuelCodeCategoryType? FuelInvoice { get; set; }

        /// <summary>
        /// The speific invoice cetegory
        /// </summary>
        public SpecialInvoiceCategoryType? SpecialInvoiceCategory { get; set; }

        #endregion

        /// <summary>
        /// The payment methods
        /// </summary>
        public IEnumerable<PaymentMethodDetailDataModel> PaymentMethods
        {
            get => mPaymentMethods ?? Enumerable.Empty<PaymentMethodDetailDataModel>();

            set => mPaymentMethods = value;
        }

        /// <summary>
        /// The taxes totals
        /// </summary>
        public IEnumerable<TaxRequestModel> Taxes
        {
            get => mTaxDataModel ?? Enumerable.Empty<TaxRequestModel>();

            set => mTaxDataModel = value;
        }

        /// <summary>
        /// The invoice details
        /// </summary>
        public IEnumerable<InvoiceDetailRequestModel> InvoiceDetails
        {
            get => mInvoiceDetails ?? Enumerable.Empty<InvoiceDetailRequestModel>();

            set => mInvoiceDetails = value;
        }

        /// <summary>
        /// Extra information
        /// </summary>
        public ExtrasDataModel Extras 
        {
            get => mExtras ??= new();

            set => mExtras = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceRequestModel() : base()
        {
                
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="InvoiceDataModel"/> from the current <see cref="InvoiceRequestModel"/>
        /// </summary>
        /// <returns></returns>
        public InvoiceDataModel ToInvoiceDataModel()
        {
            var result = new InvoiceDataModel()
            {
                InvoiceHeader = new InvoiceHeaderDataModel()
                {
                    AA = AA,
                    CorrelatedInvoices = CorrelatedInvoices,
                    Currency = Currency,
                    DispatchDate = DispatchDate,
                    DispatchTime = DispatchTime,
                    ExchangeRate = ExchangeRate,
                    FuelInvoice = FuelInvoice,
                    InvoiceType = InvoiceType,
                    IssueDate = IssueDate,
                    MovePurpose = MovePurpose,
                    SelfPricing = SelfPricing,
                    Series = Series,
                    SpecialInvoiceCategory = SpecialInvoiceCategory,
                    VATPaymentSuspension = VATPaymentSuspension,
                    VehicleNumber = VehicleNumber,
                },
                Issuer = new IssuerDetailDataModel()
                {
                    Address = IssuerAddress,
                    Branch = IssuerBranch,
                    Country = IssuerCountry,
                    Name = IssuerName,
                    VATNumber = IssuerVATNumber,
                },
                Counterpart = new CounterpartDataModel()
                {
                    VATNumber = CounterpartVATNumber,
                    Country = CounterpartCountry,
                    Branch = CounterpartBranch,
                    Address = CounterpartAddress,
                },
                PaymentMethods = new PaymentMethodDetailsDataModel()
                {
                    PaymentMethods = PaymentMethods
                },
                Extras = Extras
            };
                       
            var taxes = new List<TaxDataModel>();

            var index = 0;

            foreach(var tax in Taxes)
            {
                index++;

                var d = tax.ToTaxDataModel();

                d.TaxId = index;

                taxes.Add(d);
            }

            result.TaxTotals = new TaxTotalsDataModel()
            {
                Taxes = taxes
            };

            var invoiceDetails = new List<InvoiceDetailDataModel>();

            index = 0;

            foreach (var invoiceDetail in InvoiceDetails)
            {
                index++;

                var d = invoiceDetail.ToInvoiceDetailDataModel();

                d.LineNumber = index;

                invoiceDetails.Add(d);
            }

            result.InvoiceDetails = invoiceDetails;

            var invoiceSummary = new InvoiceSummaryDataModel();

            foreach (var invoiceDetail in InvoiceDetails)
            {
                invoiceSummary.TotalNetAmount += invoiceDetail.NetAmount;
                invoiceSummary.TotalVATAmount += invoiceDetail.VATAmount;
                invoiceSummary.TotalStampDutyAmount += invoiceDetail.StamDutyAmount ?? 0;
                invoiceSummary.TotalDeductionsAmount += invoiceDetail.DeductionsAmount ?? 0;
                invoiceSummary.TotalOtherTaxesAmount += invoiceDetail.OtherTaxesAmount ?? 0;
                invoiceSummary.TotalWithheldAmount += invoiceDetail.WithheldAmmount ?? 0;
                invoiceSummary.TotalFeesAmount += invoiceDetail.FeesAmount ?? 0;
            }

            var totalTaxesAmount = 0m;

            foreach (var tax in taxes)
                totalTaxesAmount += tax.TaxAmount;

            invoiceSummary.TotalDeductionsAmount += totalTaxesAmount;

            invoiceSummary.TotalGrossAmount = invoiceSummary.TotalNetAmount + invoiceSummary.TotalVATAmount - invoiceSummary.TotalWithheldAmount - invoiceSummary.TotalDeductionsAmount;

            invoiceSummary.IncomeClassifications = InvoiceDetails
                .GroupBy(x => new { x.IncomeClassificationType, x.IncomeClassificationCategory })
                .Select(x => new IncomeClassificationDataModel() { Amount = x.Sum(y => y.IncomeClassificationAmount), IncomeClassificationType = x.Key.IncomeClassificationType, IncomeClassificationCategory = x.Key.IncomeClassificationCategory })
                .ToList();

            invoiceSummary.ExpenseClassifications = InvoiceDetails
                .Where(x => x.ExpenseClassificationType is not null && x.ExpenseClassificationCategory is not null)
                .GroupBy(x => new { ExpenseClassificationType = x.ExpenseClassificationType!.Value, ExpenseClassificationCategory = x.ExpenseClassificationCategory!.Value })
                .Select(x => new ExpenseClassificationDataModel() { Amount = x.Sum(y => y.ExpenseClassificationAmount ?? 0), ExpenseClassificationType = x.Key.ExpenseClassificationType, ExpenseClassificationCategory = x.Key.ExpenseClassificationCategory })
                .ToList();

            result.InvoiceSummary = invoiceSummary;

            return result;
        }
        #endregion
    }
}