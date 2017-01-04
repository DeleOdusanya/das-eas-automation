using System;
using System.Drawing.Imaging;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Sfa.Automation.Framework.Enums;
using Sfa.Automation.Framework.Selenium;

namespace Sfa.Das.EAS.Tests.Tests.Base
{
    [TestFixture]
    public class AccessibilityTests : TestBase
    {
        [SetUp]
        public void SetUp() {  }

        [TestCase(WebDriver.Firefox)]
        public void AccessibilityTest()
        {
            var profile = new FirefoxProfile();
            profile.AddExtension("wavetoolbar1_1_8_en.xpi");
            var driver = new FirefoxDriver(profile);

            driver.Navigate().GoToUrl("http://apple.com");

            var b = driver.FindElement(By.TagName("body"));
            b.SendKeys(Keys.Alt + "T");
            b.SendKeys(Keys.ArrowDown);
            b.SendKeys(Keys.ArrowDown);
            b.SendKeys(Keys.ArrowDown);
            b.SendKeys(Keys.ArrowDown);
            b.SendKeys(Keys.ArrowRight);
            b.SendKeys(Keys.Enter);

            var waveTips = driver.FindElements(By.ClassName("wave4tip"));
            if (waveTips.Count != 0) return;
            foreach (var waveTip in waveTips)
            {
                if (!waveTip.GetAttribute("alt").StartsWith("ERROR:")) continue;
                var fileName = $"WAVE{DateTime.Now.ToString("HHmmss")}.png";
                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                screenShot.SaveAsFile(fileName, ImageFormat.Png);
                Assert.Fail("WAVE errors were found on the page. Please see screenshot for details");
            }
        }

        [TearDown]
        public void TearDown() { }
    }
}