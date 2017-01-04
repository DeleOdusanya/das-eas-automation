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

        [TestCase(WebDriver.Zap)]
        public void SimpleTest(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ValidLogin(UserName, PassWord)
                .ClickSignOut();
        }
         
        [TestCase(WebDriver.Zap)]
        public void SimpleTestTwo(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ClickCreateAccount()
                .SubmitIncompleteForm();

            CommonTestSetup(new Uri(""), true, WebDriver.Chrome);
        }
         
        [TestCase(WebDriver.Chrome)]
        public void SimpleTestThree(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ClickCreateAccount()
                .SubmitValidForm(FirstName, LastName, Email, AccountPassWord)
                .ClickSignInWithNoCode();
        }

        [TestCase(WebDriver.Chrome)]
        public void SimpleTestFour(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            var webPage = WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ClickCreateAccount()
                .SubmitInvalidForm(FirstName, LastName, Email, AccountPassWord);

            Assert.That(webPage.GetEmailInUseErrorInField(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "Use a different email address to register")));
            Assert.That(webPage.GetEmailInUseErrorInBox(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "Email already registered")));
        }

        [TestCase(WebDriver.Chrome)]
        public void SimpleTestFive(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ValidLogin(UserName, PassWord)
                .AddAccount();
        }

        [TestCase(WebDriver.Chrome)]
        public void SimpleTestSix(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ValidLogin(UserName, PassWord)
                .AddAccount()
                .IncompleteSearch()
                .InvalidSearch(InValidCompanyNo)
                .ValidSearch(ValidCompanyNo);
        }
        
        [TestCase(WebDriver.Zap)]
        public void SimpleTestSeven(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .GetStarted()
                .ClickSignIn()
                .ValidLogin(UserName, PassWord)
                .AddAccount()
                .ValidSearch(ValidCompanyNo)
                .IncompleteHmrcLogin()
                .InvalidHmrcLogIn(InvalidHmrcUserName, InvalidHmrcPassWord)
                .ValidHmrcLogin(HmrcUserName, HmrcPassWord);
        }

        [TestCase(WebDriver.Chrome)]
        public void SimpleTestEight(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .LandingPage()
                .SelectUsedServiceBeforeButton()
                .ValidLogin(UserName, PassWord);
        }

        [TestCase(WebDriver.Chrome)]
        public void SimpleTestNine(WebDriver webDriver)
        {
            CommonTestSetup(new Uri(Url), true, webDriver);

            WebBrowserDriver
                .LandingPage()
                .SelectNeverUsedServiceButton();
        }

        [TearDown]
        public void TearDown()
        {

            //CommonTestSetup(new Uri(SecurityUrl), true, WebDriver.Chrome);

            //WebBrowserDriver.Quit();
        }
    }
}
