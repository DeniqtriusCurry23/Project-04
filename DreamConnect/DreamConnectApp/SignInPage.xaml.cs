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
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DreamConnectApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void UserNameTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void UserNameEnterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var y = UserNameTextBlock;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PassWordTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
           if (PassWordTextBlock != null)
            {
                var x = PassWordTextBlock;
            }
        }
        

        private void Click_Here_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private  void ClickHereButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClickHereButton != null)
            {

            }
            this.Frame.Navigate(typeof(NewSignUpPage));
        }

        private void LoginPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPageButton != null)
            {
                var x = UserNameTextBlock;
                var y = PassWordTextBlock;
                var SQLQuery = "INSERT INTO USER VALUES(${x},{y})";
               
                this.Frame.Navigate(typeof(DreamPage));


            }
            

        }
    }
}
