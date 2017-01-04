using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class TransactionsPage : BasePage
    {
        public TransactionsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TransactionsTable
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var TransactionsTable = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("responsive-tr")));
                return TransactionsTable;
            }
        }
        public IWebElement AnyViewLink
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var AnyViewLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#transactions > div.responsive-tbody > div:nth-child(1) > div:nth-child(6) > div:nth-child(1) > a")));
                return AnyViewLink;
            }
        }
    }
}
