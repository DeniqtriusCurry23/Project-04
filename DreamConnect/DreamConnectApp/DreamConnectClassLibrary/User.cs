using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
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
using DreamConnectApp.DreamConnectClassLibrary;
namespace DreamConnectApp
{
     public class User : INotifyPropertyChanged
    {
        
        public string Username{ get; set; }
        public string UserPasscode { get; set; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        private string connectionString = @"Data Source=LAPTOP-PVNMLFT6\SQLEXPRESS;Initial Catalog=sqlexpress.DreamConnectDatabase.dbo;Integrated Security=SSPI";

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
            }
        }


        public ObservableCollection<User> GetData(string connectionString)
        {
            const string GetUserDataQuery = "INSERT INTO USER VALUES({x,{y})"; 

            var Data = new ObservableCollection<User>();
            try 
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetUserDataQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var User = new User();
                                    User.Username = reader.GetString(0);
                                    User.UserPasscode = reader.GetString(1);
                                    
                                    
                                   
                                }
                            }
                        }
                    }
                }
                return Data;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }


    }
}
