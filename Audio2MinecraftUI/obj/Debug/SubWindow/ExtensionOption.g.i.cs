﻿#pragma checksum "..\..\..\SubWindow\ExtensionOption.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C833819974FBD7824717ED480331BC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Audio2MinecraftUI.SubWindow;
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


namespace Audio2MinecraftUI.SubWindow {
    
    
    /// <summary>
    /// ExtensionOption
    /// </summary>
    public partial class ExtensionOption : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\SubWindow\ExtensionOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button icon;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\SubWindow\ExtensionOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Path;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\SubWindow\ExtensionOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\SubWindow\ExtensionOption.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button done;
        
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
            System.Uri resourceLocater = new System.Uri("/Audio2MinecraftUI;component/subwindow/extensionoption.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SubWindow\ExtensionOption.xaml"
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
            this.icon = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.icon.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Select);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.icon.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Select);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Path = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.Path.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Select);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.Path.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Select);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cancel = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.cancel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Cancel);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.cancel.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.done = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.done.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Done);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\SubWindow\ExtensionOption.xaml"
            this.done.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Done);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

