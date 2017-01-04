using System;
using System.Configuration;
using NUnit.Framework;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.Eas.Shared;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class SignInSteps : TestBase
    {
        private readonly string _gettingStartedUrl = ConfigurationManager.AppSettings["baseUrl"]; 
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited@gmail.com";
        private const string PassWord = "Dell2015";

        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonTestSetup(new Uri(_gettingStartedUrl), true, WebDriver.Zap);

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
                .ClickUsedServiceBefore();
        }

        [When(@"I submit valid details")]
        public void WhenISubmitValidDetails()
        {
            WebBrowserDriver
                .SignInPage()
                .ValidLogin(Email, PassWord);
        }
        
        [When(@"I submit invalid details")]
        public void WhenISubmitInvalidDetails()
        {
            WebBrowserDriver
                .SignInPage()
                .InvalidLogin(FirstName, LastName);
        }
        
        [When(@"I submit no details")]
        public void WhenISubmitNoDetails()
        {
            WebBrowserDriver
                .SignInPage()
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
                .SignInPage();

            Assert.That(webPage.GetInvalidCredentialsErrorField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "Invalid credentials")));

            //Assert.That(webPage.GetEmailAddressRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            //Assert.That(webPage.GetEmailAddressRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));

        }

        [Then(@"error messages to all fields will be displayed")]
        public void ThenErrorMessagesToAllFieldsWillBeDisplayed()
        {
            var webPage = WebBrowserDriver
                .SignInPage();

            Assert.That(webPage.GetInvalidCredentialsErrorField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "Invalid credentials")));

            //Assert.That(webPage.GetEmailAddressRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            //Assert.That(webPage.GetEmailAddressRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            //Assert.That(webPage.GetPasswordRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
            //Assert.That(webPage.GetPasswordRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
        }
    }
}
