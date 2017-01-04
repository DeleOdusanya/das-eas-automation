using System;
using System.Configuration;
using Mya.Automation.Tests.Properties;
using Mya.Automation.Tests.Tests.Pages.Base;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using TechTalk.SpecFlow;

namespace Mya.Automation.Tests.Tests.StepDefinition
{
    [Binding]
    public class CreateADasAccountSteps : TestBase
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
        [Given(@"I navigate to the Create Account page")]
        public void GivenINavigateToTheCreateAccountPage()
        {
            var webPage = WebBrowserDriver

                .CreateAnAccount();
        }
        
        [When(@"I submit the form with the mandatory data items supplied")]
        public void WhenISubmitTheFormWithTheMandatoryDataItemsSupplied()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit the activation code recieved as a consequence of a successful form submission")]
        public void WhenISubmitTheActivationCodeRecievedAsAConsequenceOfASuccessfulFormSubmission()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I attempt to submit a form without completing the mandatory data items")]
        public void WhenIAttemptToSubmitAFormWithoutCompletingTheMandatoryDataItems()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I attempt to submit a form with invalid data items")]
        public void WhenIAttemptToSubmitAFormWithInvalidDataItems()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit form with e-mail address already associated to an Active Account")]
        public void WhenISubmitFormWithE_MailAddressAlreadyAssociatedToAnActiveAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit a form with an e-mail address associated to a user that is Pending Activation")]
        public void WhenISubmitAFormWithAnE_MailAddressAssociatedToAUserThatIsPendingActivation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit form with valid data in all mandatory fields")]
        public void WhenISubmitFormWithValidDataInAllMandatoryFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter an Invalid activation code")]
        public void WhenIEnterAnInvalidActivationCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a DAS account will be created")]
        public void ThenADASAccountWillBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"validation messages will be displayed on all incomplete mandatory items")]
        public void ThenValidationMessagesWillBeDisplayedOnAllIncompleteMandatoryItems()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be presented with an appropriate validation message")]
        public void ThenIWillBePresentedWithAnAppropriateValidationMessage()
        {
            ScenarioContext.Current.Pending();
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
        
        [Then(@"a new account should be created")]
        public void ThenANewAccountShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all other information provided in this step should supersede information provided historically")]
        public void ThenAllOtherInformationProvidedInThisStepShouldSupersedeInformationProvidedHistorically()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be prompted to enter a valid activation code")]
        public void ThenIShouldBePromptedToEnterAValidActivationCode()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
