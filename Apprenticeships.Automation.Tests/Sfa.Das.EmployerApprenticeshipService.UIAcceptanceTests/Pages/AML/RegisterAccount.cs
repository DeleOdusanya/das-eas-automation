using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.Pirean
{
    public class RegisterAccount : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public RegisterAccount(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[3]/div/form/h1")] private IWebElement ControlPageId;
        [FindsBy(How = How.Id, Using = "error-summary-heading-example-1")] private IWebElement ErrorBox;

        [FindsBy(How = How.Id, Using = "code")] private IWebElement EnterCodeField;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[2]/div/div[1]/div/ul/li/a")] private IWebElement EnterCodeErrorInBox;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[3]/div/form/div[1]/div/div/ul/li/span")] private IWebElement FirstNameErrorField;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div[3]/div/form/div[2]/button")] private IWebElement ContinueButton;

        internal SignIn ClickSignInWithNoCode()
        {
            ContinueButton.WaitForElementIsVisible();
            ContinueButton.Click(_driver);
            return new SignIn(_driver);
        }

        internal bool IsThisTheCorrectPage()
        {
            return ControlPageId.Displayed;
        }

        internal bool IsErrorBoxDisplayed()
        {
            return ErrorBox.Displayed;
        }
    }
}
