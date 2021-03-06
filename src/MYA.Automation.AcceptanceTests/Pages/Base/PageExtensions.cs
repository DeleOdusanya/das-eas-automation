﻿using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Account;
using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage;
using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.No.CreateAccount;
using Mya.Automation.AcceptanceTests.Pages.ApprenticeSite.Homepage.Yes;
using OpenQA.Selenium;

namespace Mya.Automation.AcceptanceTests.Pages.Base
{
    /// <summary>
    /// The pages returned below are all pages that are the landing pages for the web sites.
    /// </summary>
    internal static class PageExtensions
    {
        internal static Landing Landing(this IWebDriver webDriver)
        {
            return new Landing(webDriver);
        }

        internal static SignIn SignIn(this IWebDriver webDriver)
        {
            return new SignIn(webDriver);
        }

        internal static RegisterAccount CreateAnAccount(this IWebDriver webDriver)
        {
            return new RegisterAccount(webDriver);
        }

        internal static AccountLanding AccountLanding(this IWebDriver webDriver)
        {
            return new AccountLanding(webDriver);
        }
    }
}
