using System;
using NUnit.Framework;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using TechTalk.SpecFlow;
using System.Configuration;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class SignInSteps : TestBase
    {
        private readonly string _gettingStartedUrl = ConfigurationManager.AppSettings["baseUrl"]; 
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited@gmail.com";
        private const string PassWord = "Dell1507";

        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonTestSetup(new Uri(_gettingStartedUrl), true, WebDriver.Chrome);
            WebBrowserDriver
                .LandingPage();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebBrowserDriver.Quit();
        }

        [Given(@"I navigate to the Sign In page")]
        public void GivenINavigateToTheSignInPage()
        {
            WebBrowserDriver
                .LandingPage()
                .SelectUsedServiceBeforeButton();
        }

        [When(@"I submit valid details")]
        public void WhenISubmitValidDetails()
        {
            WebBrowserDriver
                .SignIn()
                .ValidLogin(Email, PassWord);
        }
        
        [When(@"I submit invalid details")]
        public void WhenISubmitInvalidDetails()
        {
            WebBrowserDriver
                .SignIn()
                .InvalidLogin(FirstName, LastName);
        }
        
        [When(@"I submit no details")]
        public void WhenISubmitNoDetails()
        {
            WebBrowserDriver
                .SignIn()
                .IncompleteLogin();
        }
        
        [Then(@"I should be signed in to my account")]
        public void ThenIShouldBeSignedInToMyAccount()
        {
            WebBrowserDriver
                .AccountLanding();
        }
        
        [Then(@"I should be prompted to enter valid details")]
        public void ThenIShouldBePromptedToEnterValidDetails()
        {
            var webPage = WebBrowserDriver
                .SignIn();

           Assert.That(webPage.GetEmailAddressRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
           Assert.That(webPage.GetEmailAddressRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));

        }

        [Then(@"error messages to all fields will be displayed")]
        public void ThenErrorMessagesToAllFieldsWillBeDisplayed()
        {
            var webPage = WebBrowserDriver
                .SignIn();

            Assert.That(webPage.GetEmailAddressRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            Assert.That(webPage.GetEmailAddressRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            Assert.That(webPage.GetPasswordRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
            Assert.That(webPage.GetPasswordRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
        }
    }
}
