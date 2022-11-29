using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class ApplicationManager
    {

        private static string databaseConnectionString = @"Data Source=ETHANGAMINGPC; Initial Catalog=EmployeeManagement; Integrated Security=True";


        public static SqlConnection ConnectToDatabase()
        {


            string connectionString = databaseConnectionString;
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                return cnn;
            }
            catch (Exception)
            {

                return null;
            }







        }
    }
}
