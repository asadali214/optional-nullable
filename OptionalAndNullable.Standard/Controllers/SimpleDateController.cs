// <copyright file="SimpleDateController.cs" company="APIMatic">
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
    /// SimpleDateController.
    /// </summary>
    public class SimpleDateController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDateController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal SimpleDateController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// sendSimpleDate EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse CreateSendSimpleDate(
                bool unSet,
                bool setToNull,
                string field,
                Models.SimpleDate date)
        {
            Task<Models.ServerResponse> t = this.CreateSendSimpleDateAsync(unSet, setToNull, field, date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// sendSimpleDate EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> CreateSendSimpleDateAsync(
                bool unSet,
                bool setToNull,
                string field,
                Models.SimpleDate date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/optionalNullable/sendSimpleDate");

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
        /// sendSimpleDateArray EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse CreateSendSimpleDateArray(
                bool unSet,
                bool setToNull,
                string field,
                Models.SimpleDateArray date)
        {
            Task<Models.ServerResponse> t = this.CreateSendSimpleDateArrayAsync(unSet, setToNull, field, date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// sendSimpleDateArray EndPoint.
        /// </summary>
        /// <param name="unSet">Required parameter: Example: .</param>
        /// <param name="setToNull">Required parameter: Example: .</param>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> CreateSendSimpleDateArrayAsync(
                bool unSet,
                bool setToNull,
                string field,
                Models.SimpleDateArray date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/optionalNullable/sendSimpleDateArray");

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