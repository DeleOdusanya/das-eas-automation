using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.EAS.AcceptanceTests.Properties;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class InviteTeamMemberSteps : TestBase
    {
        private readonly string _gettingStartedUrl = Settings.Default.GettingStarted;
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited+13new4@gmail.com";
        private const string PassWord = "Dell1507";
        private const string AddPAYEHmrcUserName = "perfuser22";
        private const string AddPAYEHmrcPassWord = "password";

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
        [When(@"I invite a team member with valid email address and name")]
        public void WhenIInviteATeamMemberWithValidEmailAddressAndName()
        {
            WebBrowserDriver
               .AccountHomePage()
               .ClickYourTeam
               .

               
               
        }
        
        [When(@"I invite a team member")]
        public void WhenIInviteATeamMember()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click resend invite")]
        public void WhenIClickResendInvite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click cancel invite")]
        public void WhenIClickCancelInvite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm cancellation")]
        public void WhenIConfirmCancellation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I selelect NO don't cancel")]
        public void WhenISelelectNODonTCancel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I delete a team member")]
        public void WhenIDeleteATeamMember()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"A user invite is sent")]
        public void ThenAUserInviteIsSent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Invite should be resent")]
        public void ThenInviteShouldBeResent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Invite should be cancelled")]
        public void ThenInviteShouldBeCancelled()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"member invite removed from page")]
        public void ThenMemberInviteRemovedFromPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Invite should NOT be cancelled")]
        public void ThenInviteShouldNOTBeCancelled()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view team members")]
        public void ThenIShouldBeAbleToViewTeamMembers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"team member is removed from list")]
        public void ThenTeamMemberIsRemovedFromList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
