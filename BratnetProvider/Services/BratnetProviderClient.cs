namespace BratnetProvider
{
    /// <summary>
    /// An agent that can make web requests to the Branet provider API
    /// </summary>
    public class BratnetProviderClient
    {
        #region Public Properties

        /// <summary>
        /// The API key
        /// </summary>
        public string APIKey { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiKey">The API key</param>
        public BratnetProviderClient(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException($"'{nameof(apiKey)}' cannot be null or empty.", nameof(apiKey));
            }

            APIKey = apiKey;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sends the specified <paramref name="model"/> to the Bratnet provider.
        /// </summary>
        /// <param name="model">The models.</param>
        /// <returns></returns>
        public Task<WebRequestResult<InvoicesDataModel>> SendInvoicesAsync(InvoicesDataModel model) 
            => WebRequestsClient.Instance.PostAsync<InvoicesDataModel>("http://www.bratnetprovider.com/invoices", model, APIKey);

        /// <summary>
        /// Sends the specified <paramref name="models"/> to the Bratnet provider.
        /// </summary>
        /// <param name="models">The models.</param>
        /// <returns></returns>
        public Task<WebRequestResult<InvoicesDataModel>> SendInvoicesAsync(IEnumerable<InvoiceRequestModel> models)
            => WebRequestsClient.Instance.PostAsync<InvoicesDataModel>("http://www.bratnetprovider.com/invoices", models, APIKey);

        /// <summary>
        /// Sends the specified <paramref name="model"/> to the Bratnet provider.
        /// </summary>
        /// <param name="model">The models.</param>
        /// <returns></returns>
        public Task<WebRequestResult<InvoicesDataModel>> SendInvoicesAsync(InvoiceRequestModel model)
            => SendInvoicesAsync(new List<InvoiceRequestModel> { model });

        #endregion
    }
}
