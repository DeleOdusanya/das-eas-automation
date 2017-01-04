using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.No.CreateAccount;
using Mya.Automation.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.No
{
    public class WhatYoullNeed : MyaBasePage
    {
        private readonly IWebDriver _driver;

        public WhatYoullNeed(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"what-you-need-form\"]/fieldset/label[1]")] private IWebElement HaveEverything { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"what-you-need-form\"]/fieldset/label[2]")] private IWebElement DoNotHaveEverything { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"submit-button\"]")] private IWebElement Continue { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"have-not-got-everything\"]")] private IWebElement DoNotHaveEverythingErrorMessage { get; set; }

        internal WhatYoullNeed DontHaveWhatINeed()
        {
            SelectNo();
            ClickContinue();
            return this;
        }

        internal RegisterAccount HaveWhatINeed()
        {
            SelectYes();
            ClickContinue();
            return new RegisterAccount(_driver);
        }

        internal string GetErrorMessage()
        {
            return GetMessage(DoNotHaveEverythingErrorMessage);
        }

        private void SelectYes()
        {
            CheckThisRadioButton(HaveEverything);
        }

        private void SelectNo()
        {
            CheckThisRadioButton(DoNotHaveEverything);
        }

        private void ClickContinue()
        {
            ClickThisElement(Continue);
        }

    }
}