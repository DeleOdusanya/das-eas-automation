using System;
using NUnit.Framework;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.Eas.Shared;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.Tests.Tests.Base
{
    [TestFixture]
    public class HelloWorld : TestBase
    {
        private const string Url = "http://test-eas.apprenticeships.sfa.bis.gov.uk/";
        private const string UserName = "jsinclair.pride+1@gmail.com";
        private const string PassWord = "Password01";
        private const string FirstName = "Test";
        private const string LastName = "Test";
        private const string Email = "rohan_jasons@hotmail.co.uk";
        private const string AccountPassWord = "Password01";
        private const string InValidCompanyNo = "ThisIsAATest";
        private const string ValidCompanyNo = "07607273";
        private const string HmrcUserName = "perfuser57";
        private const string HmrcPassWord = "password";
        private const string InvalidHmrcUserName = "perfuser57a";
        private const string InvalidHmrcPassWord = "passworda";
        private const string SecurityUrl = "http://localhost:8095/json/core/view/alerts";
        //create the fields for the hmrc user and password


        [SetUp]
        public void SetUp() { }

        [TestCase(WebDriver.Chrome)]
        public void SimpleTestNine(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .LandingPage()
                .ClickNotUsedServiceBefore();
                //.SelectNeverUsedServiceButton();
        }

        [TearDown]
        public void TearDown()
        {

            //CommonTestSetup(new Uri(SecurityUrl), true, WebDriver.Chrome);

            //WebBrowserDriver.Quit();
        }
    }
}
