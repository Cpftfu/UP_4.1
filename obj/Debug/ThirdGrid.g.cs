﻿#pragma checksum "..\..\ThirdGrid.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "654BCBBECD1EFE39E3DD2AD8E71C19120B77477B0198246D15125361DD4B0C23"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using UP_4._1;


namespace UP_4._1 {
    
    
    /// <summary>
    /// ThirdGrid
    /// </summary>
    public partial class ThirdGrid : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\ThirdGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox forSearch;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ThirdGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ThirdGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forClean;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ThirdGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forExit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ThirdGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrdersComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ThirdGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrdersDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/UP_4.1;component/thirdgrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThirdGrid.xaml"
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
            this.forSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.forGrid = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ThirdGrid.xaml"
            this.forGrid.Click += new System.Windows.RoutedEventHandler(this.forGrid_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.forClean = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ThirdGrid.xaml"
            this.forClean.Click += new System.Windows.RoutedEventHandler(this.forClean_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.forExit = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\ThirdGrid.xaml"
            this.forExit.Click += new System.Windows.RoutedEventHandler(this.forExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OrdersComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\ThirdGrid.xaml"
            this.OrdersComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrdersComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OrdersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
