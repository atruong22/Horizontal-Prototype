﻿#pragma checksum "..\..\..\LoginContent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BA384E60358D0235DBAB53488267E9C4EB8E528D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Vertical_Prototype;


namespace Vertical_Prototype {
    
    
    /// <summary>
    /// LoginContent
    /// </summary>
    public partial class LoginContent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\LoginContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginContent_usernameField;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\LoginContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox loginContent_passwordField;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\LoginContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginContent_loginButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\LoginContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginContent_signUpButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vertical-Prototype;component/logincontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginContent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.loginContent_usernameField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.loginContent_passwordField = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.loginContent_loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\LoginContent.xaml"
            this.loginContent_loginButton.Click += new System.Windows.RoutedEventHandler(this.loginContent_signUpButton_Click1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.loginContent_signUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\LoginContent.xaml"
            this.loginContent_signUpButton.Click += new System.Windows.RoutedEventHandler(this.loginContent_signUpButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

