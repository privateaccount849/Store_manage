using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLK
{
    public class Model
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-VJOFVIDQ\\PRIVATE;database=Store;integrated security=true");
            return conn;
        }
        public bool AddData(string id, string name, double phone, string a_id, string ca_id, string em_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandText = "insert into tblStore values(@id,@n,@p,@a, @ca, @em)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@a", a_id);
            cmd.Parameters.AddWithValue("@ca", ca_id);
            cmd.Parameters.AddWithValue("@em", em_id);
            int r = cmd.ExecuteNonQuery();
            return r > 0;
        }
    }
}
