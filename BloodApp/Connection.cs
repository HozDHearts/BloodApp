using System;
using System.Data;
using System.Data.SqlClient;

namespace BloodApp
{
    class Connection
    {
        private static SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\BloodApp\\BloodApp\\Blood.mdf;Integrated Security=True");
            //SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Blood.mdf;Integrated Security=True");
            return connect;
        }

        public DataSet ReadQuery(string query, string table)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, connection());
            DataSet ds = new DataSet();
            da.Fill(ds, table);

            return ds;
        }

        public DataRow[] ReadQuery(string query, string table, bool datarow)
        {
            DataTable tb = ReadQuery(query, table).Tables[table];
            DataRow[] rows = tb.Select();
            return rows;
        }

        public bool SetData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection());
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
