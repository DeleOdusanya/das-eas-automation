using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML.SignIn;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.Landing
{
    public class LandingPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public LandingPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div/div/form/div[1]/fieldset/label[1]")] private IWebElement UsedServiceBeforeRadioBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id=\'content\']/div/div/form/div[1]/fieldset/label[2]")] private IWebElement NotUsedServiceBeforeRadioBtn { get; set; }
        [FindsBy(How = How.Id, Using = "submit-button")] private IWebElement Continue { get; set; }

        internal SignInPage ClickUsedServiceBefore()
        {
            ClickUsedServiceBefore();
            return new SignInPage(_driver);
        }

        internal LandingPage ClickNotUsedServiceBefore()
        {
            ClickNotUsedServiceBefore();
            return this;
        }

        #region Functions

        private void ClickUsedThisServiceBeforeRadioBtn()
        {
           CheckThisRadioButton(UsedServiceBeforeRadioBtn);
           ClickThisElement(Continue);
        }

        private void ClickNotUsedServiceBeforeRadioBtn()
        {
            CheckThisRadioButton(NotUsedServiceBeforeRadioBtn);
            ClickThisElement(Continue);
        }

        #endregion

    }
}

