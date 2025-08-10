using ManageBookDTO;
using ManageStuDAO;
using SkiaSharp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ManageBookDAO
{
    public class SachDAO
    {
        public static List<SachDTO> GetListBook()
        {
            List<SachDTO> listSach = new List<SachDTO>();
            try
            {
                string query = @"SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, Sach.SoLuong, 
                                    MAX(CASE WHEN DichVu.TenDV = N'Bán' THEN DichVu.GiaTien END) AS GiaBan, Sach.MaNV 
                                    FROM Sach 
                                    LEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach 
                                    GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, Sach.MaNV, Sach.SoLuong;";

                DataTable dtSach = DataProvider.TruyVan_LayDuLieu(query);
                foreach (DataRow row in dtSach.Rows)
                {
                    SachDTO sachDTO = new SachDTO
                    {
                        MaSach = row["MaSach"].ToString(),
                        TenSach = row["TenSach"].ToString(),
                        TacGia = row["TacGia"].ToString(),
                        TheLoai = row["TheLoai"].ToString(),
                        NXB = row["NXB"].ToString(),
                        SoLuong = row["SoLuong"] != DBNull.Value ? Convert.ToInt32(row["SoLuong"]) : 0,
                        MaNV = row["MaNV"].ToString(),
                        GiaBan = row["GiaBan"] != DBNull.Value ? Convert.ToSingle(row["GiaBan"]) : 0,
                        
                    };

                    listSach.Add(sachDTO);
                }
                return listSach;
            }
            catch
            {
                listSach.Clear();
            }
            return listSach;
        }
        public static string GetNewMaSach()
        {
            try
            {
                string query = "SELECT MAX(MaSach) FROM Sach";
                object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);

                if (result == null || result == DBNull.Value)
                {
                    return "S.001";
                }

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

                string newMaSach = $"{prefix}{newNumber:D3}";
                return newMaSach;


            }
            catch
            {
                return "S.001";
            }
        }


        public static void themSach(SachDTO sachDTO)
        {
            try
            {
                DataProvider.TruyVan_XuLy("Insert into Sach values('" + sachDTO.MaSach + "',N'" + sachDTO.TenSach + "',N'"
                  + sachDTO.TacGia + "',N'" + sachDTO.NXB + "',N'" + sachDTO.TheLoai + "',N'" + sachDTO.SoLuong + "',N'" + sachDTO.MaNV + "')");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm sách: {ex.Message}");
                throw ex;
            }

        }
        public static void suaSach(SachDTO sachDTO)
        {

            string query = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, NXB = @NXB, TheLoai=@TheLoai, SoLuong=@SoLuong , MaNV=@MaNV WHERE MaSach=@MaSach";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenSach", sachDTO.TenSach),
                new SqlParameter("@TacGia", sachDTO.TacGia),
                new SqlParameter("@NXB", sachDTO.NXB),
                new SqlParameter("@TheLoai", sachDTO.TheLoai),
                new SqlParameter("@MaSach", sachDTO.MaSach),
                new SqlParameter("@MaNV", sachDTO.MaNV),
                new SqlParameter("@SoLuong", sachDTO.SoLuong)
            };

            DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
        }

        public static void xoaSach(SachDTO sachDTO)
        {
            DataProvider.TruyVan_XuLy("Delete From Sach Where MaSach = " + "'" + sachDTO.MaSach + "'");
        }

        public static List<SachDTO> TimKiemSachTheoTuKhoa(string[] keywords)
        {
            List<SachDTO> listSach = new List<SachDTO>();
            try
            {
                // Tạo điều kiện tìm kiếm động dựa trên các từ khóa
                string sql = @"SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, Sach.MaNV, Sach.SoLuong, 
                       MAX(CASE WHEN DichVu.TenDV = N'Bán' THEN DichVu.GiaTien END) AS GiaBan,
                       MAX(CASE WHEN DichVu.TenDV = N'Thuê' THEN DichVu.GiaTien END) AS GiaThue
                FROM Sach 
                LEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach
                WHERE "; // Thêm WHERE vào câu SQL

                // Thêm điều kiện tìm kiếm cho mỗi từ khóa
                List<SqlParameter> parameters = new List<SqlParameter>();
                for (int i = 0; i < keywords.Length; i++)
                {
                    string paramName = "@Keyword" + i;
                    sql += $"Sach.TenSach LIKE {paramName} OR Sach.MaSach LIKE {paramName} OR Sach.TacGia LIKE {paramName} OR Sach.NXB LIKE {paramName} OR Sach.TheLoai LIKE {paramName} ";

                    if (i < keywords.Length - 1)
                        sql += " OR ";

                    parameters.Add(new SqlParameter(paramName, "%" + keywords[i] + "%"));
                }

                // Thêm phần GROUP BY sau khi đã xử lý xong điều kiện WHERE
                sql += " GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, Sach.MaNV, Sach.SoLuong;"; // Thêm MaNV vào GROUP BY

                // Thực hiện truy vấn với các tham số
                DataTable dtSach = DataProvider.SelectData(sql, CommandType.Text, parameters.ToArray());

                // Chuyển đổi dữ liệu từ DataTable thành danh sách SachDTO
                foreach (DataRow row in dtSach.Rows)
                {
                    SachDTO sachDTO = new SachDTO
                    {
                        MaSach = row["MaSach"].ToString(),
                        TenSach = row["TenSach"].ToString(),
                        TacGia = row["TacGia"].ToString(),
                        TheLoai = row["TheLoai"].ToString(),
                        NXB = row["NXB"].ToString(),
                        SoLuong = row["SoLuong"] != DBNull.Value ? Convert.ToInt32(row["SoLuong"]) : 0,
                        GiaBan = row["GiaBan"] != DBNull.Value ? Convert.ToSingle(row["GiaBan"]) : 0f, // Sửa tại đây
                      
                    };
                    listSach.Add(sachDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm sách: " + ex.Message);
                throw; // Ném lại ngoại lệ mà không tạo lại đối tượng
            }
            return listSach;
        }

        public static bool KiemTraTrungSach(string maSach, string tenSach)
        {
            if (string.IsNullOrEmpty(maSach) && string.IsNullOrEmpty(tenSach))
                return false;

            string query = "SELECT COUNT(*) FROM Sach WHERE MaSach = @MaSach OR TenSach = @TenSach";
            SqlParameter[] parameters = {
                new SqlParameter("@MaSach", maSach),
                new SqlParameter("@TenSach", tenSach)
            };

            object result = DataProvider.ExecuteScalar(query, CommandType.Text, parameters);
            int count = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);

            return count > 0;
        }

    }
}
