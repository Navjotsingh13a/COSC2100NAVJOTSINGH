﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2478A4DE28D0D44405E6F39AF0244BF4BD846F407024523F9627DB3DB549957"
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
using WebBrowserApp;


namespace WebBrowserApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressBar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBookmarkButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser WebBrowserControl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox BookmarksList;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatusText;
        
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
            System.Uri resourceLocater = new System.Uri("/WebBrowserApp;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
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
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Page1.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Page1.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Page1.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddressBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\Page1.xaml"
            this.AddressBar.KeyDown += new System.Windows.Input.KeyEventHandler(this.AddressBar_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 17 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddBookmarkButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Page1.xaml"
            this.AddBookmarkButton.Click += new System.Windows.RoutedEventHandler(this.AddBookmarkButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.WebBrowserControl = ((System.Windows.Controls.WebBrowser)(target));
            
            #line 23 "..\..\Page1.xaml"
            this.WebBrowserControl.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.WebBrowserControl_Navigating);
            
            #line default
            #line hidden
            
            #line 23 "..\..\Page1.xaml"
            this.WebBrowserControl.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.WebBrowserControl_Navigated);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BookmarksList = ((System.Windows.Controls.ListBox)(target));
            
            #line 24 "..\..\Page1.xaml"
            this.BookmarksList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BookmarksList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.StatusText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
