using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML.ManageAccount;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class HmrcResponsePage : SfaBasePage
    {
        private readonly IWebDriver _driver;
        public HmrcResponsePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.ClassName, Using = "button")] private IWebElement AuthoriseButton { get; set; }
        [FindsBy(How = How.LinkText, Using = "Do not grant authority")] private IWebElement DenyButton { get; set; }
        [FindsBy(How = How.Id, Using = "continue")] private IWebElement CorrectDetails { get; set; }
        // [FindsBy(How = How.Id, Using = "accept")] private IWebElement YesContinue{ get; set; }

        internal HmrcResponsePage HmrcGrantAuthority()
        {
            ClickGrantAuthority();
            return this;
        }
        internal AccountHomePage HmrcCorrectDetails()
        {
            ClickTheseDetailsAreCorrect();
            return new AccountHomePage(_driver);
        }

        //internal AccountHomePage PAYEYesContinue()
        //{
        //    ClickPAYEYesContinue();
        //    return new AccountHomePage(_driver);
        //}

        internal HmrcResponsePage HmrcDoNotGrantAuthority()
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

        //private void ClickPAYEYesContinue()
        //{
        //    CorrectDetails.Click(_driver);
        //}

        private void ClickTheseDetailsAreCorrect()
        {
            CorrectDetails.Click(_driver);
        }
    }
}
