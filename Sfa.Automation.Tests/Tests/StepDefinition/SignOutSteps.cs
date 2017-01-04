using System;
using Mya.Automation.Tests.Properties;
using Mya.Automation.Tests.Tests.Pages.Base;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using TechTalk.SpecFlow;

namespace Mya.Automation.Tests.Tests.StepDefinition
{
    [Binding]
    public class SignOutSteps : TestBase
    {
        private readonly string _apprenticeWebsite = Settings.Default.LandingPage;
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited+Tester@gmail.com";
        private const string PassWord = "Password1";

        [AfterScenario]
        public void AfterScenario()
        {
            //WebBrowserDriver.Quit();
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            CommonTestSetup(new Uri(_apprenticeWebsite), true, WebDriver.Chrome);

            WebBrowserDriver
                .Landing()
                .ClickUsedServiceBeforeRadioBtn()
                .ValidLogin(Email, PassWord);
        }
        
        [When(@"I click the Log Out link")]
        public void WhenIClickTheLogOutLink()
        {
            WebBrowserDriver
                .AccountLanding();
                
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged out of my account")]
        public void ThenIShouldBeLoggedOutOfMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"returned to the homepage")]
        public void ThenReturnedToTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
