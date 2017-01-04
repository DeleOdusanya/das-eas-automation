using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Account;
using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.No.CreateAccount;
using Mya.Automation.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;

namespace Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.Yes
{
    public class SignIn : MyaBasePage
    {
        private readonly IWebDriver _driver;

        public SignIn(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"EmailAddress\"]")] private IWebElement EmailAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Password\"]")] private IWebElement Password { get; set; }
        [FindsBy(How = How.ClassName, Using = "button")] private IWebElement LoginBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'create an account\')]")] private IWebElement CreateAccLink { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Forgotten your password\')]")] private IWebElement ForgottenPasswordLink { get; set; }

        [FindsBy(How = How.Id, Using = "first-name-2")] private IWebElement FirstName { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter a valid email address\')]")] private IWebElement EmailAddressErrorFieldInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter a valid email address\')]")] private IWebElement EmailAddresErrorField { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter password\')]")] private IWebElement PasswordErrorFieldInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter password\')]")] private IWebElement PasswordErrorField { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter a valid email address\')]")]  private IWebElement InvalidCredentialsErrorField { get; set; }


        internal AccountLanding ValidLogin(string userName, string passWord)
        {
            EnterCredentials(userName, passWord);
            return new AccountLanding(_driver);
        }

        internal SignIn InvalidLogin(string invalidUser, string invalidPassword)
        {
            EnterCredentials(invalidUser, invalidPassword);
            return this;
        }

        internal SignIn IncompleteLogin()
        {
            ClickLoginButton();
            return this;
        }

        internal RegisterAccount ClickCreateAccount()
        {
            ClickCreateAccountButton();
            return new RegisterAccount(_driver);
        }

        //internal ForgottenCredentialsPage ClickForgottenYourPassword()
        //{
        //    ClickForgottenYourPasswordLink();
        //    return new ForgottenCredentialsPage(_driver);
        //}

        #region Functions

        private void EnterCredentials(string userName, string passWord)
        {
            EnterUserName(userName);
            EnterPassWord(passWord);
            ClickLoginButton();
        }

        private void EnterUserName(string userName)
        {
            EnterTextInThisElement(EmailAddress, userName);
        }

        private void EnterPassWord(string passWord)
        {
            Password.WaitForElementIsVisible();
            Password.EnterText(_driver, passWord);
        }

        private void ClickLoginButton()
        {
            ClickThisElement(LoginBtn);
        }

        private void ClickCreateAccountButton()
        {
            CreateAccLink.WaitForElementIsVisible();
            CreateAccLink.Click(_driver);
        }

        private void ClickForgottenYourPasswordLink()
        {
            ClickThisElement(ForgottenPasswordLink);
        }
        #endregion

        #region Error fields

        internal string GetEmailAddressRequiredField()
        {
            EmailAddresErrorField.WaitForElementIsVisible();
            return EmailAddresErrorField.GetTextWhenShown();
        }

        internal string GetPasswordRequiredField()
        {
            PasswordErrorField.WaitForElementIsVisible();
            return PasswordErrorField.GetTextWhenShown();
        }

        internal string GetEmailAddressRequiredFieldInbox()
        {
            EmailAddressErrorFieldInBox.WaitForElementIsVisible();
            return EmailAddressErrorFieldInBox.GetTextWhenShown();
        }

        internal string GetPasswordRequiredFieldInbox()
        {
            PasswordErrorFieldInBox.WaitForElementIsVisible();
            return PasswordErrorFieldInBox.GetTextWhenShown();
        }

        internal string GetInvalidCredentialsErrorField()
        {
            InvalidCredentialsErrorField.WaitForElementIsVisible();
            return InvalidCredentialsErrorField.GetTextWhenShown();
        }
        #endregion
    }
}

