using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class YourTeamPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public YourTeamPage(IWebDriver webDdriver) : base(webDdriver)
        {
            _driver = webDdriver;
        }

        [FindsBy(How = How.Id, Using = "addNewUser")] private IWebElement InviteNewMemberBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[3]/div/table/tbody/tr/td[4]/a")] private IWebElement ViewLink { get; set; }

        internal CreateInvitationsPage InviteNewMember()
        {
            ClickInviteNewMemberBtn();
            return new CreateInvitationsPage(_driver);
        }

        internal TeamMemberDetailsPage ClickView()
        {
            ClickViewLink();
            return new TeamMemberDetailsPage(_driver);
        }

        private void ClickAddNewMemberBtn()
        {
            Thread.Sleep(2000);
            addNewUserBtn.WaitForElementIsVisible();
            addNewUserBtn.Click(_driver);
        }

        private void ClickViewLink()
        {
            Thread.Sleep(2000);
            ViewLink.WaitForElementIsVisible();
            ViewLink.Click(_driver);
        }
    }
}
