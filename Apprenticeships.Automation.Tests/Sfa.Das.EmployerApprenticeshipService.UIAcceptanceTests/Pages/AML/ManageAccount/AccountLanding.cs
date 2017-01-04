using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.ManageAccount
{
    public class AccountLanding : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public AccountLanding(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Change levy account\')]")] private IWebElement SignOutBtn;
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Change levy account\')]")] private IWebElement ChangeLevyAccountLink;
        [FindsBy(How = How.Id, Using = "add_new_account")] private IWebElement AddAccountBtn;
       // [FindsBy(How = How.LinkText, Using = "Open")] private IWebElement OpenAccountLink;
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Open\')]")] private IWebElement OpenAccountLink;

        internal Homepage ClickSignOut()
        {
            Thread.Sleep(2000);
            SignOutBtn.Click(_driver);
            return new Homepage(_driver);
        }

        internal AccountHomePage OpenAccount()
        {
            ClickOpenAccountLink();
            return new AccountHomePage(_driver);
        }

        internal AccountLanding ClickChangeLevyAccountLink()
        {
            Thread.Sleep(2000);
            ChangeLevyAccountLink.Click(_driver);
            return this;
        }

        internal AccountLanding ClickOpenAccountLink()
        {
            Thread.Sleep(2000);
            OpenAccountLink.Click(_driver);
            return this;
        }

        internal SelectEmployer AddAccount()
        {
            AddAccountBtn.Click(_driver);
            return new SelectEmployer(_driver);
        }

        //private void ClickOpenAccountLink()
        //{
        //    Thread.Sleep(2000);
        //    OpenAccountLink.WaitForElementIsVisible();
        //    OpenAccountLink.Click(_driver);
        //}
    }
}

