﻿#pragma checksum "C:\Users\TrangDM2\Documents\Visual Studio Projects\T1809E_UWP_DAPI_D101_TrangDM2\Pages\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1449898BCF8CA412E9D3A33B540DD225"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T1809E_UWP_DAPI_D101_TrangDM2.Pages
{
    partial class Home : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Home.xaml line 14
                {
                    this.nvSample = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                }
                break;
            case 3: // Pages\Home.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element3 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element3).Tapped += this.LoginPageNavigate;
                }
                break;
            case 4: // Pages\Home.xaml line 18
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element4 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element4).Tapped += this.SongListPageNavigate;
                }
                break;
            case 5: // Pages\Home.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element5 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element5).Tapped += this.RegisterPageNavigate;
                }
                break;
            case 6: // Pages\Home.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.NavigationViewItem element6 = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)element6).Tapped += this.AddSongPageNavigate;
                }
                break;
            case 7: // Pages\Home.xaml line 22
                {
                    this.MainPanel = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

