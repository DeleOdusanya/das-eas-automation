using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.No;
using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.Yes;
using Mya.Automation.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage
{
    public class Landing : MyaBasePage
    {
        private readonly IWebDriver _driver;

        public Landing(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        //Fails when attempting to use ID...
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div/div/form/div[1]/fieldset/label[1]")] private IWebElement UsedServiceBefore { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div/div/form/div[1]/fieldset/label[2]")] private IWebElement NotUsedServiceBefore { get; set; }
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement Continue { get; set; }

        internal SignIn ClickUsedServiceBeforeRadioBtn()
        {
            ClickUsedServiceBefore();
            return new SignIn(_driver);
        }

        internal WhatYoullNeed ClickNotUsedServiceBeforeRadioBtn()
        {
            ClickNotUsedServiceBefore();
            return new WhatYoullNeed(_driver);
        }

        #region Functions

        private void ClickUsedServiceBefore()
        {
            CheckThisRadioButton(UsedServiceBefore);
            ClickContinue();
        }

        private void ClickNotUsedServiceBefore()
        {
            CheckThisRadioButton(NotUsedServiceBefore);
            ClickContinue();
        }

        private void ClickContinue()
        {
            ClickThisElement(Continue);
        }

        #endregion

    }
}

