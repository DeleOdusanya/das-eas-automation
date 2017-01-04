using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class AccountsCreationApprovalPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public AccountsCreationApprovalPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[1]/p/strong")] private IWebElement CompanyNameForAccount { get; set; }

        //public IWebElement CompanyNameForAccount
        //{
        //    get
        //    {
        //        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //        var CompanyNameForAccount = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("bold-large")));
        //        return CompanyNameForAccount;
        //    }
        //}
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
        public IWebElement ContinueButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var ContinueButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("continue")));
                return ContinueButton;
            }
        }
        public IWebElement SignAgreementBox
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var SignAgreementBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("userAuthorised")));
                return SignAgreementBox;
            }
        }
        public IWebElement SignAgreementBtn
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var SignAgreementBtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("signAgreement")));
                return SignAgreementBtn;
            }
        }

    }
}


