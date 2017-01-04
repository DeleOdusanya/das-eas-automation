using System;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Properties;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class AddPAYESteps : TestBase
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

        [Given(@"I am an account account owner")]
        public void GivenIAmAnAccountAccountOwner()
        {
            WebBrowserDriver
                .LandingPage()
                .SelectUsedServiceBeforeButton()
                .ValidLogin(Email, PassWord)
                .ClickOpenAccountLink();

        }
        
        [When(@"I Add a new PAYE scheme to my existing legal entity")]
        public void WhenIAddANewPAYESchemeToMyExistingLegalEntity()
        {
            WebBrowserDriver
                .AccountHomePage()
                .ClickPAYEschemes()
                .AddNewPayee()
                .AddPAYEAgreeAndContinue()
                .PAYEValidHmrcLogin(AddPAYEHmrcUserName, AddPAYEHmrcPassWord)
                .PAYEHmrcGrantAuthority()
                .PAYEYesContinue();

        }
        
        [Then(@"The PAYE scheme Is added to my account")]
        public void ThenThePAYESchemeIsAddedToMyAccount()
        {
            WebBrowserDriver
                .PAYESchemesPage();

        }
    }
}
