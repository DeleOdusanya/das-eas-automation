using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.CreateAccount
{
    public class ConfirmYourIdentityPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public ConfirmYourIdentityPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "AccessCode")] private IWebElement EnterCode { get; set; }
        [FindsBy(How = How.ClassName, Using = "button")] private IWebElement ContinueBtn { get; set; }
        [FindsBy(How = How.Id, Using = "invalidMessage")] private IWebElement InvalidCodeErrorField { get; set; }
        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Enter a valid code\')]")] private IWebElement InvalidCodeErrorInBox { get; set; }

        internal ConfirmYourIdentityPage SubmitInvalidCode(string invalidCode)
        {
            
            SubmitInvalidCode(invalidCode);
            SubmitForm();
            return this;
        }

        internal SelectEmployer SubmitValidCode(string validCode)
        {
            SubmitValidCode(validCode);
            SubmitForm();
            return new SelectEmployer(_driver);
        }

        private void SubmitForm()
        {
           ClickThisElement(ContinueBtn);
        }

        internal string GetInvalidCodeErrorField()
        {
            
            InvalidCodeErrorField.WaitForElementIsVisible();
            return InvalidCodeErrorField.GetTextWhenShown();
        }

        internal string GetInvalidCodeErrorInBox()
        {

            InvalidCodeErrorInBox.WaitForElementIsVisible();
            return InvalidCodeErrorInBox.GetTextWhenShown();
        }
    }
}