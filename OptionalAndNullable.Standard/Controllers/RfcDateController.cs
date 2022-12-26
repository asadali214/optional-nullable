// <copyright file="RfcDateController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace OptionalAndNullable.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using OptionalAndNullable.Standard;
    using OptionalAndNullable.Standard.Authentication;
    using OptionalAndNullable.Standard.Http.Client;
    using OptionalAndNullable.Standard.Http.Request;
    using OptionalAndNullable.Standard.Http.Request.Configuration;
    using OptionalAndNullable.Standard.Http.Response;
    using OptionalAndNullable.Standard.Utilities;

    /// <summary>
    /// RfcDateController.
    /// </summary>
    public class RfcDateController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RfcDateController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal RfcDateController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// sendRfc1123Date EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse CreateSendRfc1123Date(
                bool unSet,
                bool setToNull,
                string field,
                Models.Rfc1123Date date)
        {
            Task<Models.ServerResponse> t = this.CreateSendRfc1123DateAsync(unSet, setToNull, field, date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// sendRfc1123Date EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> CreateSendRfc1123DateAsync(
                bool unSet,
                bool setToNull,
                string field,
                Models.Rfc1123Date date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/optionalNullable/sendRfc1123Date");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "unSet", unSet },
                { "setToNull", setToNull },
                { "field", field },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(date);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// sendRfc1123DateArray EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse CreateSendRfc1123DateArray(
                bool unSet,
                bool setToNull,
                string field,
                Models.Rfc1123DateArray date)
        {
            Task<Models.ServerResponse> t = this.CreateSendRfc1123DateArrayAsync(unSet, setToNull, field, date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// sendRfc1123DateArray EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> CreateSendRfc1123DateArrayAsync(
                bool unSet,
                bool setToNull,
                string field,
                Models.Rfc1123DateArray date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/optionalNullable/sendRfc1123DateArray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "unSet", unSet },
                { "setToNull", setToNull },
                { "field", field },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(date);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// sendRfc1123DateMap EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse CreateSendRfc1123DateMap(
                bool unSet,
                bool setToNull,
                string field,
                Models.Rfc1123DateMap date)
        {
            Task<Models.ServerResponse> t = this.CreateSendRfc1123DateMapAsync(unSet, setToNull, field, date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// sendRfc1123DateMap EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> CreateSendRfc1123DateMapAsync(
                bool unSet,
                bool setToNull,
                string field,
                Models.Rfc1123DateMap date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/optionalNullable/sendRfc1123DateMap");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "unSet", unSet },
                { "setToNull", setToNull },
                { "field", field },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(date);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }
    }
}