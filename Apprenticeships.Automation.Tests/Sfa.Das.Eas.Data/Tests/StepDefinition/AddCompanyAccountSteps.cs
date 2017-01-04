using System;
using NUnit.Framework;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;
using Sfa.Das.Eas.Shared;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Pages.Pirean;
using Sfa.Das.EAS.AcceptanceTests.Properties;
using TechTalk.SpecFlow;

namespace Sfa.Das.EAS.AcceptanceTests.Tests.StepDefinition
{
    [Binding]
    public class AddCompanyAccountSteps : TestBase
    {
        private readonly string _gettingStartedUrl = Settings.Default.GettingStarted;
        private const string FirstName = "Tony";
        private const string LastName = "Soprano";
        private const string Email = "lynkmiilimited+13new4@gmail.com";
        private const string PassWord = "Dell1507";
        private const string ValidCompanyNo = "07607273";
        private const string invalidCompanyHouseNo = "076072aas";
        private const string HmrcUserName = "perfuser57";
        private const string HmrcPassWord = "password";
        private const string InvalidHmrcUserName = "perfuser57weffw";
        private const string InvalidHmrcPassWord = "passwordregeg";

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

        [Given(@"I am logged into my DAS Account")]
        public void GivenIAmLoggedIntoMyDasAccount()
        {
            WebBrowserDriver
                .LandingPage()
                .SelectUsedServiceBeforeButton()
                .ValidLogin(Email, PassWord);
        }
                
        [When(@"I enter my company number")]
        public void WhenIEnterMyCompanyNumber()
        {
            WebBrowserDriver
                .SearchForCompanyPage()
                .ValidSearch(ValidCompanyNo);
        }
        
        [When(@"I click continue to connect to Hmrc")]
        public void WhenIClickContinueToConnectToHmrc()
        {
            WebBrowserDriver
                .SearchForCompanyPage()
                .ConnectToHmrc(ValidCompanyNo);
        }
        
        [When(@"I enter Government gateway ID with password")]
        public void WhenIEnterGovernmentGatewayIdWithPassword()
        {
            WebBrowserDriver
                .HMRCLogInPage()
                .ValidHmrcLogin(HmrcUserName, HmrcPassWord)
                .HmrcGrantAuthority()
                .HmrcCorrectDetails();
        }
        
        [Then(@"the company should be added to the DAS Account")]
        public void ThenTheCompanyShouldBeAddedToTheDasAccount()
        {
            WebBrowserDriver
                .AccountLanding();         
        }

        [When(@"I enter an Invalid company number")]
        public void WhenIEnterAnInvalidCompanyNumber()
        {
            WebBrowserDriver
               .AccountLanding()
               .ClickChangeLevyAccountLink()
               .AddAccount()
               .InvalidSearch(invalidCompanyHouseNo);
        }

        [Then(@"I should be prompted to Enter a valid Companies House number")]
        public void ThenIShouldBePromptedToEnterAValidCompaniesHouseNumber()
        {
            var webPage = WebBrowserDriver
                .SearchForCompanyPage();
            Assert.That(webPage.GetCompaniesHousenumberErrorInBox, Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "Enter a valid Companies House number")));
            Assert.That(webPage.GetCompaniesHousenumberdErrorField(), Is.EqualTo(string.Format(InformationMessages.EnterMandatoryField, "Enter a valid Companies House number")));
        }

        [When(@"I enter an invalid Government gateway ID with password")]
        public void WhenIEnterAnInvalidGovernmentGatewayIDWithPassword()
        {
            WebBrowserDriver
                .HMRCLogInPage()
                .InvalidHmrcLogIn(InvalidHmrcUserName, InvalidHmrcPassWord);
        }

        [Then(@"I should be prompted to Enter valid credentials")]
        public void ThenIShouldBePromptedToEnterValidCredentials()
        {
            WebBrowserDriver
                .HMRCLogInPage();
        }

    }
}
