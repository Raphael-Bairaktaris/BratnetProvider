using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an extra data model
    /// </summary>
    public class ExtrasDataModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Remarks"/> property
        /// </summary>
        private string? mRemarks;

        /// <summary>
        /// The member of the <see cref="SalerName"/> property
        /// </summary>
        private string? mSalerName;

        /// <summary>
        /// The member of the <see cref="SalerCompanyName"/> property
        /// </summary>
        private string mSalerCompanyName;

        /// <summary>
        /// The member of the <see cref="SalerActivity"/> property
        /// </summary>
        private string? mSalerActivity;

        /// <summary>
        /// The member of the <see cref="SalerAddress"/> property
        /// </summary>
        private string? mSalerAddress;

        /// <summary>
        /// The member of the <see cref="SalerRegion"/> property
        /// </summary>
        private string? mSalerRegion;

        /// <summary>
        /// The member of the <see cref="SalerPostalCode"/> property
        /// </summary>
        private string? mSalerPostalCode;

        /// <summary>
        /// The memberof the <see cref="SalerCity"/> property
        /// </summary>
        private string? mSalerCity;

        /// <summary>
        /// The member of the <see cref="SalerEmail"/> property
        /// </summary>
        private string? mSalerEmail;

        /// <summary>
        /// The member of the <see cref="SalerGCR"/> property
        /// </summary>
        private string? mSalerGCR;

        /// <summary>
        /// The member of the <see cref="SalerVAT"/> property
        /// </summary>
        private string? mSalerVAT;

        /// <summary>
        /// The member of the <see cref="SalerDoyName"/> property
        /// </summary>
        private string? mSalerDoyName;

        /// <summary>
        /// The member of the <see cref="SalerRepresentative"/> property
        /// </summary>
        private string? mSalerRepresentative;

        /// <summary>
        /// The member of the <see cref="SalerRepresentativeVAT"/> property
        /// </summary>
        private string? mSalerRepresentativeVAT;

        /// <summary>
        /// The member of the <see cref="CustomerName"/> property
        /// </summary>
        private string? mCustomerName;

        /// <summary>
        /// The meber of the <see cref="CustomerActivity"/> property
        /// </summary>
        private string? mCustomerActivity;

        /// <summary>
        /// The meber of the <see cref="CustomerVAT"/> property
        /// </summary>
        private string? mCustomerVAT;

        /// <summary>
        /// The meber of the <see cref="CustomerDoyName"/> property
        /// </summary>
        private string? mCustomerDoyName;

        /// <summary>
        /// The meber of the <see cref="CustomerAddress"/> property
        /// </summary>
        private string? mCustomerAddress;

        /// <summary>
        /// The meber of the <see cref="CustomerRegion"/> property
        /// </summary>
        private string? mCustomerRegion;

        /// <summary>
        /// The meber of the <see cref="CustomerPostalCode"/> property
        /// </summary>
        private string? mCustomerPostalCode;

        /// <summary>
        /// The meber of the <see cref="CustomerCity"/> property
        /// </summary>
        private string? mCustomerCity;

        /// <summary>
        /// The meber of the <see cref="CustomerEmail"/> property
        /// </summary>
        private string? mCustomerEmail;

        /// <summary>
        /// The member of the <see cref="ShipmentType"/> property
        /// </summary>
        private string? mShipmentType;

        /// <summary>
        /// The meber of the <see cref="LoadingAddress"/> property
        /// </summary>
        private string? mLoadingAddress;

        /// <summary>
        /// The member of the <see cref="DestinationName"/> property
        /// </summary>
        private string? mDestinationName;

        /// <summary>
        /// The meber of the <see cref="DestinationAddress"/> property
        /// </summary>
        private string? mDestinationAddress;

        /// <summary>
        /// The member of the <see cref="DestinationCity"/> property
        /// </summary>
        private string? mDestinationCity;

        /// <summary>
        /// The meber of the <see cref="DestinationZipCode"/> property
        /// </summary>
        private string? mDestinationZipCode;

        /// <summary>
        /// The member of the <see cref="VehicleNumber"/> property
        /// </summary>
        private string? mVehicleNumber;

        /// <summary>
        /// The member of the <see cref="HotelRoom"/> property
        /// </summary>
        private string? mHotelRoom;

        /// <summary>
        /// The member of the <see cref="AltCustomerName"/> property
        /// </summary>
        private string? mAltCustomerName;

        /// <summary>
        /// The member of the <see cref="NationalId"/> property
        /// </summary>
        private string? mNationalId;

        #endregion

        #region Public Property

        /// <summary>
        /// The remarks
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks 
        { 
            get => mRemarks ?? string.Empty;
            
            set => mRemarks = value;
        }

        /// <summary>
        /// Indicates the time
        /// </summary>
        [JsonProperty("time")]
        public TimeOnly Time { get; set; }

        /// <summary>
        /// Sends email
        /// </summary>
        [JsonProperty("sendEmail")]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// The saler's name
        /// </summary>
        [JsonProperty("salerName")]
        public string SalerName 
        { 
            get => mSalerName ?? string.Empty;

            set => mSalerName = value;
        }

        /// <summary>
        /// The saler company name
        /// </summary>
        [JsonProperty("salerCompanyName")]
        public string SalerCompanyName 
        { 
            get => mSalerCompanyName ?? string.Empty;

            set => mSalerCompanyName = value;
        }

        /// <summary>
        /// The saler's activity
        /// </summary>
        [JsonProperty("salerActivity")]
        public string SalerActivity 
        { 
            get => mSalerActivity ?? string.Empty;

            set => mSalerActivity = value;
        }

        /// <summary>
        /// The saler's street name
        /// </summary>
        [JsonProperty("salerStreetName")]
        public string SalerAddress 
        { 
            get => mSalerAddress ?? string.Empty;

            set => mSalerAddress = value;
        }

        /// <summary>
        /// The saler's additional street name
        /// </summary>
        [JsonProperty("salerAdditionalStreetName")]
        public string SalerRegion 
        { 
            get => mSalerRegion ?? string.Empty;
            
            set => mSalerRegion = value;
        }

        /// <summary>
        /// The saler's postal code
        /// </summary>
        [JsonProperty("salerTk")]
        public string SalerPostalCode 
        { 
            get => SalerPostalCode ?? string.Empty;

            set => mSalerPostalCode = value; 
        }

        /// <summary>
        /// The saler's city
        /// </summary>
        [JsonProperty("salerCity")]
        public string SalerCity 
        { 
            get => mSalerCity ?? string.Empty;

            set => mSalerCity = value; 
        }

        /// <summary>
        /// The saler's email
        /// </summary>
        [JsonProperty("salerEmail")]
        public string SalerEmail 
        { 
            get => mSalerEmail ?? string.Empty;

            set => mSalerEmail = value; 
        }

        /// <summary>
        /// The saler's website
        /// </summary>
        [JsonProperty("salerWebsite")]
        public Uri SalerWebsite { get; set; }

        /// <summary>
        /// The saler's GCR (General Commercial Registry)
        /// </summary>
        [JsonProperty("salerGemh")]
        public string SalerGCR 
        {
            get => mSalerGCR ?? string.Empty; 

            set => mSalerGCR = value;
        }

        /// <summary>
        /// The saler's VAT
        /// </summary>
        [JsonProperty("salerVat")]
        public string SalerVAT 
        { 
            get => mSalerVAT ?? string.Empty;

            set => mSalerVAT = value;
        }

        /// <summary>
        /// The saler's doy (Public Financial Service) code
        /// </summary>
        [JsonProperty("salerDoyCode")]
        public uint SalerDoyCode { get; set; }

        /// <summary>
        /// The saler's doy (Public Financial Service) name
        /// </summary>
        public string SalerDoyName 
        {
            get => mSalerDoyName ?? string.Empty;

            set => mSalerDoyName = value; 
        }

        /// <summary>
        /// The saler's representative
        /// </summary>
        [JsonProperty("salerRepresentative")]
        public string SalerRepresentative 
        { 
            get => mSalerRepresentative ?? string.Empty;
            
            set => mSalerRepresentative = value;
        }

        /// <summary>
        /// The saler's representative vat number
        /// </summary>
        [JsonProperty("salerRepresentativeVat")]
        public string SalerRepresentativeVAT 
        { 
            get => mSalerRepresentativeVAT ?? string.Empty;

            set => mSalerRepresentativeVAT = value;
        }

        /// <summary>
        /// The customer's code
        /// </summary>
        [JsonProperty("customerCode")]
        public int CustomerCode { get; set; }

        /// <summary>
        /// The customer's name
        /// </summary>
        [JsonProperty("customerName")]
        public string CustomerName 
        {
            get => mCustomerName ?? string.Empty; 

            set => mCustomerName = value;
        }

        /// <summary>
        /// The customer's activity
        /// </summary>
        [JsonProperty("customerActivity")]
        public string CustomerActivity 
        { 
            get => mCustomerActivity ?? string.Empty;

            set => mCustomerActivity = value; 
        }

        /// <summary>
        /// The customer's vat number
        /// </summary>
        [JsonProperty("customerVAT")]
        public string CustomerVAT 
        { 
            get => mCustomerVAT ?? string.Empty;

            set => mCustomerVAT = value;
        }

        /// <summary>
        /// The customer's doy code 
        /// </summary>
        [JsonProperty("customerDoyCode")]
        public int CustomerDoyCode { get; set; }

        /// <summary>
        /// The customer's doy name
        /// </summary>
        [JsonProperty("customerDoyName")]
        public string CustomerDoyName 
        { 
            get => mCustomerDoyName ?? string.Empty;

            set => mCustomerDoyName = value;
        }

        /// <summary>
        /// The customer's address
        /// </summary>
        [JsonProperty("customerStreetName")]
        public string CustomerAddress 
        { 
            get => mCustomerAddress ?? string.Empty;

            set => mCustomerAddress = value;
        }

        /// <summary>
        /// The customer's region
        /// </summary>
        [JsonProperty("customerAdditionalStreetName")]
        public string CustomerRegion 
        { 
            get => mCustomerRegion ?? string.Empty;

            set => mCustomerRegion = value;
        }

        /// <summary>
        /// The customer's postal code
        /// </summary>
        [JsonProperty("customerTk")]
        public string CustomerPostalCode 
        {
            get => mCustomerPostalCode ?? string.Empty;

            set => mCustomerPostalCode = value; 
        }

        /// <summary>
        /// The customer's city
        /// </summary>
        [JsonProperty("customerCity")]
        public string CustomerCity 
        { 
            get => mCustomerCity ?? string.Empty; 

            set => mCustomerCity = value;
        }

        /// <summary>
        /// The customer's email
        /// </summary>
        [JsonProperty("customerEmail")]
        public string CustomerEmail 
        { 
            get => mCustomerEmail ?? string.Empty;

            set => mCustomerEmail = value;
        }

        /// <summary>
        /// The shipment's type
        /// </summary>
        [JsonProperty("shipmentName")]
        public string ShipmentType 
        { 
            get => mShipmentType ?? string.Empty;

            set => mShipmentType = value; 
        }

        /// <summary>
        /// The loading address
        /// </summary>
        [JsonProperty("loadingAddress")]
        public string LoadingAddress 
        { 
            get => mLoadingAddress ?? string.Empty;

            set => mLoadingAddress = value;
        }

        /// <summary>
        /// The destination's name
        /// </summary>
        [JsonProperty("destinationName")]
        public string DestinationName 
        { 
            get => mDestinationName ?? string.Empty;

            set => mDestinationName = value; 
        }

        /// <summary>
        /// The destination address
        /// </summary>
        [JsonProperty("destinationAddress")]
        public string DestinationAddress
        {
            get => mDestinationAddress ?? string.Empty;

            set => mDestinationAddress = value;
        }

        /// <summary>
        /// The destination city
        /// </summary>
        [JsonProperty("destinationCity")]
        public string DestinationCity
        {
            get => mDestinationCity ?? string.Empty;

            set => mDestinationCity = value;
        }

        /// <summary>
        /// The destination zip code
        /// </summary>
        [JsonProperty("destinationZipCode")]
        public string DestinationZipCode
        {
            get => mDestinationZipCode ?? string.Empty;

            set => mDestinationZipCode = value;
        }

        /// <summary>
        /// The correlated invoice
        /// </summary>
        public long? CorrelatedInvoice { get; set; }

        /// <summary>
        /// The payment method
        /// </summary>
        [JsonProperty("paymentMethodName")]
        public PaymentType? PaymentMethod { get; set; }

        /// <summary>
        /// The move purpose
        /// </summary>
        [JsonProperty("movePurpose")]
        public MovePurpose? MovePurpose { get; set; }

        /// <summary>
        /// The vehicle number
        /// </summary>
        [JsonProperty("vehicleNumber")]
        public string VehicleNumber 
        { 
            get => mVehicleNumber ?? string.Empty;

            set => mVehicleNumber = value;
        }

        /// <summary>
        /// The hotel start date
        /// </summary>
        [JsonProperty("hotelStartDate")]
        public DateOnly HotelStartDate { get; set; }

        /// <summary>
        /// The hotel end date
        /// </summary>
        [JsonProperty("hotelEndDate")]
        public DateOnly HotelEndDate { get; set; }

        /// <summary>
        /// The hotel room
        /// </summary>
        [JsonProperty("hotelRoom")]
        public string HotelRoom
        { 
            get => mHotelRoom ?? string.Empty;

            set => mHotelRoom = value;
        }

        /// <summary>
        /// The alternative customer name
        /// </summary>
        [JsonProperty("altCustname")]
        public string AltCustomerName
        {
            get => mAltCustomerName ?? string.Empty;

            set => mAltCustomerName = value;
        }

        /// <summary>
        /// The unique national id
        /// </summary>
        [JsonProperty("nationalId")]
        public string NationalId
        {
            get => mNationalId ?? string.Empty;

            set => mNationalId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExtrasDataModel()
        {
            
        }

        #endregion
    }
}
