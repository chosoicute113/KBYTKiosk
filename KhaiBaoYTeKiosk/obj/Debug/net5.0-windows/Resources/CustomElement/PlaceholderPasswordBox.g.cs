#pragma checksum "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82C43878FA0D4AE31E43548876EE2D36462EE6D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KhaiBaoYTeKiosk.Resources.CustomElement;
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


namespace KhaiBaoYTeKiosk.Resources.CustomElement {
    
    
    /// <summary>
    /// PlaceholderPasswordBox
    /// </summary>
    public partial class PlaceholderPasswordBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal KhaiBaoYTeKiosk.Resources.CustomElement.PlaceholderPasswordBox Root;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox InputBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlaceholderBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KhaiBaoYTeKiosk;component/resources/customelement/placeholderpasswordbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Root = ((KhaiBaoYTeKiosk.Resources.CustomElement.PlaceholderPasswordBox)(target));
            return;
            case 2:
            this.InputBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 11 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
            this.InputBox.LostFocus += new System.Windows.RoutedEventHandler(this.InputBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
            this.InputBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.InputBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlaceholderBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
            this.PlaceholderBox.GotFocus += new System.Windows.RoutedEventHandler(this.PlaceholderBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\..\Resources\CustomElement\PlaceholderPasswordBox.xaml"
            this.PlaceholderBox.Loaded += new System.Windows.RoutedEventHandler(this.PlaceholderBox_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

