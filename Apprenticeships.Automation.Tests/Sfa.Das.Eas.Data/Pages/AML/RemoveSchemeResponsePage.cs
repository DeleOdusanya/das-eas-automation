using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class RemoveSchemeResponsePage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public RemoveSchemeResponsePage(IWebDriver webDdriver) : base(webDdriver)
        {
            _driver = webDdriver;
        }

        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'remove scheme\')]")] private IWebElement RemoveSchemeYesContinue;
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'remove scheme\')]")] private IWebElement RemoveSchemeContinueBtn;

        internal RemoveSchemeResponsePage SelectRemoveSchemeYesContinue()
        {
            SelectRemoveSchemeYesContinue();
            return this;
        }

        internal PAYESchemesPage ClickRemoveSchemeContinueBtn()
        {
            ClickRemoveSchemeContinueBtn();
            return new PAYESchemesPage(_driver);
        }
    }
}
