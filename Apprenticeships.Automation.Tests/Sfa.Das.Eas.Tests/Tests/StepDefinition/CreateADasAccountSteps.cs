using System;
using System.Configuration;
using NUnit.Framework;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.Eas.Shared;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Properties;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class CreateADasAccountSteps : TestBase
    {
        private readonly string _gettingStartedUrl = ConfigurationManager.AppSettings["baseUrl"];
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited+13new4@gmail.com";
        private const string PassWord = "Password01";

        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonTestSetup(new Uri(_gettingStartedUrl), true, WebDriver.Zap);
            WebBrowserDriver
                .LandingPage()
                .ClickUsedServiceBefore()
                .ClickCreateAccount();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebBrowserDriver.Quit();
        }

        [Given(@"I navigate to the Create Account page")]
        public void GivenINavigateToTheCreateAccountPage()
        {
            var webPage = WebBrowserDriver

                .CreateAnAccount();
               
           // Assert.That(webPage.IsThisCorrectPage(), Is.True, "Did not land at the correct page.");
        }
        
        [When(@"I attempt to submit a form without completing the mandatory data items")]
        public void WhenIAttemptToSubmitAFormWithoutCompletingTheMandatoryDataItems()
        {
            var webPage = WebBrowserDriver
                .CreateAnAccount()
                .SubmitIncompleteForm();

            Assert.That(webPage.IsTheErrorBoxDisplayed(), Is.True, "Error box not displayed");
        }

        [Then(@"validation messages will be displayed on all incomplete mandatory items")]
        public void ThenValidationMessagesWillBeDisplayedOnAllIncompleteMandatoryItems()
        {
            var webPage = WebBrowserDriver
                .CreateAnAccount();

            Assert.That(webPage.GetFirstNameRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "first name")));
            Assert.That(webPage.GetFirstNameRequiredInBox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "first name")));
            Assert.That(webPage.GetLastNameRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "last name")));
            Assert.That(webPage.GetLastNameRequiredInBox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "last name")));
            Assert.That(webPage.GetEmailRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
            Assert.That(webPage.GetEmailRequiredInBox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "a valid email address")));
           
            Assert.That(webPage.GetPasswordRequiredField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "your password")));
            Assert.That(webPage.GetPasswordRequiredInBox(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "password")));
            Assert.That(webPage.GetPasswordRetryRequiredField(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "Re-type password")));
            Assert.That(webPage.GetPasswordRetryRequiredInBox(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "Re-type password")));
           
            //Assert.That(webPage.GetAccepMessageInField(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "terms of use.")));
            //Assert.That(webPage.GetAcceptMessageInBox(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "terms of use.")));
        }

        [When(@"I submit the form with the mandatory data items supplied")]
        public void WhenISubmitTheFormWithTheMandatoryDataItemsSupplied()
        {
            WebBrowserDriver
                .CreateAnAccount()
                .SubmitValidForm(FirstName, LastName, Email, PassWord);
        }

        [When(@"I submit the activation code recieved as a consequence of a successful form submission")]
        public void WhenISubmitTheActivationCodeRecievedAsAConsequenceOfASuccessfulFormSubmission()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a DAS account will be created")]
        public void ThenADASAccountWillBeCreated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I attempt to submit a form with invalid data items")]
        public void WhenIAttemptToSubmitAFormWithInvalidDataItems()
        {
            WebBrowserDriver
                .CreateAnAccount()
                //will complete this in a short bit
                .SubmitInvalidForm("","","","");
        }

        [Then(@"I will be presented with an appropriate validation message")]
        public void ThenIWillBePresentedWithAnAppropriateValidationMessage()
        {
            var webPage = WebBrowserDriver
                .CreateAnAccount();

            //Assert.That(webPage.GetAccepMessageInField(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "terms of use")));
            //Assert.That(webPage.GetAcceptMessageInBox(), Is.EqualTo(string.Format(InformationMessages.MandatoryFieldCheck, "Check the terms of use")));
        }

        [When(@"I submit form with e-mail address already associated to an Active Account")]
        public void WhenISubmitFormWithE_MailAddressAlreadyAssociatedToAnActiveAccount()
        {
            WebBrowserDriver
                .CreateAnAccount()
                .SubmitValidForm(FirstName, LastName, Email, PassWord);
        }

        [Then(@"I will be informed that the email address is already associated")]
        public void ThenIWillBeInformedThatTheEmailAddressIsAlreadyAssociated()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should remain on the account creation page")]
        public void ThenIShouldRemainOnTheAccountCreationPage()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
