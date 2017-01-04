using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Pages.Pirean;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.Landing
{
    public class LandingPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public LandingPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div/div/form/div[1]/fieldset/label[1]")] private IWebElement UsedServiceBefore { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div/div/form/div[1]/fieldset/label[2]")] private IWebElement NotUsedServiceBefore { get; set; }
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement Continue { get; set; }

        internal SignIn SelectUsedServiceBeforeButton()
        {
            ClickYesRadioButton();
            return new SignIn(_driver);
        }

        internal WhatYoullNeed SelectNeverUsedServiceButton()
        {
            ClickNoRadioButton();
            return new WhatYoullNeed();
        }

        #region Functions

        private void ClickYesRadioButton()
        {
            CheckThisRadioButton(UsedServiceBefore);
            ClickThisElement(Continue);
        }

        private void ClickNoRadioButton()
        {
            CheckThisRadioButton(NotUsedServiceBefore);
            ClickThisElement(Continue);
        }

        #endregion

    }
}

