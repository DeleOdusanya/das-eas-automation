using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using System;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.Pirean
{
    public class GettingStarted : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public GettingStarted(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement SignInBtn;

        internal SignIn ClickSignIn()
        {
            SignInBtn.Click(_driver);
            return new SignIn(_driver);
        }
    }
}

