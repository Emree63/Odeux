﻿#pragma checksum "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F3B3EAE15C7DAA0D2C6726C811691C34CD474D4B"
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
        
        
        #line 301 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNom;
        
        #line default
        #line hidden
        
        
        #line 302 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNote;
        
        #line default
        #line hidden
        
        
        #line 311 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar mProgressBar;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox;
        
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
            
            #line 113 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SemestrePrecedent);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 127 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SemestreSuivant);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 149 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 161 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupePrecedent);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 173 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GroupeSuivant);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 222 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UePrecedent);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 234 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UeSuivant);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NewNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 301 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            this.NewNom.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.NewNom_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NewNote = ((System.Windows.Controls.TextBox)(target));
            
            #line 302 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            this.NewNote.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.NewNote_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 303 "..\..\..\..\..\User-Control\Prof\EntrerDesNotes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Valider);
            
            #line default
            #line hidden
            return;
            case 11:
            this.mProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 12:
            this.ListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

