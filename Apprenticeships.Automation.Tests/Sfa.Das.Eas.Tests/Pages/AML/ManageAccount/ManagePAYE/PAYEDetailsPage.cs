using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class PAYEDetailsPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public PAYEDetailsPage(IWebDriver webDdriver) : base(webDdriver)
        {
            _driver = webDdriver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[2]/div[2]/a")] private IWebElement RemovePayeBtn { get; set; }
        // [FindsBy(How = How.XPath, Using = ".//span[contains (text(), \'remove scheme\')]")] private IWebElement RemoveSchemeYesContinue{ get; set; }

        internal RemoveSchemeResponsePage ClickRemoveSchemeBtn()
        {
            ClickRemoveSchemeBtn();
            return new RemoveSchemeResponsePage(_driver);
        }

        //internal PAYESchemesPage SelectRemoveSchemeYesContinue()
        //{
        //    SelectRemoveSchemeYesContinue();
        //    return new PAYESchemesPage(_driver);
        //}
    }
}
