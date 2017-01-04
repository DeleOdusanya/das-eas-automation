using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps.NavigationSteps;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.Pirean;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps
{
    

    [Binding]
    public class CreateDASAccountSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();
        
        [Given(@"I Create a DAS Account")]
        [When(@"I Create a DAS Account")]
        [Then(@"I Create a DAS Account")]
        public void WhenICreateADASAccount()
        {

            _navigationsteps.CreateADasAccount();

        }

        [Then(@"An account should be ""(.*)""")]
        public void ThenAnAccountShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
