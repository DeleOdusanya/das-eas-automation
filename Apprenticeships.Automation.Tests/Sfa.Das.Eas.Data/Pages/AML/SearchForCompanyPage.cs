using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class SearchForCompanyPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public SearchForCompanyPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "EmployerRef")] private IWebElement CompanyHouseTextBox;
        [FindsBy(How = How.Id, Using = "submit")] private IWebElement ContinueButton;
        [FindsBy(How = How.Id, Using = "agree_and_continue")] private IWebElement ConnectToHmrcButton;

        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter a valid Companies House number\')]")] private IWebElement CompaniesHousenumberErrorInBox;
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'error-message-companies-house\']")] private IWebElement CompaniesHousenumberdErrorField;


        internal SearchForCompanyPage InvalidSearch(string invalidCompanyHouseNo)
        {
            InputCompanyHouseNo(invalidCompanyHouseNo);
            ClickContinue();
            return this;
        }

        internal SearchForCompanyPage IncompleteSearch()
        {
            ClickContinue();
            return this;
        }

        internal HmrcLogInPage ValidSearch(string validCompanyNo)
        {
            InputCompanyHouseNo(validCompanyNo);
            ClickContinue();
            return new HmrcLogInPage(_driver);
        }

        //is this correct? What page do you actually get taken to?
        internal HmrcLogInPage ConnectToHmrc(string validCompanyNo)
        {
            ClickConnectToHmrcContinue();
            return new HmrcLogInPage(_driver);
        }


        private void InputCompanyHouseNo(string companyHouseNo)
        {
            CompanyHouseTextBox.EnterText(_driver, companyHouseNo);
        }
        private void ClickContinue()
        {
            ContinueButton.Click(_driver);
        }

        private void ClickConnectToHmrcContinue()
        {
            ConnectToHmrcButton.Click(_driver);
        }

        #region Error fields

        internal string GetCompaniesHousenumberErrorInBox()
        {
            CompaniesHousenumberErrorInBox.WaitForElementIsVisible();
            return CompaniesHousenumberErrorInBox.GetTextWhenShown();
        }

        internal string GetCompaniesHousenumberdErrorField()
        {
            CompaniesHousenumberdErrorField.WaitForElementIsVisible();
            return CompaniesHousenumberdErrorField.GetTextWhenShown();
        }


        #endregion
    }
}
