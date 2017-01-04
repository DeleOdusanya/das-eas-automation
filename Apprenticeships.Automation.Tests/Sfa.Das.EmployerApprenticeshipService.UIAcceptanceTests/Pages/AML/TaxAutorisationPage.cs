using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using System.Threading;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class TaxAutorisationPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public TaxAutorisationPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }
         
        [FindsBy(How = How.Id, Using = "agree_and_continue")] private IWebElement ConnectToHmrcButton { get; set; }


        internal HmrcLogInPage ClickConnectToHmrcButton()00000000
        {
            ClickConnectToHmrcButton();
            return new HmrcLogInPage(_driver);
        }


        private void ClickConnectToHmrcButton()
        {
            Thread.Sleep(2000);
            ConnectToHmrcButton.WaitForElementIsVisible();
            ConnectToHmrcButton.Click(_driver);
        }

        
    }
}