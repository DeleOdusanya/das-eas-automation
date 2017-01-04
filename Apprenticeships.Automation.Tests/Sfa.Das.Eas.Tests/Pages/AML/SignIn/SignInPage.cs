using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML.ManageAccount;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.SignIn
{
    public class SignInPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public SignInPage(IWebDriver webDriver) : base(webDriver)
        {
           _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "Emailaddress")] private IWebElement UserName { get; set; } 
        [FindsBy(How = How.Id, Using = "Password")] private IWebElement Password { get; set; }
        [FindsBy(How = How.ClassName, Using = "button")] private IWebElement LoginBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'create an account\')]")] private IWebElement CreateAccLink { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Forgotten your password\')]")] private IWebElement ForgottenPasswordLink { get; set; }

        [FindsBy(How = How.Id, Using = "first-name-2")] private IWebElement FirstName { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div[2]/div/div/div/ul/li[1]/a")] private IWebElement EmailAddressErrorFieldInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div[3]/div/form/div[1]/div/ul/li/span")] private IWebElement EmailAddresErrorField { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div[2]/div/div/div/ul/li[2]/a")] private IWebElement PasswordErrorFieldInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter password\')]")] private IWebElement PasswordErrorField { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Invalid credentials\')]")] private IWebElement InvalidCredentialsErrorField { get; set; }


        internal AccountLanding ValidLogin(string userName, string passWord)
        {
            EnterCredentials(userName, passWord);
            return new AccountLanding(_driver);
        }

        internal SignInPage InvalidLogin(string invalidUser, string invalidPassword)
        {
            EnterCredentials(invalidUser, invalidPassword);
            return this;
        }

        internal SignInPage IncompleteLogin()
        {
            ClickLoginButton();
            return this;
        }

        internal CreateAccount.CreateAccount ClickCreateAccount()
        {
            ClickCreateAccountButton();
            return new CreateAccount.CreateAccount(_driver);
        }

        internal ForgottenCredentialsPage ClickForgottenYourPassword()
        {
            ClickForgottenYourPasswordLink();
            return new ForgottenCredentialsPage(_driver);
        }

        #region Functions

        private void EnterCredentials(string userName, string passWord)
        {
            EnterUserName(userName);
            EnterPassWord(passWord);
            ClickLoginButton();
        }

        private void EnterUserName(string userName)
        {
            EnterTextInThisElement(UserName, userName);
        }

        private void EnterPassWord(string PassWord)
        {
            Password.WaitForElementIsVisible();
            Password.EnterText(_driver, PassWord);
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

