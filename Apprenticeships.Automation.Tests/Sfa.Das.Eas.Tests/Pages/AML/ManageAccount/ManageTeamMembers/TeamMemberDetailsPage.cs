using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.ManageAccount.ManageTeamMembers
{
    public class TeamMemberDetailsPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public YourTeamPage(IWebDriver webDdriver) : base(webDdriver)
        {
            _driver = webDdriver;
        }

        [FindsBy(How = How.XPath, Using = ".//a[contains (text(), \'Change\')]")] private IWebElement ChangeLink { get; set; }
        [FindsBy(How = How.Id, Using = "delete_user")] private IWebElement RemoveTeamMemberBtn { get; set; }

        internal ChangeRolePage ChangeUserRole()
        {
            ClickChangeLink();
            return new ChangeRolePage(_driver);
        }

        internal ChangeRolePage RemoveTeamMember()
        {
            ClickRemoveTeamMemberBtn();
            return new ChangeRolePage(_driver);
        }

        private void ClickChangeLink()
        {
            ClickThisElement(ClickChangeLink);
            
        }

        private void ClickRemoveTeamMemberBtn()
        {
            ClickThisElement(ClickRemoveTeamMemberBtn);
        }
    }
}
