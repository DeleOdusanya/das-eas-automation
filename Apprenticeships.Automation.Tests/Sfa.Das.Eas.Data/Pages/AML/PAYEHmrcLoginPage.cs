using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class PAYEHmrcLoginPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public PAYEHmrcLoginPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "userId")] private IWebElement UserNameTextBox;
        [FindsBy(How = How.Id, Using = "password")] private IWebElement PasswordTextBox;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[4]/input")] private IWebElement SignInButton;
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div[2]/article/form/fieldset/div/input")] private IWebElement GrantAuthorityButton;
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'accept\']")] private IWebElement YesContinueButton;

        internal PAYEHmrcLoginPage InvalidHmrcLogIn(string UserName, string Password)
        {
            InputCredentials(UserName, Password);
            ClickSignIn();
            return this;
        }

        internal PAYEHmrcLoginPage IncompleteHmrcLogin()
        {
            ClickSignIn();
            return this;
        }



        internal PAYEHmrcResponsePage PAYEValidHmrcLogin(string userName, string passWord)
        {
            InputCredentials(userName, passWord);
            ClickSignIn();
            return new PAYEHmrcResponsePage(_driver);
        }

        private void InputCredentials(string userName, string passWord)
        {
            InputUserName(userName);
            InputPassWord(passWord);
        }

        private void InputUserName(string userName)
        {
            UserNameTextBox.EnterText(_driver, userName);
        }

        private void InputPassWord(string passWord)
        {
            PasswordTextBox.EnterText(_driver, passWord);
        }

        private void ClickGrantAuthority()
        {
            GrantAuthorityButton.Click(_driver);
        }

        private void ClickYesContinueButton()
        {
            YesContinueButton.Click(_driver);
        }

        private void ClickSignIn()
        {
            SignInButton.Click(_driver);
        }
    }
}
