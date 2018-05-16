using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
namespace DreamConnectApp
{
     public class DataClass : INotifyPropertyChanged
    {
        
        public string Username{ get; set; }
        public string UserPasscode { get; set; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        private string connectionString = @"Data Source=LAPTOP-PVNMLFT6\SQLEXPRESS;Initial Catalog=sqlexpress.DreamConnectDatabase.dbo;Integrated Security=SSPI";

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
            }
        }


        public ObservableCollection<DataClass> GetData(string connectionString)
        {
            const string GetUserDataQuery = "INSERT INTO USER VALUES({x,{y})"; 

            var Data = new ObservableCollection<DataClass>();
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
                                    var User = new DataClass();
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
