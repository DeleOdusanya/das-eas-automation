using System;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Properties;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class RemovePAYESteps : TestBase
    {
        private readonly string _gettingStartedUrl = Settings.Default.GettingStarted;
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited+13new4@gmail.com";
        private const string PassWord = "Dell1507";
        private const string AddPAYEHmrcUserName = "perfuser22";
        private const string AddPAYEHmrcPassWord = "password";

        [BeforeScenarioAttribute]
        public void BeforeScenario()
        {
            CommonTestSetup(new Uri(_gettingStartedUrl), true, WebDriver.Zap);
            WebBrowserDriver
                .LandingPage();
        }

        [AfterScenarioAttribute]
        public void AfterScenario()
        {
            WebBrowserDriver.Quit();
        }

        [Given(@"I am an account viewer owner")]
        public void GivenIAmAnAccountViewerOwner()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Remove a PAYE scheme from my account")]
        public void WhenIRemoveAPAYESchemeFromMyAccount()
        {
            WebBrowserDriver
                .AccountHomePage()
                .ClickPAYEschemes()
                .ClickDetailsLink()
                .ClickRemoveSchemeBtn()
                .SelectRemoveSchemeYesContinue()
                .ClickRemoveSchemeContinueBtn();

        }
        
        [Then(@"The PAYE scheme should be removed from my account")]
        public void ThenThePAYESchemeShouldBeRemovedFromMyAccount()
        {
            WebBrowserDriver
                .PAYESchemesPage();
        }
        
        [Then(@"The PAYE scheme should NOT be removed from my account")]
        public void ThenThePAYESchemeShouldNOTBeRemovedFromMyAccount()
        {
            WebBrowserDriver
               .PAYESchemesPage();
        }
    }
}
