using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class PAYESchemesPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public PAYESchemesPage(IWebDriver webDdriver) : base(webDdriver)
        {
            _driver = webDdriver;
        }

        [FindsBy(How = How.Id, Using = "addNewPaye")] private IWebElement AddNewPayeeBtn { get; set; }
        [FindsBy(How = How.LinkText, Using = "Details")] private IWebElement DetailsLink { get; set; }
        [FindsBy(How = How.Id, Using = "agree_and_continue")] private IWebElement AddPAYEAgreeAndContinueBtn { get; set; }

        internal PAYESchemesPage AddNewPayee()
        {
            ClickAddNewPayeeBtn();
            return this;
        }

        internal PAYEHmrcLoginPage AddPAYEAgreeAndContinue()
        {
            ClickAddPAYEAgreeAndContinueBtn();
            return new PAYEHmrcLoginPage(_driver);
        }
                
        internal PAYEDetailsPage ClickDetailsLink()
        {
            ClickDetailsLink();
            return new PAYEDetailsPage(_driver);
        }

        private void ClickAddNewPayeeBtn()
        {
            Thread.Sleep(2000);
            AddNewPayeeBtn.WaitForElementIsVisible();
            AddNewPayeeBtn.Click(_driver);
        }

        private void ClickAddPAYEAgreeAndContinueBtn()
        {
            Thread.Sleep(2000);
            AddPAYEAgreeAndContinueBtn.WaitForElementIsVisible();
            AddPAYEAgreeAndContinueBtn.Click(_driver);
        }
     }
}
