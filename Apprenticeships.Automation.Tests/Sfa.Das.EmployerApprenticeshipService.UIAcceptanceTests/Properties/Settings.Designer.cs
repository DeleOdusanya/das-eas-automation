﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Das.EAS.AcceptanceTests.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://test-eas.apprenticeships.sfa.bis.gov.uk/")]
        public string GettingStarted {
            get {
                return ((string)(this["GettingStarted"]));
            }
            set {
                this["GettingStarted"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ppidentity.apprenticeships.sfa.bis.gov.uk/SignIn/dialog/appl/selfcare/wfl" +
            "ow/register?sfaredirecturl=https%3A%2F%2Ftest-eas.apprenticeships.sfa.bis.gov.uk" +
            "%2FHome%2FSignIn")]
        public string CreateAccount {
            get {
                return ((string)(this["CreateAccount"]));
            }
            set {
                this["CreateAccount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute(@"https://ppidentity.apprenticeships.sfa.bis.gov.uk/SignIn/dialog/appl/oidc/wflow/authorize?client_id=000123&response_type=code&scope=openid&redirect_uri=https%3A%2F%2Ftest-eas.apprenticeships.sfa.bis.gov.uk%2FHome%2FSignIn&state=b997e2a0a7a84b5d902bc949fa907ad4&nonce=847204fef3574cd7af9be9c7ff7a3938")]
        public string SignIn {
            get {
                return ((string)(this["SignIn"]));
            }
            set {
                this["SignIn"] = value;
            }
        }
    }
}