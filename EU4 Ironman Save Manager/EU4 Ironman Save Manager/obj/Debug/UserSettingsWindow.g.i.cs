﻿#pragma checksum "..\..\UserSettingsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DD17482CEA78B5CC954696CBEFD9691C13DE0F06"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EU4_Ironman_Save_Manager;
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


namespace EU4_Ironman_Save_Manager {
    
    
    /// <summary>
    /// UserSettingsWindow
    /// </summary>
    public partial class UserSettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\UserSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EU4_Ironman_Save_Manager.UserSettingsWindow UserSettingsWindow;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UserSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SaveName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UserSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SaveFolderName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\UserSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SaveLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UserSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SaveLabel_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/EU4 Ironman Save Manager;component/usersettingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserSettingsWindow.xaml"
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
            this.UserSettingsWindow = ((EU4_Ironman_Save_Manager.UserSettingsWindow)(target));
            
            #line 9 "..\..\UserSettingsWindow.xaml"
            this.UserSettingsWindow.KeyDown += new System.Windows.Input.KeyEventHandler(this.UserSettingsWindow_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SaveName = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\UserSettingsWindow.xaml"
            this.SaveName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 21 "..\..\UserSettingsWindow.xaml"
            this.SaveName.KeyDown += new System.Windows.Input.KeyEventHandler(this.SaveName_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SaveFolderName = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\UserSettingsWindow.xaml"
            this.SaveFolderName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 22 "..\..\UserSettingsWindow.xaml"
            this.SaveFolderName.KeyDown += new System.Windows.Input.KeyEventHandler(this.SaveFolderName_KeyDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\UserSettingsWindow.xaml"
            this.SaveFolderName.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SaveFolderName_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaveLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.SaveLabel_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

