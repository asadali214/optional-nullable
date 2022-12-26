// <copyright file="RfcDateControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace OptionalAndNullable.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using OptionalAndNullable.Standard;
    using OptionalAndNullable.Standard.Controllers;
    using OptionalAndNullable.Standard.Exceptions;
    using OptionalAndNullable.Standard.Http.Client;
    using OptionalAndNullable.Standard.Http.Response;
    using OptionalAndNullable.Standard.Utilities;
    using OptionalAndNullable.Tests.Helpers;

    /// <summary>
    /// RfcDateControllerTest.
    /// </summary>
    [TestFixture]
    public class RfcDateControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private RfcDateController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.RfcDateController;
        }

        /// <summary>
        /// TestUnsetRfc1123DateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetRfc1123DateTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123Date date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123Date>("{\"dateTime1\":\"Wed, 20 Jan 2021 12:12:41 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetRfc1123DateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetRfc1123DateTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123Date date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123Date>("{\"dateTime\":\"Wed, 20 Jan 2021 12:12:41 GMT\",\"dateTime1\":\"Wed, 20 Jan 2021 12:12:41 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullRfc1123DateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullRfc1123DateTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123Date date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123Date>("{\"dateTime\":null,\"dateTime1\":\"Wed, 20 Jan 2021 12:12:41 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetRfc1123DateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetRfc1123DateArrayTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123DateArray date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123DateArray>("{\"dateTime1\":[\"Wed, 20 Jan 2021 12:12:41 GMT\",\"Wed, 20 Jan 2021 12:12:41 GMT\"]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetRfc1123DateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetRfc1123DateArrayTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123DateArray date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123DateArray>("{\"dateTime\":[\"Wed, 20 Jan 2021 12:12:41 GMT\",\"Wed, 20 Jan 2021 12:12:41 GMT\"],\"dateTime1\":[\"Wed, 20 Jan 2021 12:12:41 GMT\",\"Wed, 20 Jan 2021 12:12:41 GMT\"]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullRfc1123DateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullRfc1123DateArrayTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123DateArray date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123DateArray>("{\"dateTime\":null,\"dateTime1\":[\"Wed, 20 Jan 2021 12:12:41 GMT\",\"Wed, 20 Jan 2021 12:12:41 GMT\"]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetRfc1123DateMapTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetRfc1123DateMapTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123DateMap date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123DateMap>("{\"dateTime1\":{\"key\":\"Wed, 20 Jan 2021 12:26:13 GMT\"}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateMapAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetRfc1123DateMapTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetRfc1123DateMapTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123DateMap date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123DateMap>("{\"dateTime\":{\"key\":\"Wed, 20 Jan 2021 12:26:13 GMT\"},\"dateTime1\":{\"key\":\"Wed, 20 Jan 2021 12:26:13 GMT\"}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateMapAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullRfc1123DateMapTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullRfc1123DateMapTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.Rfc1123DateMap date = ApiHelper.JsonDeserialize<Standard.Models.Rfc1123DateMap>("{\"dateTime\":null,\"dateTime1\":{\"key\":\"Wed, 20 Jan 2021 12:26:13 GMT\"}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendRfc1123DateMapAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}