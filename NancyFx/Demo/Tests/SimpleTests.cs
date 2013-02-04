using Nancy;
using Nancy.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NancyBrownBag.Tests
{
    public class SimpleTests
    {
        #region 01. Simple Not Found Test

        //[Fact]
        //public void ShouldReturnBadStatusWithNonExistingRoute()
        //{
        //    // Given
        //    var bootstrapper = new DefaultNancyBootstrapper();
        //    var browser = new Browser(bootstrapper);

        //    // When
        //    var result = browser.Get("/", with =>
        //    {
        //        with.HttpRequest();
        //    });

        //    // Then
        //    Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
        //}

        #endregion

        #region 02. Simple Found Route Test

        //[Fact]
        //public void ShouldReturnOKStatusWithExistingRoute()
        //{
        //    // Given
        //    var bootstrapper = new DefaultNancyBootstrapper();
        //    var browser = new Browser(bootstrapper);

        //    // When
        //    var result = browser.Get("/foo", with =>
        //    {
        //        with.HttpRequest();
        //    });

        //    // Then
        //    Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        //}

        #endregion

        #region 03. Submitting Extra Properties

        //[Fact]
        //public void ShouldReturnOKStatusWithExistingRouteProperties()
        //{
        //    // Given
        //    var bootstrapper = new DefaultNancyBootstrapper();
        //    var browser = new Browser(bootstrapper);

        //    // When
        //    var result = browser.Get("/foo", with =>
        //    {
        //        with.FormValue("name", "Robert Schultz");
        //        with.Query("Id", "3");
        //        with.Cookie("UcdmId", Guid.NewGuid().ToString());
        //        with.HttpRequest();
        //    });

        //    // Then
        //    Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        //}

        #endregion

        #region 04. Validating Dom Response

        //[Fact]
        //public void ShoulReturnValidDomProperties()
        //{
        //    // Given
        //    var bootstrapper = new DefaultNancyBootstrapper();
        //    var browser = new Browser(bootstrapper);

        //    // When
        //    var result = browser.Get("/foo", with =>
        //    {
        //        with.HttpRequest();
        //    });

        //    // Then
        //    result.Body["#content"]
        //        .ShouldExistOnce()
        //        .And
        //        .ShouldContain("Hello Rschultz", StringComparison.InvariantCultureIgnoreCase);
        //}

        #endregion
    }
}
