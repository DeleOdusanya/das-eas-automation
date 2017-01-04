using OpenQA.Selenium;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML;
using Sfa.Das.EAS.AcceptanceTests.Pages.AML.Landing;
using Sfa.Das.EAS.AcceptanceTests.Pages.Pirean;

namespace Sfa.Das.EAS.AcceptanceTests.Pages.Base
{
    /// <summary>
    /// The pages returned below are all pages that are the landing pages for the web sites.
    /// </summary>
    internal static class PageExtensions
    {
        internal static GettingStarted GetStarted(this IWebDriver webDriver)
        {
            return  new GettingStarted(webDriver);
        }

        internal static SignIn SignIn(this IWebDriver webDriver)
        {
            return new SignIn(webDriver);
        }

        internal static CreateAccount CreateAnAccount(this IWebDriver webDriver)
        {
            return new CreateAccount(webDriver);
        }

        internal static AccountLanding AccountLanding(this IWebDriver webDriver)
        {
            return new AccountLanding(webDriver);
        }

        internal static AccountHomePage AccountHomePage(this IWebDriver webDriver)
        {
            return new AccountHomePage(webDriver);
        }

        internal static CancelInvitationsPage CancelInvitationsPage(this IWebDriver webDriver)
        {
            return new CancelInvitationsPage(webDriver);
        }

       //internal static CreateInvitationsPage CreateInvitationsPage(this IWebDriver webDriver)
       // {
       //     return new CreateInvitationsPage(webDriver);
       // }

        internal static HmrcResponsePage HMRCresponsePage(this IWebDriver webDriver)
        {
            return new HmrcResponsePage(webDriver);
        }

        internal static PAYEHmrcResponsePage PAYEHMRCresponsePage(this IWebDriver webDriver)
        {
            return new PAYEHmrcResponsePage(webDriver);
        }

        internal static HmrcLogInPage HMRCLogInPage(this IWebDriver webDriver)
        {
            return new HmrcLogInPage(webDriver);
        }

        internal static PAYEHmrcLoginPage PAYEHMRCLogInPage(this IWebDriver webDriver)
        {
            return new PAYEHmrcLoginPage(webDriver);
        }

        internal static InformsPage InformsPage(this IWebDriver webDriver)
        {
            return new InformsPage(webDriver);
        }

        //internal static MemberDetailPage MemberDetailPage(this IWebDriver webDriver)
        //{
        //    return new MemberDetailPage(webDriver);
        //}

        internal static PAYESchemesPage PAYESchemesPage(this IWebDriver webDriver)
        {
            return new PAYESchemesPage(webDriver);
        }

        internal static SearchForCompanyPage SearchForCompanyPage(this IWebDriver webDriver)
        {
            return new SearchForCompanyPage(webDriver);
        }

        internal static ServicesLandingPage ServicesLandingPage(this IWebDriver webDriver)
        {
            return new ServicesLandingPage(webDriver);
        }

        //internal static TeamsViewPage TeamsViewPage(this IWebDriver webDriver)
        //{
        //    return new TeamsViewPage(webDriver);
        //}

        internal static TransactionsPage TransactionsPage(this IWebDriver webDriver)
        {
            return new TransactionsPage(webDriver);
        }

        internal static VerifyCompPage VerifyCompPage(this IWebDriver webDriver)
        {
            return new VerifyCompPage(webDriver);
        }

        internal static AccountsCreationApprovalPage AccountsCreationApprovalPage(this IWebDriver webDriver)
        {
            return new AccountsCreationApprovalPage(webDriver);
        }

        internal static Homepage Homepage(this IWebDriver webDriver)
        {
            return new Homepage(webDriver);
        }

        internal static LandingPage LandingPage(this IWebDriver webDriver)
        {
            return new LandingPage(webDriver);
        }

        internal static PAYEDetailsPage PAYEDetailsPage(this IWebDriver webDriver)
        {
            return new PAYEDetailsPage(webDriver);
        }

        internal static RemoveSchemeResponsePage RemoveSchemeResponsePage(this IWebDriver webDriver)
        {
            return new RemoveSchemeResponsePage(webDriver);
        }

        //internal static TaxAutorisationPage TaxAutorisationPage(this IWebDriver webDriver)
        //{
        //    return new TaxAutorisationPage(webDriver);
        //}
    }
}
