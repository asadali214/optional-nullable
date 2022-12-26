// <copyright file="BodyControllerTest.cs" company="APIMatic">
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
    /// BodyControllerTest.
    /// </summary>
    [TestFixture]
    public class BodyControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private BodyController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BodyController;
        }

        /// <summary>
        /// TestUnsetChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetChildTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional_Nullable";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":\"setted optionalNullable\",\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullOptionalNullableChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullOptionalNullableChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetOptionalChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetOptionalChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Optional";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetOptionalChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetOptionalChildTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Optional";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetRequiredNullableChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetRequiredNullableChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Required_Nullable";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":\"setted required nullable\",\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullRequiredNullableChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullRequiredNullableChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Required_Nullable";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetRequiredChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetRequiredChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Required";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestUnsetChildClassArrayChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnsetChildClassArrayChildTest()
        {
            // Parameters for the API call
            bool unSet = true;
            bool setToNull = false;
            string field = "Child_Class_Array";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetChildClassArrayChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetChildClassArrayChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = false;
            string field = "Child_Class_Array";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":[{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null},{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}]}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetToNullChildArrayChildTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetToNullChildArrayChildTest()
        {
            // Parameters for the API call
            bool unSet = false;
            bool setToNull = true;
            string field = "Optional_Nullable";
            Standard.Models.ChildClass child = ApiHelper.JsonDeserialize<Standard.Models.ChildClass>("{\"Grand_Parent_Required_Nullable\":null,\"Grand_Parent_Required\":\"not nullable and required\",\"class\":23,\"Parent_Optional_Nullable_With_Default_Value\":\"Has default value\",\"Parent_Required_Nullable\":null,\"Parent_Required\":\"not nullable and required\",\"Optional_Nullable\":null,\"Optional_Nullable_With_Default_Value\":\"With default value\",\"Required_Nullable\":null,\"Required\":\"not nullable and required\",\"Optional\":\"not nullable and optional\",\"Child_Class_Array\":null}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.CreateSendChildAsync(unSet, setToNull, field, child);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}