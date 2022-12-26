// <copyright file="UnixDateControllerTest.cs" company="APIMatic">
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
    /// UnixDateControllerTest.
    /// </summary>
    [TestFixture]
    public class UnixDateControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private UnixDateController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.UnixDateController;
        }

        /// <summary>
        /// TestUnsetUnixDateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetUnixDateTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.UnixDate date = ApiHelper.JsonDeserialize<Standard.Models.UnixDate>("{\"dateTime1\":1484719381}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetUnixDateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetUnixDateTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.UnixDate date = ApiHelper.JsonDeserialize<Standard.Models.UnixDate>("{\"dateTime\":1484719381,\"dateTime1\":1484719381}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullUnixDateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullUnixDateTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.UnixDate date = ApiHelper.JsonDeserialize<Standard.Models.UnixDate>("{\"dateTime\":null,\"dateTime1\":1484719381}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetUnixDateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetUnixDateArrayTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.UnixDateArray date = ApiHelper.JsonDeserialize<Standard.Models.UnixDateArray>("{\"dateTime1\":[1484719381,1484719381]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetUnixDateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetUnixDateArrayTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.UnixDateArray date = ApiHelper.JsonDeserialize<Standard.Models.UnixDateArray>("{\"dateTime\":[1484719381,1484719381],\"dateTime1\":[1484719381,1484719381]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullUnixDateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullUnixDateArrayTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.UnixDateArray date = ApiHelper.JsonDeserialize<Standard.Models.UnixDateArray>("{\"dateTime\":null,\"dateTime1\":[1484719381,1484719381]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetUnixDateMapTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetUnixDateMapTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.UnixDateMap date = ApiHelper.JsonDeserialize<Standard.Models.UnixDateMap>("{\"dateTime1\":{\"key\":1484719381}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateMapAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetUnixDateMapTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetUnixDateMapTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.UnixDateMap date = ApiHelper.JsonDeserialize<Standard.Models.UnixDateMap>("{\"dateTime\":{\"key\":1484719381},\"dateTime1\":{\"key\":1484719381}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateMapAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullUnixDateMapTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullUnixDateMapTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.UnixDateMap date = ApiHelper.JsonDeserialize<Standard.Models.UnixDateMap>("{\"dateTime\":null,\"dateTime1\":{\"key\":1484719381}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendUnixDateMapAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}