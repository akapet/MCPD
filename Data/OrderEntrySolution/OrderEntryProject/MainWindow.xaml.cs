using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Data.Common;

namespace OrderEntryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        const string conStr = "OrderEntryProject.Properties.Settings.NorthwindConnectionString"; 

        void Initialise()
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.AutoFlush = true;
            Debug.Indent();
            Debug.WriteLine("Entering Initialise");
            
            var nw = ConfigurationManager.ConnectionStrings[conStr];

            Debug.Assert(nw != null, "The Northwind shouldn't be null!");
            var connection = new SqlConnection(nw.ConnectionString);

            Debug.Assert(connection != null, "Connection shouldn't be null!");
            var cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CustOrderHist";
        }

        void DbParamTest()
        {
            var nw = ConfigurationManager.ConnectionStrings[conStr];
            var connection = new SqlConnection();
            connection.ConnectionString = nw.ConnectionString;

            var cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CustOrderHist";
            DbParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@Id";
            parm.Value = "ANATR";
            cmd.Parameters.Add(parm);

            // access the name
            //var id = (string)cmd.Parameters["@Id"].Value;
        }

        void ExecuteNonQuery()
        {
            var nw = ConfigurationManager.ConnectionStrings[conStr];
            int count = 0;

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = nw.ConnectionString;
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Products SET UnitPrice = UnitPrice * 1.1 WHERE ProductID = 1";
                connection.Open();
                count = cmd.ExecuteNonQuery();
            }
            MessageBox.Show(count.ToString());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ExecuteNonQuery();
        }
    }
}
