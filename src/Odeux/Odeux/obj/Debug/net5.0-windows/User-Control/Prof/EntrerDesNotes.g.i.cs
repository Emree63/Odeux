﻿#pragma checksum "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C04FCDACF28D702298243F86A3E287F839DD7A4F"
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
    /// EntrerDesNotes
    /// </summary>
    public partial class EntrerDesNotes : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 144 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNom;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNote;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar mProgressBar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Odeux;component/user-control/prof/entrerdesnotes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 51 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SemestrePrecedent);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 61 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SemestreSuivant);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 66 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupePrecedent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 76 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupeSuivant);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 82 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 94 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 113 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UePrecedent);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 125 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UeSuivant);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 144 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            this.ListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NewNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 196 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            this.NewNom.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.NewNom_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.NewNote = ((System.Windows.Controls.TextBox)(target));
            
            #line 197 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            this.NewNote.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.NewNote_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 198 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Valider);
            
            #line default
            #line hidden
            return;
            case 13:
            this.mProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

