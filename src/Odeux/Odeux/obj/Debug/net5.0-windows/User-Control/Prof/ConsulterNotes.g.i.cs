﻿#pragma checksum "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "739A3117C87ED18268C1ACEFE0C5F5200CC659B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Odeux.User_Control.Prof;
using Odeux.converter;
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


namespace Odeux.User_Control.Prof {
    
    
    /// <summary>
    /// ConsulterNotes
    /// </summary>
    public partial class ConsulterNotes : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 138 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Odeux;V1.0.0.0;component/user-control/prof/consulternotes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 45 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SemestrePrecedent);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 55 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SemestreSuivant);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 60 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupePrecedent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 70 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupeSuivant);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 88 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 107 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UePrecedent);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 119 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UeSuivant);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 138 "..\..\..\..\..\User-Control\Prof\ConsulterNotes.xaml"
            this.ListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

