﻿#pragma checksum "..\..\wndUndoRepair.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09201143EE334B2655A5990449939865"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace PC_Cleaner {
    
    
    /// <summary>
    /// wndUndoRepair
    /// </summary>
    public partial class wndUndoRepair : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\wndUndoRepair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid layoutRootUndorRepair;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\wndUndoRepair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgLogDetails;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\wndUndoRepair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReverse;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\wndUndoRepair.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/PC Cleaner;component/wndundorepair.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\wndUndoRepair.xaml"
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
            this.layoutRootUndorRepair = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.dgLogDetails = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnReverse = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\wndUndoRepair.xaml"
            this.btnReverse.Click += new System.Windows.RoutedEventHandler(this.btnReverse_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\wndUndoRepair.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

