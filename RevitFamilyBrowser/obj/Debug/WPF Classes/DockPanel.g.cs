﻿#pragma checksum "..\..\..\WPF Classes\DockPanel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B3478A924953271583B8B796E2F4DDEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RevitFamilyBrowser.WPF_Classes;
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


namespace RevitFamilyBrowser.WPF_Classes {
    
    
    /// <summary>
    /// DockPanel
    /// </summary>
    public partial class DockPanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\WPF Classes\DockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\WPF Classes\DockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\WPF Classes\DockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_CategoryName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\WPF Classes\DockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\WPF Classes\DockPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/RevitFamilyBrowser;component/wpf%20classes/dockpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPF Classes\DockPanel.xaml"
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
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.label_CategoryName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 47 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGrid.DragEnter += new System.Windows.DragEventHandler(this.drag_DragEnter);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGrid.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dataGrid_PreviewMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGridHistory = ((System.Windows.Controls.DataGrid)(target));
            
            #line 105 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGridHistory.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 106 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGridHistory.DragEnter += new System.Windows.DragEventHandler(this.drag_DragEnter);
            
            #line default
            #line hidden
            
            #line 114 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGridHistory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\WPF Classes\DockPanel.xaml"
            this.dataGridHistory.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dataGrid_PreviewMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

