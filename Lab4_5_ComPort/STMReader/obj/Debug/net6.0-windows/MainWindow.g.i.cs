﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "745D7046902047D2AE9200114255B812D3595601"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveChartsCore.SkiaSharpView.WPF;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using STMReader;
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


namespace STMReader {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Red_l;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Red_tb;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Green_l;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Green_tb;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Blue_l;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Blue_tb;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendRGB_b;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Led1_l;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Led1_tog;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Led2_l;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Led2_tog;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/STMReader;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Red_l = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Red_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\MainWindow.xaml"
            this.Red_tb.LostFocus += new System.Windows.RoutedEventHandler(this.Red_tb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Green_l = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Green_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\MainWindow.xaml"
            this.Green_tb.LostFocus += new System.Windows.RoutedEventHandler(this.Green_tb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Blue_l = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Blue_tb = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.Blue_tb.LostFocus += new System.Windows.RoutedEventHandler(this.Blue_tb_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SendRGB_b = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\MainWindow.xaml"
            this.SendRGB_b.Click += new System.Windows.RoutedEventHandler(this.SendRGB_b_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Led1_l = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Led1_tog = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.Led1_tog.Click += new System.Windows.RoutedEventHandler(this.Led1_tog_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Led2_l = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.Led2_tog = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 70 "..\..\..\MainWindow.xaml"
            this.Led2_tog.Click += new System.Windows.RoutedEventHandler(this.Led2_tog_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

