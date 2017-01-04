using Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps;
using TechTalk.SpecFlow;

namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Steps
{
    [Binding]
    public class PireanComponentsSteps
    {
        CoreSteps _navigationsteps = new CoreSteps();        
        
        [Given(@"I login Pirean")]
        public void GivenILoginPirean()
        {
            _navigationsteps.LoginPirean();

        }

        [When(@"Pirean Login Page is Titled ""(.*)""")]
        [Then(@"Pirean Login Page is Titled ""(.*)""")]
        public void ThenPireanLoginPageIsTitled(string expectedTitle)
        {

            //_navigationsteps.checkPageTitle(expectedTitle);
        }       
                
     
        [AfterScenario]
        public void closeBrowser()
        {
            _navigationsteps.CloseBrowser();
        }

        [Then(@"I close Browser")]
        public void ThenICloseBrowser()
        {
            _navigationsteps.Quit();
        }
        [Given(@"I set New firstname ""(.*)""")]
        [When(@"I set New firstname ""(.*)""")]
        [Then(@"I set New firstname ""(.*)""")]
        public void GivenISetNewFirstname(string firstname)
        {
            _navigationsteps.CreatePireanAccountSetFirstName(firstname);
        }

        [Given(@"I set New last name""(.*)""")]
        [When(@"I set New last name""(.*)""")]
        [Then(@"I set New last name""(.*)""")]
        public void GivenISetNewLastName(string lastname)
        {
            _navigationsteps.CreatePireanAccountSetLastName(lastname);
        }

        [Given(@"I set New email ""(.*)""")]
        [When(@"I set New email ""(.*)""")]
        [Then(@"I set New email ""(.*)""")]
        public void GivenISetNewEmail(string email)
        {
            _navigationsteps.CreatePireanAccountSetEmail(email);
        }

        [Given(@"I set New password ""(.*)""")]
        [When(@"I set New password ""(.*)""")]
        [Then(@"I set New password ""(.*)""")]
        public void GivenISetNewPassword(string password)
        {
            _navigationsteps.CreatePireanAccountSetPassword(password);
        }

        [Given(@"I click CreateAccount")]
        [When(@"I click CreateAccount")]
        [Then(@"I click CreateAccount")]
        public void ThenIClickCreateAccount()
        {
            _navigationsteps.AckonowledgeandCreatePireanAccount();
        }
        [Given(@"I want to register new user")]
        [When(@"I want to register new user")]
        [Then(@"I want to register new user")]
        public void GivenIWantToRegisterNewUser()
        {
            _navigationsteps.RegisterNewUser();
        }



    }
}
