using System.Diagnostics.CodeAnalysis;

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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceRequestModel()
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
            };

            return result;
        }

        #endregion
    }
}