using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStuDAO
{
    public class DataProvider
    {
        public static string connectionString
        {
            get
            {
                return "Data Source=PQT; Initial Catalog=BookStore_Management; Integrated Security=True; TrustServerCertificate = True;";
            }
        }

        public static bool TruyVan_XuLy(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        // Nếu có tham số, thêm chúng vào câu lệnh
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần thiết và trả về false
                Console.WriteLine("Lỗi khi thực thi câu lệnh SQL: " + ex.Message);
                return false;
            }
        }

        public static DataTable TruyVan_LayDuLieu(string sql, CommandType commandType = CommandType.Text, SqlParameter[] parameters = null)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.CommandType = commandType;

                    // Thêm các tham số nếu có
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static void ExcuteNonQuery(string sql, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public static DataTable SelectData(string sql, CommandType cmdType, SqlParameter[] paras)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            connect.Close();
            return dataTable;
        }
        public static object ExecuteScalar(string sql, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;

            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }

            object result = cmd.ExecuteScalar();
            connect.Close();

            return result;
        }
    }
}
