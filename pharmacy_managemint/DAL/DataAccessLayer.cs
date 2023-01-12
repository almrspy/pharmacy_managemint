using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace pharmacy_managemint.DAL
{
    class DataAccessLayer
    {
        
        public static string con= "Data Source=DESKTOP-GO0U66H\\DODO;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection cn;
        //open the connection
        public static void Open()
        {
            cn = new SqlConnection(con);
            cn.Open();
        }
        // close the conection
        public static void Close()
        {
            cn = new SqlConnection(con);
            cn.Close();
        }

        public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
        {
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            object o = cmd.ExecuteScalar();
            return o;
        }
        public static int ExecuteNonQuery(string query,CommandType type,params SqlParameter[]arr)
        {
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            int n = cmd.ExecuteNonQuery();
            return n;
        }
        public static DataTable ExecuteTable(string query, CommandType type,params SqlParameter[] arr)
        {
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;

        }

    }
}
