using System;
using System.Configuration;
using Mya.Automation.AcceptanceTests.Pages.Base;
using NUnit.Framework;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;

namespace Mya.Automation.AcceptanceTests.Tests.Base
{
    [TestFixture]
    public class Test : TestBase
    {
        private readonly string Url = ConfigurationManager.AppSettings["BaseUrl"]; 

        [SetUp]
        public void SetUp() { }

        [Test]
        public void GoogleTest()
        {
            CommonTestSetup(new Uri(Url), true, WebDriver.Chrome);

            var webPage = WebBrowserDriver
            .Landing()
            .ClickNotUsedServiceBeforeRadioBtn()
            .DontHaveWhatINeed();

            Assert.That(webPage.GetErrorMessage(), Is.EqualTo(string.Format("You need your Companies House number and your Government Gateway login details to create an account", "Invalid credentials")));
        }

        [TearDown]
        public void TearDown()
        {
            WebBrowserDriver.Quit();
        }
    }
}
