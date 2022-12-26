// <copyright file="SimpleDateControllerTest.cs" company="APIMatic">
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
    /// SimpleDateControllerTest.
    /// </summary>
    [TestFixture]
    public class SimpleDateControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SimpleDateController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SimpleDateController;
        }

        /// <summary>
        /// TestUnsetSimpleDateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetSimpleDateTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.SimpleDate date = ApiHelper.JsonDeserialize<Standard.Models.SimpleDate>("{}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendSimpleDateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetSimpleDateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetSimpleDateTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.SimpleDate date = ApiHelper.JsonDeserialize<Standard.Models.SimpleDate>("{\"dateNullable\":\"2020-01-08\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendSimpleDateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullSimpleDateTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullSimpleDateTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.SimpleDate date = ApiHelper.JsonDeserialize<Standard.Models.SimpleDate>("{\"dateNullable\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendSimpleDateAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetSimpleDateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetSimpleDateArrayTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.SimpleDateArray date = ApiHelper.JsonDeserialize<Standard.Models.SimpleDateArray>("{}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendSimpleDateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetSimpleDateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetSimpleDateArrayTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.SimpleDateArray date = ApiHelper.JsonDeserialize<Standard.Models.SimpleDateArray>("{\"date\":[\"2020-01-08\", \"2020-01-09\"]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendSimpleDateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullSimpleDateArrayTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullSimpleDateArrayTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.SimpleDateArray date = ApiHelper.JsonDeserialize<Standard.Models.SimpleDateArray>("{\"date\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendSimpleDateArrayAsync(unSet, setToNull, field, date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}