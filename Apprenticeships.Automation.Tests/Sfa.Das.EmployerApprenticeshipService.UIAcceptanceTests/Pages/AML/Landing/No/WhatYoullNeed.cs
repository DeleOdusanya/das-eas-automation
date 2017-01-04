using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using System.Threading;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.Landing
{
    internal class WhatYoullNeed : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public WhatYoullNeed(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'what-you-need-form\']/fieldset/label[1]")] private IWebElement YesIHaveEverythingINeedRadioBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'what-you-need-form\']/fieldset/label[2]")] private IWebElement NoIDontHaveEverythingINeedRadioBtn { get; set; }
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement WhatYouNeedContinueBtn { get; set; }
       

       

        internal CreateAccount.CreateAccount ClickYesIHaveEverythingINeed()
        {
            ClickYesIHaveEverythingINeed();
            return new CreateAccount.CreateAccount(_driver);
        }

        internal WhatYoullNeed ClickNoIDontHaveEverythingINeed()
        {
            ClickNoIDontHaveEverythingINeed();
            return this;
        }

        #region

        private void ClickYesIHaveEverythingINeedRadioBtn()
        {
            CheckThisRadioButton(YesIHaveEverythingINeedRadioBtn);
            ClickWhatYouNeedContinueBtn();
        }

        private void ClickNoIDontHaveEverythingINeedRadioBtn()
        {
            CheckThisRadioButton(NoIDontHaveEverythingINeedRadioBtn);
            ClickWhatYouNeedContinueBtn();
        }

        private void ClickWhatYouNeedContinueBtn()
        {
            ClickThisElement(WhatYouNeedContinueBtn);
        }

        #endregion
    }
}
