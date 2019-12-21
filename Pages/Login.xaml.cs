using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T1809E_UWP_DAPI_D101_TrangDM2.Utils;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1809E_UWP_DAPI_D101_TrangDM2.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
   
    public sealed partial class Login : Page
    {
        private Validator validator = new Validator();
        public Login()
        {
            this.InitializeComponent();
        }

        private void LoginHanlde(object sender, RoutedEventArgs e)
        {
            if (validator.IsEmail(email.Text)){
                emailAlert.Text = "";
                if (validator.IsNotNullAndNotEmpty(password.Password)){
                    passwordAlert.Text = "";
                    //Next
                }
                else
                {
                    passwordAlert.Text = "Please enter password";
                }
            }
            else
            {
                emailAlert.Text = "Inlavid email, please enter valid email format.";
            }
        }
    }
}
