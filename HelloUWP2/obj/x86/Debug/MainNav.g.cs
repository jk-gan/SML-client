﻿#pragma checksum "C:\Users\simonlim\Source\Repos\SML-client\HelloUWP2\MainNav.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BBC028FC1DBFDF7AB869F2ECC4FE16E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloUWP2
{
    partial class MainNav : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.mySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.ListBox element2 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 31 "..\..\..\MainNav.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)element2).SelectionChanged += this.ListBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.police = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.homeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.myFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 6:
                {
                    this.hamburgerBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\MainNav.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.hamburgerBtn).Click += this.hamburgerBtn_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.backBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MainNav.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backBtn).Click += this.backBtn_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.titleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

