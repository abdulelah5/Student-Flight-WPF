﻿#pragma checksum "..\..\..\SupervisorView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DAD6BDD3D73054D2F413D621F7AEECB69B4CEDE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StudentFlight;
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


namespace StudentFlight {
    
    
    /// <summary>
    /// SupervisorView
    /// </summary>
    public partial class SupervisorView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvFlights;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDesc;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Refuse;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\SupervisorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Accept;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StudentFlight;component/supervisorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SupervisorView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dgvFlights = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\SupervisorView.xaml"
            this.dgvFlights.Loaded += new System.Windows.RoutedEventHandler(this.dgvFlights_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\SupervisorView.xaml"
            this.dgvFlights.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvFlights_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\SupervisorView.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.Submit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cancel = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\SupervisorView.xaml"
            this.cancel.Click += new System.Windows.RoutedEventHandler(this.cancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Refuse = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\..\SupervisorView.xaml"
            this.Refuse.Checked += new System.Windows.RoutedEventHandler(this.refused);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\SupervisorView.xaml"
            this.txtSearch.IsKeyboardFocusedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.txtSearch_IsKeyboardFocusedChanged);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\SupervisorView.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Accept = ((System.Windows.Controls.RadioButton)(target));
            
            #line 16 "..\..\..\SupervisorView.xaml"
            this.Accept.Checked += new System.Windows.RoutedEventHandler(this.Accept_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

