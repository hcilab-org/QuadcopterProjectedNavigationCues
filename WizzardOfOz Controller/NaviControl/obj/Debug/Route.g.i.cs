﻿#pragma checksum "..\..\Route.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95F5B0A2C2B71E0E524ED4F4C21D8C8209C43422"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NaviControl;
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


namespace NaviControl {
    
    
    /// <summary>
    /// Route
    /// </summary>
    public partial class Route : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_next;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_prev;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_m_up;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_m_down;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_drone;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_desc;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse greenC;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse redC;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Route.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/NaviControl;component/route.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Route.xaml"
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
            this.b_next = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Route.xaml"
            this.b_next.Click += new System.Windows.RoutedEventHandler(this.b_next_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.b_prev = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Route.xaml"
            this.b_prev.Click += new System.Windows.RoutedEventHandler(this.b_prev_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_m_up = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.b_m_down = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.b_drone = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Route.xaml"
            this.b_drone.Click += new System.Windows.RoutedEventHandler(this.b_drone_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.l_desc = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.greenC = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 8:
            this.redC = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 9:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Route.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
