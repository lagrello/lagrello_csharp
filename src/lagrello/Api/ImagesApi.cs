/*
 * Lagrello API
 *
 * API specification for Lagrello, a simple to use authentication service
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@lagrello.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using lagrello.Client;
using lagrello.Model;

namespace lagrello.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IImagesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a generated QR code
        /// </summary>
        /// <remarks>
        /// This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ImagesTotp (string tenantName = default(string), string userId = default(string), string userSecret = default(string));

        /// <summary>
        /// Returns a generated QR code
        /// </summary>
        /// <remarks>
        /// This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ImagesTotpWithHttpInfo (string tenantName = default(string), string userId = default(string), string userSecret = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns a generated QR code
        /// </summary>
        /// <remarks>
        /// This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ImagesTotpAsync (string tenantName = default(string), string userId = default(string), string userSecret = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a generated QR code
        /// </summary>
        /// <remarks>
        /// This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </remarks>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ImagesTotpWithHttpInfoAsync (string tenantName = default(string), string userId = default(string), string userSecret = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImagesApi : IImagesApi
    {
        private lagrello.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImagesApi(String basePath)
        {
            this.Configuration = new lagrello.Client.Configuration { BasePath = basePath };

            ExceptionFactory = lagrello.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class
        /// </summary>
        /// <returns></returns>
        public ImagesApi()
        {
            this.Configuration = lagrello.Client.Configuration.Default;

            ExceptionFactory = lagrello.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImagesApi(lagrello.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = lagrello.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = lagrello.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public lagrello.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public lagrello.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns a generated QR code This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ImagesTotp (string tenantName = default(string), string userId = default(string), string userSecret = default(string))
        {
             ApiResponse<System.IO.Stream> localVarResponse = ImagesTotpWithHttpInfo(tenantName, userId, userSecret);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a generated QR code This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> ImagesTotpWithHttpInfo (string tenantName = default(string), string userId = default(string), string userSecret = default(string))
        {

            var localVarPath = "/v1/images/totp";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "image/png",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tenantName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tenantName", tenantName)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (userSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userSecret", userSecret)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImagesTotp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Returns a generated QR code This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ImagesTotpAsync (string tenantName = default(string), string userId = default(string), string userSecret = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<System.IO.Stream> localVarResponse = await ImagesTotpWithHttpInfoAsync(tenantName, userId, userSecret, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a generated QR code This endpoint does not do any lookups of any sort. It will just generate a QR code from the parameters supplied to it.
        /// </summary>
        /// <exception cref="lagrello.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantName">The company name you your users to see in their TOTP application (optional)</param>
        /// <param name="userId">The userId of the user you want to create the TOTP QR image for (optional)</param>
        /// <param name="userSecret">The TOTP secret for the specified user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ImagesTotpWithHttpInfoAsync (string tenantName = default(string), string userId = default(string), string userSecret = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/v1/images/totp";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "image/png",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tenantName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tenantName", tenantName)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (userSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userSecret", userSecret)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImagesTotp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

    }
}