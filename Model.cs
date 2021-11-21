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
        public bool AddData(string id, string name, string phone, string a_id, string ca_id, string em_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandText = "Insert into tblStore values(@id,@n,@p,@a, @ca, @em)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@a", a_id);
            cmd.Parameters.AddWithValue("@ca", ca_id);
            cmd.Parameters.AddWithValue("@em", em_id);
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return r > 0;
        }
        public bool DeleteData(string id, string name, string phone, string a_id, string ca_id, string em_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandText = "Delete from tblStore where ID = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@a", a_id);
            cmd.Parameters.AddWithValue("@ca", ca_id);
            cmd.Parameters.AddWithValue("@em", em_id);
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return r > 0;
        }
        public bool UpdateData(string id, string name, string phone, string a_id, string ca_id, string em_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandText = "Update tblStore set Name = @n, Phone = @p, AddressID = @a, CategoryID = @ca, EmployeeID = @em where Id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@a", a_id);
            cmd.Parameters.AddWithValue("@ca", ca_id);
            cmd.Parameters.AddWithValue("@em", em_id);
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return r > 0;
        }
    }
}
