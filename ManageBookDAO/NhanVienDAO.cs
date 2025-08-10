using ManageBookDTO;
using ManageStuDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangeBookDAO
{
    public class NhanVienDAO
    {
        private static string connectionString = "Data Source=LAPTOP-DP4A2PVS\\SQLEXPRESS; Initial Catalog=BookStore_Management; Integrated Security=True; TrustServerCertificate = True;";
        public static void AddEmployee(NhanVienDTO employee) // Thay AddCustomer bằng AddEmployee, KhachHangDTO bằng NhanVienDTO
        {
            try
            {
                string query = "INSERT INTO NhanVien (MaNV, TenNV, NgSinh, Phai, DiaChi, SDT, Email) VALUES (@MaNV, @TenNV, @NgSinh, @Phai, @DiaChi, @SDT, @Email)"; // Thay KhachHang bằng NhanVien, cập nhật các cột
                SqlParameter[] parameters =
                {
            new SqlParameter("@MaNV", employee.MaNV),
            new SqlParameter("@TenNV", employee.TenNV),
            new SqlParameter("@NgSinh", employee.NgSinh),
            new SqlParameter("@Phai", employee.Phai),
            new SqlParameter("@DiaChi", employee.DiaChi),
            new SqlParameter("@SDT", employee.SDT),
            new SqlParameter("@Email", employee.Email)
        };
                DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters); // Giữ nguyên cách gọi
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi khi thêm nhân viên: " + ex.Message); // Cập nhật thông báo lỗi
                throw;
            }
        }
        public static string SignInEmployee(NhanVienDTO employee)
        {
            try
            {
                string query = "Select *From NhanVien Where Email = '" + employee.Email + "' and SDT = '" + employee.SDT + "'";
                DataTable dataTable = DataProvider.TruyVan_LayDuLieu(query);
                if (dataTable.Rows.Count > 0)
                {
                    employee.MaNV = dataTable.Rows[0]["MaNV"].ToString();
                    employee.TenNV = dataTable.Rows[0]["TenNV"].ToString();
                    employee.NgSinh = dataTable.Rows[0]["NgSinh"].ToString();
                    employee.Phai = dataTable.Rows[0]["Phai"].ToString();
                    employee.DiaChi = dataTable.Rows[0]["DiaChi"].ToString();
                    employee.Email = dataTable.Rows[0]["Email"].ToString();
                    employee.SDT = dataTable.Rows[0]["SDT"].ToString();
                    return employee.TenNV;
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }
        public static void DeleteEmployee(NhanVienDTO nvDTO)
        {
            DataProvider.TruyVan_XuLy("Delete From NhanVien Where MaNV = " + "'" + nvDTO.MaNV + "'");
        }
        public static List<NhanVienDTO> GetListNV()
        {
            List<NhanVienDTO> listNV = new List<NhanVienDTO>();
            try
            {
                string query = "Select * From NhanVien";

                DataTable dtNV = DataProvider.TruyVan_LayDuLieu(query);
                foreach (DataRow row in dtNV.Rows)
                {
                    NhanVienDTO NVDTO = new NhanVienDTO
                    {
                        MaNV = row["MaNV"].ToString(),
                        TenNV = row["TenNV"].ToString(),
                        NgSinh = row["NgSinh"].ToString(),
                        Phai = row["Phai"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        Email = row["Email"].ToString(),
                        SDT = row["SDT"].ToString(),
                    };

                    listNV.Add(NVDTO);
                }
                return listNV;
            }
            catch
            {
                listNV.Clear();
            }
            return listNV;
        }


        public static int SuaNV(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE NhanVien
                       SET TenNV = @TenNV, NgSinh = @NgSinh, Phai = @Phai,
                           DiaChi = @DiaChi, SDT = @SDT, Email = @Email
                       WHERE MaNV = @MaNV";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@NgSinh", nv.NgSinh);
                cmd.Parameters.AddWithValue("@Phai", nv.Phai);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                cmd.Parameters.AddWithValue("@Email", nv.Email);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }


        public DataTable LayDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaNV, TenNV, NgSinh, Phai, DiaChi, SDT, Email FROM NhanVien";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static void updateNV(NhanVienDTO nvDTO)
        {
            string query = @"UPDATE NhanVien 
                         SET TenNV = @TenNV, NgSinh = @NgSinh, Phai = @Phai, DiaChi = @DiaChi, Email = @Email, SDT = @SDT 
                         WHERE MaNV = @MaNV";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@MaNV", nvDTO.MaNV),
                    new SqlParameter("@TenNV", nvDTO.TenNV),
                    new SqlParameter("@NgSinh", nvDTO.NgSinh),
                    new SqlParameter("@Phai", nvDTO.Phai),
                    new SqlParameter("@DiaChi", nvDTO.DiaChi),
                    new SqlParameter("@Email", nvDTO.Email),
                    new SqlParameter("@SDT", nvDTO.SDT)
                };

            DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
        }
    }
}
