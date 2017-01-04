using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class ServicesLandingPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public ServicesLandingPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "add_new_account")] private IWebElement AddAccountBtn;
       // [FindsBy(How = How.LinkText, Using = "Open")] private IWebElement OpenAccountLink;

        internal SearchForCompanyPage AddNewAccount()
        {
            ClickAddAccountBtn();
            return new SearchForCompanyPage(_driver);
        }

        //internal AccountLanding OpenAccount()
        //{
        //    ClickOpenAccountLink();
        //    return new AccountLanding(_driver);
        //}

        private void ClickAddAccountBtn()
        {
            Thread.Sleep(2000);
            AddAccountBtn.WaitForElementIsVisible();
            AddAccountBtn.Click(_driver);
        }

        //private void ClickOpenAccountLink()
        //{
        //    Thread.Sleep(2000);
        //    OpenAccountLink.WaitForElementIsVisible();
        //    OpenAccountLink.Click(_driver);
        //}


    }
}
