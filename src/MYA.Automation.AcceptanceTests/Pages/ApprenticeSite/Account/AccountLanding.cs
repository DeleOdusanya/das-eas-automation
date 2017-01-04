using Mya.Automation.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;

namespace Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Account
{
    public class AccountLanding : MyaBasePage
    {
        private readonly IWebDriver _driver;

        public AccountLanding(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }
    }
}