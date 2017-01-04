using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class AccountHomePage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public AccountHomePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }
        
        [FindsBy(How = How.LinkText, Using = "Your team")] private IWebElement YourTeamLink;
        [FindsBy(How = How.LinkText, Using = "Finance")] private IWebElement YourFinanceLink;
        [FindsBy(How = How.LinkText, Using = "Organisations")] private IWebElement OrganisationsLink;
        [FindsBy(How = How.LinkText, Using = "PAYE schemes")] private IWebElement PAYEschemesLink;
        [FindsBy(How = How.LinkText, Using = "Apprentices")] private IWebElement ApprenticesLink;

        internal PAYESchemesPage ClickPAYEschemes()
        {
            ClickPAYEschemesLink();
            return new PAYESchemesPage(_driver);
        }

        internal PAYESchemesPage ClickYourTeam()
        {
            ClickYourTeamLink();
            return new PAYESchemesPage(_driver);
        }

        #region Functions


        private void ClickYourTeamLink()
        {
           YourTeamLink.WaitForElementIsVisible();
           YourTeamLink.Click(_driver);
        }
        
        private void ClickPAYEschemesLink()
        {
            Thread.Sleep(2000);
            PAYEschemesLink.WaitForElementIsVisible();
            PAYEschemesLink.Click(_driver);
        }

        #endregion
    }
}
