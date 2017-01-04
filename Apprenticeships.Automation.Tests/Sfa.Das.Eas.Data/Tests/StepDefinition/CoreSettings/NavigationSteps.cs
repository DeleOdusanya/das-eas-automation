using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Sfa.Das.EmployerAprrenticeshipService.Pages;
using Sfa.Das.EmployerAprrenticeshipService.Pages.AML;
using System;
using System.Configuration;
using Sfa.Das.EAS.Tests.Pages.Pirean;

namespace Sfa.Das.EmployerAprrenticeshipService.UIAcceptanceTests.Steps.NavigationSteps
{
    public class CoreSteps
    {

        private IWebDriver Driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriver"].ToString());

        public string username = ConfigurationManager.AppSettings["PireanUsername"];
        public string password = ConfigurationManager.AppSettings["PireanPassword"];
        public string CompanyNumber = ConfigurationManager.AppSettings["CompanyNumber"];
        public string CompanyNameExpected = ConfigurationManager.AppSettings["CompanyNameExpected"];
        public string HMRCUsername = ConfigurationManager.AppSettings["HMRCUN"];
        public string HMRCPassword = ConfigurationManager.AppSettings["HMRCPW"];

        public void LoadStartPage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
        }
        public void LoadTempPage()
        {
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["tempUrl"]);
        }
        public void LoginPirean()
        {
            LoadStartPage();
            ClickLoginButton();
            LoginPage LoginPage = new LoginPage(Driver);
            LoginPage.UsernameBox.Clear();
            LoginPage.UsernameBox.SendKeys(username);
            LoginPage.PasswordBox.Clear();
            LoginPage.PasswordBox.SendKeys(password);
            LoginPage.LoginButton.Click();
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.Driver.FindElement(By.LinkText("Log out"));

        }
        public void CloseBrowser()
        {
            Driver.Quit();
        }
        public void CreateADasAccount()
        {
            LoginPirean();
            ClickCreateAccountButton();
            //ClickCheckStatement();
            //ClickStartButton();
            SearchForCompany();
            LoginHmrcCredentials();
            GrantAuthority();//empref restriction means this can only run once
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));//wait for company house to return
            VerifyCompany();
            AccountCreationApprovalPage accountcreationapprovalpage = new AccountCreationApprovalPage(Driver);
            accountcreationapprovalpage.SignAgreementBox.Click();
            accountcreationapprovalpage.SignAgreementBtn.Click();
            CheckAccountNameAdded();

            //ApproveAccountCreation();
            /*DenyAuthority();*/
            //DenyAccountCreation();
            //ConfirmGatewayCredentials();
            //Logout();
        }
        public void CreatePireanAccountSetFirstName(string firstname)
        {
            RegistrationPage pireanregisterpage = new RegistrationPage(Driver);
            pireanregisterpage.FirstNameBox.SendKeys(firstname);
        }
        public void CreatePireanAccountSetLastName(string lastname)
        {
            RegistrationPage pireanregisterpage = new RegistrationPage(Driver);
            pireanregisterpage.LastNameBox.SendKeys(lastname);
        }
        public void CreatePireanAccountSetEmail(string email)
        {
            RegistrationPage pireanregisterpage = new RegistrationPage(Driver);
            pireanregisterpage.EmailBox.SendKeys(email);

        }
        public void CreatePireanAccountSetPassword(string password)
        {
            RegistrationPage pireanregisterpage = new RegistrationPage(Driver);
            pireanregisterpage.PasswordBox.SendKeys(password);
            pireanregisterpage.PasswordConfirmBox.SendKeys(password);
        }
        public void AckonowledgeandCreatePireanAccount()
        {
            RegistrationPage pireanregisterpage = new RegistrationPage(Driver);
            pireanregisterpage.AgreeCheckBox.Click();
            pireanregisterpage.CreateAnAccountButton.Click();
            //TO DO
        }
        public void RegisterNewUser()
        {
            LoadStartPage();
            ClickLoginButton();
            LoginPage pireanloginpage = new LoginPage(Driver);
            pireanloginpage.CreateAccountLink.Click();
        }
        public void ClickCreateAccountButton()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.AddAccountButton.Click();
        }
        public void ClickLoginButton()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.SigninButton.Click();
        }
        public void ClickStartButton()
        {
            InformPage informpage = new InformPage(Driver);
            informpage.StartButton.Click();
        }
        public void ClickCheckStatement()
        {
            ServiceLandingPage serviceLandingpage = new ServiceLandingPage(Driver);
            serviceLandingpage.ClickCheckStatement.Click();
        }
        public void ConfirmGatewayCredentials()
        {
            GatewayConfirmPage gatewayconfirmPage = new GatewayConfirmPage(Driver);
            gatewayconfirmPage.YesOption.Click();
            gatewayconfirmPage.ContinueButton.Click();
        }
        public void SearchForCompany()
        {
            SearchForCompany searchforcompany = new SearchForCompany(Driver);
            searchforcompany.CompanyHouseTextBox.Clear();
            searchforcompany.CompanyHouseTextBox.SendKeys(CompanyNumber);
            searchforcompany.ContinueButton.Click();
        }
        public void VerifyCompany()
        {
            VerifyCompanyPage verifycompanypage = new VerifyCompanyPage(Driver);
            string companynamereturned = verifycompanypage.CompanyName.Text;
            StringAssert.Contains(CompanyNameExpected, companynamereturned);
            verifycompanypage.ContinueButton.Click();
        }
        public void LoginHmrcCredentials()
        {
            HMRCLoginPage hmrcpage = new HMRCLoginPage(Driver);
            hmrcpage.UserNameTextBox.Clear();
            hmrcpage.PasswordTextBox.Clear();
            hmrcpage.UserNameTextBox.SendKeys(HMRCUsername);
            hmrcpage.PasswordTextBox.SendKeys(HMRCPassword);
            hmrcpage.SignInButton.Click();
        }
        public void GrantAuthority()
        {
            HMRCResponsePage hmrcresponsepage = new HMRCResponsePage(Driver);
            hmrcresponsepage.AuthoriseButton.Click();
        }
        public void DenyAuthority()
        {
            HMRCResponsePage hmrcresponsepage = new HMRCResponsePage(Driver);
            hmrcresponsepage.DenyButton.Click();
        }
        public void ApproveAccountCreation()
        {
            AccountCreationApprovalPage accountcreationapprovalpage = new AccountCreationApprovalPage(Driver);
            accountcreationapprovalpage.SignAgreementBox.Click();
            accountcreationapprovalpage.SignAgreementBtn.Click();

            //string actualcompanynamedisplayed = accountcreationapprovalpage.CompanyNameForAccount.Text;
            //StringAssert.Contains(CompanyNameExpected, actualcompanynamedisplayed);
            //accountcreationapprovalpage.YesOption.Click();
            //accountcreationapprovalpage.ContinueButton.Click();
        }
        public void DenyAccountCreation()
        {
            AccountCreationApprovalPage accountcreationapprovalpage = new AccountCreationApprovalPage(Driver);
            string actualcompanynamedisplayed = accountcreationapprovalpage.CompanyNameForAccount.Text;
            StringAssert.Contains(CompanyNameExpected, actualcompanynamedisplayed);
            accountcreationapprovalpage.NoOption.Click();
            accountcreationapprovalpage.ContinueButton.Click();
        }
        public void CheckAccountNameAdded()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            string accountadded = servicelandingpage.AccountAdded.Text;
            accountadded.Contains("Account Created");
        }
        public void ViewAccount()
        {
            LoginPirean();
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.OpenAccountLink.Click();


        }
        public void Quit()
        {
            Driver.Quit();
        }
        public void Logout()
        {
            ServiceLandingPage servicelandingpage = new ServiceLandingPage(Driver);
            servicelandingpage.LogoutLink.Click();
        }
        public void checkAccounthomepage()
        {
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.AgreementsLink.Displayed.Equals(true);
            accounthomepage.FundingLink.Displayed.Equals(true);
            accounthomepage.PAYELink.Displayed.Equals(true);
            accounthomepage.TeamLink.Displayed.Equals(true);
        }
        public void viewTransactionsPage()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.FundingLink.Click();
            TransactionsPage transactionspage = new TransactionsPage(Driver);
            transactionspage.TransactionsTable.Displayed.Equals(true);
        }
        public void ViewExistingPayeSchemes()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.PAYELink.Click();
            PayeSchemesPage payeschemespage = new PayeSchemesPage(Driver);            
            string existingpayeeschemes = payeschemespage.ListOfPaye.Text;
            existingpayeeschemes.Contains("111/AA00001 OPTISOURCE TECHNOLOGY SOLUTIONS LIMITED");
        }
        public void AddPayeScheme(string companyNumber)
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.PAYELink.Click();
            PayeSchemesPage payeschemespage = new PayeSchemesPage(Driver);
            payeschemespage.AddPayeButton.Click();
            payeschemespage.AddPayeDraft.Click();
            payeschemespage.ContinuePaye.Click();
            HMRCLoginPage hmrcpage = new HMRCLoginPage(Driver);
            LoginHmrcCredentials();
            GrantAuthority();
            //LoadTempPage();
            HMRCResponsePage hmrcresponsepage = new HMRCResponsePage(Driver);
            hmrcresponsepage.AuthoriseButton.Click();
            PayeSchemesPage payeschemepage = new PayeSchemesPage(Driver);
            payeschemepage.ChooseExistingCompany.Click();
            hmrcresponsepage.AuthoriseButton.Click();
            hmrcresponsepage.AuthoriseButton.Click();
            //HMRCResponsePage hmrcresponsepage = new HMRCResponsePage(Driver);

        }
        public void PayeSchemeAdded()
        {
            PayeSchemesPage payeschemepage = new PayeSchemesPage(Driver);
            string payeadded = payeschemepage.PayeSchemeRemoved.Text;
            payeadded.Contains("has been added to your account");
        }
        public void RemovePayeScheme()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.PAYELink.Click();
            PayeSchemesPage payeschemespage = new PayeSchemesPage(Driver);
            payeschemespage.RemoveScheme.Click();
            payeschemespage.ConfirmRemoval.Click();
            payeschemespage.ContinueRemoval.Click();
        }
        public void PayeSchemeRemoved()
        {
            PayeSchemesPage payeschemespage = new PayeSchemesPage(Driver);
            string payeremoved = payeschemespage.PayeSchemeRemoved.Text;
            payeremoved.Contains("You've removed");

        }
        public void viewTransactionsTable()
        {
            TransactionsPage transactionspage = new TransactionsPage(Driver);
            transactionspage.TransactionsTable.Displayed.Equals(true);
            transactionspage.AnyViewLink.Click();

        }
        public void viewTeamList()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            string teammembers = teamviewpage.TeamList.Text;
            teammembers.Contains(username);

        }
        public void viewTeamListForinvited(string username)
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            string teammembers = teamviewpage.TeamList.Text;
            teammembers.Contains(username);

        }
        public void ViewSecondMember()
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            string teammembers = teamviewpage.TeamList.Text;
            teammembers.Contains(username);
            teamviewpage.ViewSecondMember.Click();

        }
        public void CancelInvitation()
        {
            MemberDetailsPage memberdetailspage = new MemberDetailsPage(Driver);
            memberdetailspage.CancelInvitationButton.Click();
            CancelInvitationPage cancelinvitationpage = new CancelInvitationPage(Driver);
            cancelinvitationpage.YesRadioOption.Click();
            cancelinvitationpage.ContinueButton.Click();
        }
        public void InviteUsers(string username, string email)
        {
            ViewAccount();
            AccountHomePage accounthomepage = new AccountHomePage(Driver);
            accounthomepage.TeamLink.Click();
            TeamViewPage teamviewpage = new TeamViewPage(Driver);
            teamviewpage.TeamList.Displayed.Equals(true);
            teamviewpage.AddUserButton.Click();
            CreateInvitationPage createinvitationpage = new CreateInvitationPage(Driver);
            createinvitationpage.NameTextBox.Clear();
            createinvitationpage.NameTextBox.SendKeys(username);
            createinvitationpage.EmailTextBox.Clear();
            createinvitationpage.EmailTextBox.SendKeys(email);
            createinvitationpage.ViewerRadioButton.Click();
            createinvitationpage.CreateButton.Click();
        }

    }
}
