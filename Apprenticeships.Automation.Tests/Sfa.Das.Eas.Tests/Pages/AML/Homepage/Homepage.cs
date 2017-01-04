using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML.SignIn;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML.Landing;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class Homepage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public Homepage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "used-service-before")] private IWebElement UsedServiceBefore { get; set; }
        [FindsBy(How = How.Id, Using = "not-used-service-before")] private IWebElement NotUsedServiceBefore { get; set; }
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement Continue { get; set; }

        internal SignInPage ClickUsedServiceBeforeRadioBtn()
        {
            ClickUsedServiceBefore();
            return new SignInPage(_driver);
        }

        internal WhatYoullNeed ClickNotUsedServiceBeforeRadioBtn()
        {
            ClickNotUsedServiceBefore();
            return new WhatYoullNeed(_driver);
        }

        #region

        private void ClickUsedServiceBefore()
        {
            CheckThisRadioButton(UsedServiceBefore);
            ClickThisElement(Continue);
        }

        private void ClickNotUsedServiceBefore()
        {
            CheckThisRadioButton(NotUsedServiceBefore);
            ClickThisElement(Continue);
        }

        private void ClickContinue()
        {
            ClickThisElement(Continue);
        }

        #endregion

    }
}