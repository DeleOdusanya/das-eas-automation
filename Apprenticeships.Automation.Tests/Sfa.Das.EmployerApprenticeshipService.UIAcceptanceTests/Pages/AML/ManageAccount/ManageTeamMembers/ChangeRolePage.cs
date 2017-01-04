using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sfa.Automation.Framework.Extensions;
using Sfa.Das.EAS.AcceptanceTests.Pages.Base;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.AML.ManageAccount.ManageTeamMembers
{
    public class ChangeRolePage : SfaBasePage
    private readonly IWebDriver _driver;

    public YourTeamPage(IWebDriver webDdriver) : base(webDdriver)
        {
        _driver = webDdriver;
    }
}
