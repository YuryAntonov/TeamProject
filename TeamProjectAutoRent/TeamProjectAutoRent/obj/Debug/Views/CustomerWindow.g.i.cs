﻿#pragma checksum "..\..\..\Views\CustomerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C2BC5ADB2EE348C91EA6B7D5E76D3C2AB8FA66BD64F48DEBEDB72495ED464E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LogicAndDb;
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
using TeamProjectAutoRent.Views;


namespace TeamProjectAutoRent.Views {
    
    
    /// <summary>
    /// CustomerWindow
    /// </summary>
    public partial class CustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customer_addressTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox driving_experienceTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox full_nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genderComboBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passport_numberTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\CustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone_numberTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TeamProjectAutoRent;component/views/customerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CustomerWindow.xaml"
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
            
            #line 9 "..\..\..\Views\CustomerWindow.xaml"
            ((TeamProjectAutoRent.Views.CustomerWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.customer_addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.driving_experienceTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Views\CustomerWindow.xaml"
            this.driving_experienceTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Driving_experienceTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.full_nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.genderComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.passport_numberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.phone_numberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 41 "..\..\..\Views\CustomerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

