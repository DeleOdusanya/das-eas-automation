using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;
using SFA.Automation.Framework.Extensions;
using SFA.Automation.Framework.Selenium;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML;


namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML
{
    public class CreateInvitationsPage : SfaBasePage
    {
        private readonly IWebDriver _driver;

        public CreateInvitationsPage(IWebDriver webDdriver) : base(webDdriver)
        {
            _driver = webDdriver;
        }

        [FindsBy(How = How.Id, Using = "Name")] private IWebElement MemberNameField;
        [FindsBy(How = How.Id, Using = "Email")] private IWebElement MemberEmailField;
        [FindsBy(How = How.Id, Using = "radio1")] private IWebElement ViewButCantChangeRadioBtn;
        [FindsBy(How = How.Id, Using = "radio1")] private IWebElement AddApprenticeAndViewRadioBtn;
        [FindsBy(How = How.Id, Using = "radio1")] private IWebElement InviteSignAddApprenticeRadioBtn;

        internal CreateInvitationsPage ViewButCantChangeRadioBtn()
        {
            ClickViewButCantChangeRadioBtn();
            return new CreateInvitationsPage(_driver);
        }

    }
}
