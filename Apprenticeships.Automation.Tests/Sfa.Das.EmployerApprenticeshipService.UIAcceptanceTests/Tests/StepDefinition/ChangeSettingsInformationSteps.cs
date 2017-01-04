using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class ChangeSettingsInformationSteps
    {
        [Given(@"I'm logged in to my DAS account")]
        public void GivenIMLoggedInToMyDASAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit new password")]
        public void WhenISubmitNewPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"enter the auth code")]
        public void WhenEnterTheAuthCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit new email")]
        public void WhenISubmitNewEmail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should receive a confirmation that my password has been changed")]
        public void ThenIShouldReceiveAConfirmationThatMyPasswordHasBeenChanged()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should receive a confirmation that my email has been changed")]
        public void ThenIShouldReceiveAConfirmationThatMyEmailHasBeenChanged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
