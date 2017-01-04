sing System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class InformsPage : BasePage
    {
        public InformsPage(IWebDriver driver) : base(driver)
        {
        }
            public IWebElement StartButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var StartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("start")));
                return StartButton;
            }
        }
    }
    
}
