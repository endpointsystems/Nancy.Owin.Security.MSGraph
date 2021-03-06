﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2CDemo.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Graph API AppUri (from Azure AD)")]
        public string GraphAppIdUri {
            get {
                return ((string)(this["GraphAppIdUri"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("the reply URL for your app (https://localhost:44375/)")]
        public string ReplyUrl {
            get {
                return ((string)(this["ReplyUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Graph API app secret (from Azure AD)")]
        public string GraphAppKey {
            get {
                return ((string)(this["GraphAppKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yourtenantname.onmicrosoft.com")]
        public string Tenant {
            get {
                return ((string)(this["Tenant"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("your B2C app ID")]
        public string LoginAppId {
            get {
                return ((string)(this["LoginAppId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("your B2C app secret")]
        public string LoginAppKey {
            get {
                return ((string)(this["LoginAppKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>B2C_1_SignUpSignIn</string>
  <string>B2C_1_ProfEdit</string>
  <string>B2C_1_ResetPwd</string>
  <string>B2C_1_SignUp</string>
  <string>B2C_1_SignIn</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection LoginPolicies {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LoginPolicies"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("openid email profile offline_access")]
        public string LoginScopes {
            get {
                return ((string)(this["LoginScopes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://login.microsoftonline.com/{0}/v2.0/.well-known/openid-configuration?p={1}" +
            "")]
        public string LoginMetadataUri {
            get {
                return ((string)(this["LoginMetadataUri"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Sign up/Sign in</string>
  <string>Edit Profile</string>
  <string>Reset Password</string>
  <string>Sign Up</string>
  <string>Sign In</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection LoginCaptions {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LoginCaptions"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("your graph application ID")]
        public string GraphAppId {
            get {
                return ((string)(this["GraphAppId"]));
            }
        }
    }
}
