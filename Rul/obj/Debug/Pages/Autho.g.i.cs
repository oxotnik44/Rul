﻿#pragma checksum "..\..\..\Pages\Autho.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ADF219F80B79DFE62A0673D6D4CEF51907E355F48C7BE895DA98DD520CA1938A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Rul.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Rul.Pages {
    
    
    /// <summary>
    /// Autho
    /// </summary>
    public partial class Autho : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLogin;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockCaptcha;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCaptcha;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCeterGuest;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\Autho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCeter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Rul;component/pages/autho.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Autho.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBlockCaptcha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtCaptcha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnCeterGuest = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\Autho.xaml"
            this.btnCeterGuest.Click += new System.Windows.RoutedEventHandler(this.btnCeterGuest_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCeter = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\Autho.xaml"
            this.btnCeter.Click += new System.Windows.RoutedEventHandler(this.btnCeter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

