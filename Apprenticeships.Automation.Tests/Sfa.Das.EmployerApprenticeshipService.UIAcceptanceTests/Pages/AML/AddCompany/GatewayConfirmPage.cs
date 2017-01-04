using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class GatewayConfirmationPage : BasePage
    {
        public GatewayConfirmationPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement ContinueButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ContinueButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("continue")));
                return ContinueButton;
            }
        }

        public IWebElement YesOption
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var YesOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("radio1")));
                return YesOption;
            }
        }
        public IWebElement NoOption
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var NoOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("radio2")));
                return NoOption;
            }
        }
    }
}
