﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4211
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Globus5.WPF.Comum.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/globus5/escalaws.asmx")]
        public string BgmRodotec_EscalaWS {
            get {
                return ((string)(this["BgmRodotec_EscalaWS"]));
            }
            set {
                this["BgmRodotec_EscalaWS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/globus5/gestaoDeFrotaOnlinews.asmx")]
        public string BgmRodotec_GestaoDeFrotaOnLineWS {
            get {
                return ((string)(this["BgmRodotec_GestaoDeFrotaOnLineWS"]));
            }
            set {
                this["BgmRodotec_GestaoDeFrotaOnLineWS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/globus5/folhaws.asmx")]
        public string BgmRodotec_FolhaWS {
            get {
                return ((string)(this["BgmRodotec_FolhaWS"]));
            }
            set {
                this["BgmRodotec_FolhaWS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/globus5/frotaws.asmx")]
        public string BgmRodotec_FrotaWS {
            get {
                return ((string)(this["BgmRodotec_FrotaWS"]));
            }
            set {
                this["BgmRodotec_FrotaWS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/globus5/globusws.asmx")]
        public string BgmRodotec_GlobusWS {
            get {
                return ((string)(this["BgmRodotec_GlobusWS"]));
            }
            set {
                this["BgmRodotec_GlobusWS"] = value;
            }
        }
    }
}