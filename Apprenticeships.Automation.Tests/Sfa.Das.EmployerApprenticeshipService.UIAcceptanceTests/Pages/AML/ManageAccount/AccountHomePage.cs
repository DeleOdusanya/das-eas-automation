using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.ManageAccount
{
    public class AccountHomePage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public AccountHomePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }
        
        [FindsBy(How = How.LinkText, Using = "Your team")] private IWebElement YourTeamLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Finance")] private IWebElement YourFinanceLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Organisations")] private IWebElement OrganisationsLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "PAYE schemes")] private IWebElement PAYEschemesLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Apprentices")] private IWebElement ApprenticesLink { get; set; }

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
