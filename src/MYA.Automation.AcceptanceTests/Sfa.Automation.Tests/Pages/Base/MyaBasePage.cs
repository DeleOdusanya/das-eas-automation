using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Constants;
using Sfa.Automation.Framework.Extensions;
using Sfa.Automation.Framework.Selenium;

namespace Mya.Automation.Tests.Tests.Pages.Base
{
    public class MyaBasePage : BasePage
    {
        private readonly IWebDriver _driver;

        protected MyaBasePage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        protected void WaitForLoadingToFinish()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(TimeoutInSeconds.DefaultTimeout));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(driver => !driver.FindElement(By.Id("Loading")).Displayed);
        }

        internal bool IsCorrectPageDisplayed(string url)
        {
            return _driver.Url.TrimEnd('#').EndsWith(url);
        }

        #region Common Methods

        protected void ClickThisElement(IWebElement element)
        {
            element.WaitForElementIsVisible();
            element.Click(_driver);
        }

        protected void EnterTextInThisElement(IWebElement element, string textToEnter)
        {
            element.WaitForElementIsVisible();
            element.EnterText(_driver, textToEnter);
        }

        protected void CheckThisRadioButton(IWebElement element)
        {
            element.WaitForElementIsVisible();
            element.SelectCheckBox(_driver);
        }

        protected string GetMessage(IWebElement element)
        {
            element.WaitForElementIsVisible();
            return element.GetTextWhenShown();
        }

        #endregion

    }
}
