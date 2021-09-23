using System;
using System.Data.SqlClient;
using System.Data;

namespace ShoppingListApp.Repositories
{
    public class DatabaseWrapper : IDatabaseWrapper
    {
        readonly string connectionString = "Server= DESKTOP-7MGC06P\\LOKI; Database= ShoppingList; Integrated Security=True;";

        public DataTable Query(string sql)
        {
            DataTable tbl = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();

                    // create data adapter
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // this will query your database and return the result to your datatable
                    da.Fill(tbl);
                    //conn.Close();
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //MessageBox.Show(ex.Message);
            }
            return tbl;
        }

        public void Command(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public object GetScalar(string sql)
        {
            object obj = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Connection.Open();
                obj = command.ExecuteScalar();
            }

            return obj;
        }
    }
}
