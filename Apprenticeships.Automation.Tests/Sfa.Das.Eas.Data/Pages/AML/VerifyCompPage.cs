using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class VerifyCompPage : BasePage
    {
        public VerifyCompPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CompanyName
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(10));
                var CompanyName = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("inline")));
                return CompanyName;
            }

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
    }
}
