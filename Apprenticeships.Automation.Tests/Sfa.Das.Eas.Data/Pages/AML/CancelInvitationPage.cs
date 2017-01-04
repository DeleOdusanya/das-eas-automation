using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class CancelInvitationsPage : BasePage
    {
        public CancelInvitationsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement YesRadioOption
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var YesRadioOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("radio2")));
                return YesRadioOption;
            }
        }
        public IWebElement NoRadioOption
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var NoRadioOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("radio1")));
                return NoRadioOption;
            }
        }
        public IWebElement ContinueButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ContinueButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("button")));
                return ContinueButton;
            }
        }
    }
}
