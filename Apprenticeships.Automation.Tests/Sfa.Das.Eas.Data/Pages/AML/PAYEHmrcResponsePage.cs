using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class PAYEHmrcResponsePage : SfaBasePage
    {
        private readonly IWebDriver _driver;
        public PAYEHmrcResponsePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }
        [FindsBy(How = How.ClassName, Using = "button")] private IWebElement AuthoriseButton;
        [FindsBy(How = How.LinkText, Using = "Do not grant authority")] private IWebElement DenyButton;
        [FindsBy(How = How.Id, Using = "accept")] private IWebElement YesContinue;

        internal PAYEHmrcResponsePage PAYEHmrcGrantAuthority()
        {
            ClickGrantAuthority();
            return this;
        }
       
        internal AccountHomePage PAYEYesContinue()
        {
            ClickPAYEYesContinue();
            return new AccountHomePage(_driver);
        }

        internal PAYEHmrcResponsePage PAYEHmrcDoNotGrantAuthority()
        {
            ClickDoNotGrantAuthority();
            return this;
        }
        private void ClickGrantAuthority()
        {
            AuthoriseButton.Click(_driver);
        }

        private void ClickDoNotGrantAuthority()
        {
            DenyButton.Click(_driver);
        }

        private void ClickPAYEYesContinue()
        {
            YesContinue.Click(_driver);
        }

       
    }
}