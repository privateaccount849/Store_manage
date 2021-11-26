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
        public bool AddData1(string Eid, string En, string P, string dob, string ad)
        {
            SqlCommand cmdE = new SqlCommand();
            cmdE.Connection = GetConnection();
            cmdE.Connection.Open();

            cmdE.CommandText = "Insert into tblEm1 values(@EmployeeID,@EmployeeName,@Phone,@DateofBirth,@Address)";
            cmdE.Parameters.AddWithValue("@EmployeeID", Eid);
            cmdE.Parameters.AddWithValue("@EmployeeName", En);
            cmdE.Parameters.AddWithValue("@Phone", P);
            cmdE.Parameters.AddWithValue("@DateofBirth", dob);
            cmdE.Parameters.AddWithValue("@Address", ad);
            int r = cmdE.ExecuteNonQuery();
            cmdE.Connection.Close();
            return r > 0;
        }
        public bool UpDateData1(string Eid, string En, string P, string dob, string ad)
        {
            SqlCommand cmdE = new SqlCommand();
            cmdE.Connection = GetConnection();
            cmdE.Connection.Open();
            cmdE.CommandText = "Update tblEm1 set En = @EmployeeName, P = @Phone, dob = @DateofBirth, ad = @Address where EmployeeID = @Eid";
            cmdE.Parameters.AddWithValue("@EmployeeID", Eid);
            cmdE.Parameters.AddWithValue("@EmployeeName", En);
            cmdE.Parameters.AddWithValue("@Phone", P);
            cmdE.Parameters.AddWithValue("@DateofBirth", dob);
            cmdE.Parameters.AddWithValue("@Address", ad);
            int r = cmdE.ExecuteNonQuery();
            cmdE.Connection.Close();
            return r > 0;
        }
        public bool DeleteData1(string Eid, string En, string P, string dob, string ad)
        {
            SqlCommand cmdE = new SqlCommand();
            cmdE.Connection = GetConnection();
            cmdE.Connection.Open();
            cmdE.CommandText = "Delete from tblEm1 where EmployeeID = Eid";
            cmdE.Parameters.AddWithValue("@EmployeeID", Eid);
            cmdE.Parameters.AddWithValue("@EmployeeName", En);
            cmdE.Parameters.AddWithValue("@Phone", P);
            cmdE.Parameters.AddWithValue("@DateofBirth", dob);
            cmdE.Parameters.AddWithValue("@Address", ad);
            int r = cmdE.ExecuteNonQuery();
            cmdE.Connection.Close();
            return r > 0;
        }
        public bool AddData3(string BillID, string Type, string Date, string EmployeeID, string StoreID)
        {
            SqlCommand cmdE = new SqlCommand();
            cmdE.Connection = GetConnection();
            cmdE.Connection.Open();
            cmdE.CommandText = "Insert into tblBill values(@BillID,@Type,@Date,@EmployeeID,@StoreID)";
            cmdE.Parameters.AddWithValue("@BillID", BillID);
            cmdE.Parameters.AddWithValue("@Type", Type);
            cmdE.Parameters.AddWithValue("@Date", Date);
            cmdE.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmdE.Parameters.AddWithValue("@Store", StoreID);
            int r = cmdE.ExecuteNonQuery();
            cmdE.Connection.Close();
            return r > 0;
        }
    }
}
