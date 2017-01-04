using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class Homepage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public Homepage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[3]/div/form/h1")] private IWebElement ControlPageId;

        [FindsBy(How = How.Id, Using = "used-service-before")] private IWebElement UsedServiceBefore { get; set; }
        [FindsBy(How = How.Id, Using = "not-used-service-before")] private IWebElement NotUsedServiceBefore;
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement Continue;

        [FindsBy(How = How.Id, Using = "harything")] private IWebElement YesIHaveEverythingINeed;
        [FindsBy(How = How.Id, Using = "do-not-have-evve-eveerything")] private IWebElement NoIDontHaveEverythingINeed;
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement WhatYouNeedContinue;

        internal Homepage ClickUsedServiceBeforeRadioBtn()
        {
            ClickUsedServiceBefore();
            return new Homepage(_driver);
        }

        internal Homepage ClickNotUsedServiceBeforeRadioBtn()
        {
            ClickNotUsedServiceBefore();
            return new Homepage(_driver);
        }

        internal Homepage ClickContinueBtn()
        {
            ClickContinue();
            return new Homepage(_driver);
        }

        internal Homepage ClickYesIHaveEverythingINeedRadioBtn()
        {
            ClickYesIHaveEverythingINeed();
            return new Homepage(_driver);
        }

        internal Homepage ClickNoIDontHaveEverythingINeedRadioBtn()
        {
            ClickNotUsedServiceBefore();
            return new Homepage(_driver);
        }

        internal Homepage ClickWhatYouNeedContinueBtn()
        {
            ClickWhatYouNeedContinue();
            return new Homepage(_driver);
        }

        private void ClickUsedServiceBefore()
        {
            Thread.Sleep(2000);
            UsedServiceBefore.WaitForElementIsVisible();
            UsedServiceBefore.Click(_driver);
        }

        private void ClickNotUsedServiceBefore()
        {
            Thread.Sleep(2000);
            NotUsedServiceBefore.WaitForElementIsVisible();
            NotUsedServiceBefore.Click(_driver);
        }

        private void ClickContinue()
        {
            Thread.Sleep(2000);
            Continue.WaitForElementIsVisible();
            Continue.Click(_driver);
        }

        private void ClickYesIHaveEverythingINeed()
        {
            Thread.Sleep(2000);
            YesIHaveEverythingINeed.WaitForElementIsVisible();
            YesIHaveEverythingINeed.Click(_driver);
        }

        private void ClickNoIDontHaveEverythingINeed()
        {
            NoIDontHaveEverythingINeed.WaitForElementIsVisible();
            NoIDontHaveEverythingINeed.Click(_driver);
        }

        private void ClickWhatYouNeedContinue()
        {
            Thread.Sleep(2000);
            WhatYouNeedContinue.WaitForElementIsVisible();
            WhatYouNeedContinue.Click(_driver);
        }

        internal bool IsThisCorrectPage()
        {
            return ControlPageId.Displayed;
        }

    }
}

