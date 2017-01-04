using Mya.Automation.Tests.Properties;
using Mya.Automation.Tests.Tests.Pages.Base;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using System;
using System.Configuration;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mya.Automation.Tests.Tests.StepDefinition
{
    [Binding]
    public class SignInSteps : TestBase
    {
        private readonly string _apprenticeWebsite = ConfigurationManager.AppSettings["BaseUrl"];
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited+Tester@gmail.com";
        private const string PassWord = "Password1";

        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonTestSetup(new Uri(_apprenticeWebsite), true, WebDriver.Zap);

            WebBrowserDriver
                .Landing();
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
                .Landing()
                .ClickUsedServiceBeforeRadioBtn();
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
        
        [When(@"I submit details of an account that has not been activated")]
        public void WhenISubmitDetailsOfAnAccountThatHasNotBeenActivated()
        {
            ScenarioContext.Current.Pending();
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

            Assert.That(webPage.GetInvalidCredentialsErrorField(), Is.EqualTo(string.Format("", "Invalid credentials")));

            //Assert.That(webPage.GetEmailAddressRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            //Assert.That(webPage.GetEmailAddressRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));

        }

        [Then(@"error messages to all fields will be displayed")]
        public void ThenErrorMessagesToAllFieldsWillBeDisplayed()
        {
            var webPage = WebBrowserDriver
                            .SignIn();

            Assert.That(webPage.GetInvalidCredentialsErrorField(), Is.EqualTo(string.Format("", "Invalid credentials")));

            //Assert.That(webPage.GetEmailAddressRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            //Assert.That(webPage.GetEmailAddressRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            //Assert.That(webPage.GetPasswordRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
            //Assert.That(webPage.GetPasswordRequiredFieldInbox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
        }

        [Then(@"I should be prompted that my account has not been activated")]
        public void ThenIShouldBePromptedThatMyAccountHasNotBeenActivated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
