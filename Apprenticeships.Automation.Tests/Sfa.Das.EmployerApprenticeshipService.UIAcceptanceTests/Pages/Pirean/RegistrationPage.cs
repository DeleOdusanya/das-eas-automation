using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.Pirean
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement FirstNameBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var FirstNameBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("first-name-2")));
                return FirstNameBox;
            }
        }
        public IWebElement LastNameBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var LastNameBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("last-name-2")));
                return LastNameBox;
            }
        }
        public IWebElement EmailBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var EmailBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));
                return EmailBox;
            }
        }
        public IWebElement PasswordBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var PasswordBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
                return PasswordBox;
            }
        }
        public IWebElement PasswordConfirmBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var PasswordConfirmBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password-confirm")));
                return PasswordConfirmBox;
            }
        }
        public IWebElement AgreeCheckBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AgreeCheckBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("marketing-opt-out")));
                return AgreeCheckBox;
            }
        }
        public IWebElement CreateAnAccountButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CreateAnAccount = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("button")));
                return CreateAnAccount;
            }
        }
    }
}
