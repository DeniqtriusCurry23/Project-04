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
using System.ComponentModel;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DreamConnectApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 


    public sealed partial class NewSignUpPage : Page
    {
        public delegate string GetData();
        LinkedList<GetData> getDatas;
        public NewSignUpPage()
        {
            this.InitializeComponent();
        }

        private void UserNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
       

        private void UserNameTextBox_TextChanged(object sender, RoutedEventArgs e)
        {

        }
        private void TextBlock_SelectionChanged(object sender,RoutedEventArgs e)
        {

        }
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (SignUpButton != null)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.DataContext = new object();
                DataContext.ToString();
                var textblockdatacontent = DataContext;
                var text = DataContext;
                PasswordBox passWord = new PasswordBox();
                passWord.DataContext = new object();
                DataContext.ToString();
                var password = DataContext;





                var SQLQuery = "INSERT INTO USER VALUES(${x},{y})";

                this.Frame.Navigate(typeof(DreamConnectPage));
            }
        }


    }
}


