using Mya.Automation.Tests.Tests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;

namespace Mya.Automation.Tests.Pages.ApprenticeSite.Homepage.No.CreateAccount
{
    public class RegisterAccount : MyaBasePage
    {
        private readonly IWebDriver _driver;

        public RegisterAccount(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        #region Page Elements

        [FindsBy(How = How.Id, Using = "error-summary-heading-example-1")] private IWebElement ErrorBox { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")] private IWebElement FirstName { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter first name\')]")] private IWebElement FirstNameErrorInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter first name\')]")] private IWebElement FirstNameErrorField { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")] private IWebElement LastName { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter last name\')]")]  private IWebElement LastNameErrorInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter last name\')]")] private IWebElement LastNameErrorField { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]  private IWebElement Email { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter a valid email address\')]")] private IWebElement EmailErrorInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter a valid email address\')]")] private IWebElement EmailErrorField { get; set; }

        [FindsBy(How = How.Id, Using = "Password")] private IWebElement Password { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter password\')]")] private IWebElement PasswordErrorInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Enter your password\')]")] private IWebElement PasswordErrorField { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmPassword")] private IWebElement PasswordConfirm { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Re-type password\')]")] private IWebElement PasswordCnfErrorInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Re-type password\')]")] private IWebElement PasswordCnfErrorField { get; set; }

     
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'terms of use.\')]")] private IWebElement EmailInUseErrorInBox { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'terms of use.\')]")] private IWebElement EmailInUseErrorInField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/form/button")] private IWebElement SetMeUp { get; set; }
        [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'Email address already registered\')]")] private IWebElement EmailAlreadyRegisteredErrorField { get; set; }

        #endregion

        internal RegisterAccount SubmitInvalidForm(string firstName, string lastName, string email, string passWord)
        {
            CompleteForm(firstName, lastName, email, passWord);
            SubmitForm();
            return this;
        }

        internal ConfirmYourIdentityPage SubmitValidForm(string firstName, string lastName, string email, string passWord)
        {
            CompleteForm(firstName, lastName, email, passWord);
            SubmitForm();
            return new ConfirmYourIdentityPage();
        }

        internal RegisterAccount SubmitIncompleteForm()
        {
            SubmitForm();
            return this;
        }

        private void CompleteForm(string firstName, string lastName, string email, string passWord)
        {
            FirstName.EnterText(_driver, firstName);
            LastName.EnterText(_driver, lastName);
            Email.EnterText(_driver, email);
            Password.EnterText(_driver, passWord);
            PasswordConfirm.EnterText(_driver, passWord);
        }

        private void SubmitForm()
        {
            SetMeUp.WaitForElementIsVisible();
            SetMeUp.Click(_driver);
        }

        internal bool IsTheErrorBoxDisplayed()
        {
            return ErrorBox.Displayed;
        }

        #region Error fields

        internal string GetFirstNameRequiredField()
        {
            FirstNameErrorField.WaitForElementIsVisible();
            return FirstNameErrorField.GetTextWhenShown();
        }

        internal string GetFirstNameRequiredInBox()
        {
            FirstNameErrorInBox.WaitForElementIsVisible();
            return FirstNameErrorInBox.GetTextWhenShown();
        }

        internal string GetLastNameRequiredField()
        {
            LastNameErrorField.WaitForElementIsVisible();
            return LastNameErrorField.GetTextWhenShown();
        }

        internal string GetLastNameRequiredInBox()
        {
            LastNameErrorInBox.WaitForElementIsVisible();
            return LastNameErrorInBox.GetTextWhenShown();
        }

        internal string GetEmailRequiredField()
        {
            EmailErrorField.WaitForElementIsVisible();
            return EmailErrorField.GetTextWhenShown();
        }

        internal string GetEmailRequiredInBox()
        {
            EmailErrorInBox.WaitForElementIsVisible();
            return EmailErrorInBox.GetTextWhenShown();
        }

        internal string GetPasswordRequiredField()
        {
            PasswordErrorField.WaitForElementIsVisible();
            return PasswordErrorField.GetTextWhenShown();
        }

        internal string GetPasswordRequiredInBox()
        {
            PasswordErrorInBox.WaitForElementIsVisible();
            return PasswordErrorInBox.GetTextWhenShown();
        }

        internal string GetPasswordRetryRequiredField()
        {
            PasswordCnfErrorField.WaitForElementIsVisible();
            return PasswordCnfErrorField.GetTextWhenShown();
        }

        internal string GetPasswordRetryRequiredInBox()
        {
            PasswordCnfErrorInBox.WaitForElementIsVisible();
            return PasswordCnfErrorInBox.GetTextWhenShown();
        }

        internal string GetEmailInUseErrorInBox()
        {
            EmailInUseErrorInBox.WaitForElementIsVisible();
            return EmailInUseErrorInBox.GetTextWhenShown();
        }

        internal string GetEmailInUseErrorInField()
        {
            EmailInUseErrorInField.WaitForElementIsVisible();
            return EmailInUseErrorInField.GetTextWhenShown();
        }

        #endregion

    }
}
