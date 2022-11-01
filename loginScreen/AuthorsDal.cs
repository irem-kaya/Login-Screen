using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginScreen
{
    public class AuthorsDal
    {
        public DataTable GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog= pubs;integrated security = true");
            
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Authors" , sqlConnection);

            SqlDataReader reader =  command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            sqlConnection.Close();
            return dataTable;
        }
    }
}
