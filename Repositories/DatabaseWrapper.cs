using System;
using System.Data.SqlClient;
using System.Data;

namespace ShoppingListApp.Repositories
{
    public class DatabaseWrapper : IDatabaseWrapper
    {
        readonly string connectionString = "Server= T5PT102; Database= AusyEmployee; Integrated Security=True;";

        public DataTable GetQueryResult(string Query)
        {
            DataTable tbl = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(Query, connection);
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

        public void UpdateDB(string InsertQuery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(InsertQuery, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public object GetValueFromDB(string Query)
        {
            object obj = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                command.Connection.Open();
                obj = command.ExecuteScalar();
            }

            return obj;
        }
    }
}
