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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DreamConnectApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SignUpUserNameBox != null)
            {
                //Apply Logic Here
            }
        }

        private void SignUpSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if ( SignUpUserNameBox != null)
            {
                this.Frame.Navigate(typeof(BlankPage2));
            }
        }

        private void EmailAddressTextBlock1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
