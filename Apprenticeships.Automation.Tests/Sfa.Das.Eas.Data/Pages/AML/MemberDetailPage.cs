using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class MemberDetailPage : BasePage
    {
        public MemberDetailPage(IWebDriver driver) : base(driver)
        {
        }
         public IWebElement CancelInvitationButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var CancelInvitationButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#content > div > div > form:nth-child(7) > button")));
                return CancelInvitationButton;
            }
        }
    }
}
