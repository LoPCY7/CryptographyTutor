﻿#pragma checksum "..\..\..\Pages\EncryptionAES.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB24DDAA29BDE4C04CFD3740297AA4FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace CryptographyTutor.Pages {
    
    
    /// <summary>
    /// EncryptionAES
    /// </summary>
    public partial class EncryptionAES : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnEncryption;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnDecryption;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEncrypted;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox txtKey;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox txtIV;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.WatermarkTextBox txtInput;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnECB;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnCBC;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtn128;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtn192;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtn256;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rbtnExpMode;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\EncryptionAES.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEncrypt;
        
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
            System.Uri resourceLocater = new System.Uri("/CryptographyTutor;component/pages/encryptionaes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EncryptionAES.xaml"
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
            this.rbtnEncryption = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.rbtnDecryption = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.txtEncrypted = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtKey = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            return;
            case 5:
            this.txtIV = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 6:
            this.txtInput = ((Xceed.Wpf.Toolkit.WatermarkTextBox)(target));
            return;
            case 7:
            this.rbtnECB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 32 "..\..\..\Pages\EncryptionAES.xaml"
            this.rbtnECB.Checked += new System.Windows.RoutedEventHandler(this.rbtnECB_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rbtnCBC = ((System.Windows.Controls.RadioButton)(target));
            
            #line 33 "..\..\..\Pages\EncryptionAES.xaml"
            this.rbtnCBC.Checked += new System.Windows.RoutedEventHandler(this.rbtnCBC_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rbtn128 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 37 "..\..\..\Pages\EncryptionAES.xaml"
            this.rbtn128.Checked += new System.Windows.RoutedEventHandler(this.rbtn128_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rbtn192 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 38 "..\..\..\Pages\EncryptionAES.xaml"
            this.rbtn192.Checked += new System.Windows.RoutedEventHandler(this.rbtn192_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.rbtn256 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 39 "..\..\..\Pages\EncryptionAES.xaml"
            this.rbtn256.Checked += new System.Windows.RoutedEventHandler(this.rbtn256_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.rbtnExpMode = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.btnEncrypt = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Pages\EncryptionAES.xaml"
            this.btnEncrypt.Click += new System.Windows.RoutedEventHandler(this.btnEncrypt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

