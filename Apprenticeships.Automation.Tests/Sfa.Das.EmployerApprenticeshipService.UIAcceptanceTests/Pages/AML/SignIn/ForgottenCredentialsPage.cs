using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.SignIn
{
    public class ForgottenCredentialsPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public ForgottenCredentialsPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "Email")] private IWebElement Email { get; set; }
        [FindsBy(How = How.Id, Using = "forgottenpassword-button")] private IWebElement GetResetCodeBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter a valid email address\')]")] private IWebElement EnterValidEmailAddressErrorInBox { get; set; }
        [FindsBy(How = How.Id, Using = "error-email")] private IWebElement EnterValidEmailAddressField { get; set; }

        internal ForgottenCredentialsPage SubmitInvalidEmail(string invalidEmail)
        {

            SubmitInvalidEmail(invalidEmail);
            SubmitForm();
            return this;
        }

        internal SelectEmployer SubmitValidEmail(string validCode)
        {
            SubmitValidEmail(validCode);
            SubmitForm();
            return new SelectEmployer(_driver);
        }

        private void SubmitForm()
        {
            ClickThisElement(GetResetCodeBtn);
        }

        internal string GetEnterValidEmailAddressErrorInBox()
        {

            EnterValidEmailAddressErrorInBox.WaitForElementIsVisible();
            return EnterValidEmailAddressErrorInBox.GetTextWhenShown();
        }

        internal string GetEnterValidEmailAddressField()
        {

            EnterValidEmailAddressField.WaitForElementIsVisible();
            return EnterValidEmailAddressField.GetTextWhenShown();
        }
    }
}
