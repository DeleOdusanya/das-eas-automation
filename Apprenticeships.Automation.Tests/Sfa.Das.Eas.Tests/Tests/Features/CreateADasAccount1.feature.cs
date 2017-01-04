﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Das.Eas.Tests.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create A Das Account")]
    public partial class CreateADasAccountFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateADasAccount.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create A Das Account", "    As an Employer\r\n    I would like the ability to register an Account\r\n    So t" +
                    "hat I can start using the Digital Apprenticeship Service", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account - Registering and Actvating an Account with valid details and mand" +
            "atory data items have been supplied")]
        public virtual void CreateAccount_RegisteringAndActvatingAnAccountWithValidDetailsAndMandatoryDataItemsHaveBeenSupplied()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Registering and Actvating an Account with valid details and mand" +
                    "atory data items have been supplied", ((string[])(null)));
#line 6
 this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I navigate to the Create Account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I submit the form with the mandatory data items supplied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account - Attempting to create an Account when the mandatory data items ha" +
            "ve not been supplied")]
        public virtual void CreateAccount_AttemptingToCreateAnAccountWhenTheMandatoryDataItemsHaveNotBeenSupplied()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Attempting to create an Account when the mandatory data items ha" +
                    "ve not been supplied", ((string[])(null)));
#line 12
    this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.Given("I navigate to the Create Account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
    testRunner.When("I attempt to submit a form without completing the mandatory data items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
    testRunner.Then("validation messages will be displayed on all incomplete mandatory items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account - Registering an Account with invalid data items")]
        public virtual void CreateAccount_RegisteringAnAccountWithInvalidDataItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Registering an Account with invalid data items", ((string[])(null)));
#line 17
    this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("I navigate to the Create Account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
    testRunner.When("I attempt to submit a form with invalid data items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
    testRunner.Then("I will be presented with an appropriate validation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account - Registering an account with e-mail address that is already assoc" +
            "iated to an Active Account")]
        public virtual void CreateAccount_RegisteringAnAccountWithE_MailAddressThatIsAlreadyAssociatedToAnActiveAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Registering an account with e-mail address that is already assoc" +
                    "iated to an Active Account", ((string[])(null)));
#line 22
    this.ScenarioSetup(scenarioInfo);
#line 23
    testRunner.Given("I navigate to the Create Account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
    testRunner.When("I submit form with e-mail address already associated to an Active Account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
    testRunner.Then("I will be informed that the email address is already associated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
    testRunner.And("I should remain on the account creation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account - Registering an account with email associated to a user that is P" +
            "ending Activation")]
        public virtual void CreateAccount_RegisteringAnAccountWithEmailAssociatedToAUserThatIsPendingActivation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Registering an account with email associated to a user that is P" +
                    "ending Activation", ((string[])(null)));
#line 28
 this.ScenarioSetup(scenarioInfo);
#line 29
    testRunner.Given("I navigate to the Create Account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
    testRunner.When("I submit a form with an e-mail address associated to a user that is Pending Activ" +
                    "ation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
    testRunner.Then("a new account should be created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
    testRunner.And("all other information provided in this step should supersede information provided" +
                    " historically", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account - Activating an account with invalid activation code")]
        public virtual void CreateAccount_ActivatingAnAccountWithInvalidActivationCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Activating an account with invalid activation code", ((string[])(null)));
#line 35
 this.ScenarioSetup(scenarioInfo);
#line 36
    testRunner.Given("I navigate to the Create Account page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
    testRunner.When("I submit form with valid data in all mandatory fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
    testRunner.And("I enter an Invalid activation code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
    testRunner.Then("I should be prompted to enter a valid activation code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
