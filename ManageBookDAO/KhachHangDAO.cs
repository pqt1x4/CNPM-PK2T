using ManageBookDTO;
using ManageStuDAO;
using System.Data;
using System.Data.SqlClient;

namespace MangeBookDAO
{
    public class KhachHangDAO
    {
        public static List<KhachHangDTO> GetListKH()
        {
            List<KhachHangDTO> listKH = new List<KhachHangDTO>();
            try
            {
                string query = "Select * From KhachHang";

                DataTable dtKH = DataProvider.TruyVan_LayDuLieu(query);
                foreach (DataRow row in dtKH.Rows)
                {
                    KhachHangDTO khDTO = new KhachHangDTO
                    {
                        MaKH = row["MaKH"].ToString(),
                        TenKH = row["TenKH"].ToString(),
                        Email = row["Email"].ToString(),
                        SDT = row["SDT"].ToString(),
                    };

                    listKH.Add(khDTO);
                }
                return listKH;
            }
            catch
            {
                listKH.Clear();
            }
            return listKH;
        }

        public KhachHangDTO GetThongTinKhachHang(string MaKH)
        {
            KhachHangDTO khachHang = null;
            try
            {
                string query = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKH", SqlDbType.VarChar) { Value = MaKH }
                };

                DataTable dt = DataProvider.TruyVan_LayDuLieu(query, CommandType.Text, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    khachHang = new KhachHangDTO
                    {
                        MaKH = row["MaKH"].ToString(),
                        TenKH = row["TenKH"].ToString(),
                        Email = row["Email"].ToString(),
                        SDT = row["SDT"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            return khachHang;
        }
        public static string GetNewMaKH()
        {
            try
            {
                string query = "Select MAX(MaKH) From KhachHang";
                object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);
                if (result == null || result == DBNull.Value)
                    return "KH.001";

                string resultStr = result.ToString();
                int index = 0;
                while (index < resultStr.Length && !char.IsDigit(resultStr[index]))
                {
                    index++;
                }

                string prefix = resultStr.Substring(0, index);
                string numericPart = resultStr.Substring(index);

                int currentNumber = int.Parse(numericPart);
                int newNumber = currentNumber + 1;

                string newClassID = $"{prefix}{newNumber:D3}";
                return newClassID;
            }
            catch { return "KH.001"; }
        }
        public static void AddCustomer(KhachHangDTO customer)
        {
            try
            {
                string query = "INSERT INTO KhachHang (MaKH, TenKH, Email, SDT) VALUES (@MaKH, @TenKH, @Email, @SDT)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaKH", customer.MaKH),
                    new SqlParameter("@TenKH", customer.TenKH),
                    new SqlParameter("@Email", customer.Email),
                    new SqlParameter("@SDT", customer.SDT)
            };
                DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi khi thêm khách hàng: " + ex.Message);
                throw;
            }
        }

        public static void suaKH(KhachHangDTO khachHangDTO)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH, Email = @Email, SDT = @SDT WHERE MaKH = @MaKH";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaKH", khachHangDTO.MaKH),
                new SqlParameter("@TenKH", khachHangDTO.TenKH),
                new SqlParameter("@Email", khachHangDTO.Email),
                new SqlParameter("@SDT", khachHangDTO.SDT)
            };


            DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
        }
        public static void xoaKH(KhachHangDTO khachHangDTO)
        {
            DataProvider.TruyVan_XuLy("Delete From KhachHang Where MaKH = " + "'" + khachHangDTO.MaKH + "'");
        }


        public static List<KhachHangDTO> TimKiemKHTheoTen(string tenKH)
        {
            List<KhachHangDTO> listKH = new List<KhachHangDTO>();
            try
            {
                string query = "Select * From KhachHang Where TenKH LIKE @TenKH";
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@TenKH", "%" + tenKH + "%");

                DataTable dtKhachHang = DataProvider.SelectData(query, CommandType.Text, parameters);

                foreach (DataRow row in dtKhachHang.Rows)
                {
                    KhachHangDTO khachHangDTO = new KhachHangDTO
                    {
                        MaKH = row["MaKH"].ToString(),
                        TenKH = row["TenKH"].ToString(),
                        Email = row["Email"].ToString(),
                        SDT = row["SDT"].ToString()
                    };
                    listKH.Add(khachHangDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
                throw ex;
            }
            return listKH;
        }

        public static string SignIn(KhachHangDTO customer)
        {
            try
            {
                string query = "Select *From KhachHang Where Email = '" + customer.Email + "' and SDT = '" + customer.SDT + "'";
                DataTable dataTable = DataProvider.TruyVan_LayDuLieu(query);
                if (dataTable.Rows.Count > 0)
                {
                    customer.MaKH = dataTable.Rows[0]["MaKH"].ToString();
                    customer.TenKH = dataTable.Rows[0]["TenKH"].ToString();
                    customer.Email = dataTable.Rows[0]["Email"].ToString();
                    customer.SDT = dataTable.Rows[0]["SDT"].ToString();
                    return customer.TenKH;
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
