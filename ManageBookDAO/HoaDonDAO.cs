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
    public class HoaDonDAO
    {
        public static DataTable GetHoaDonData(string maKH)
        {
            string sql = @"
            SELECT Sach.MaSach, Sach.TenSach, GioHang.SoLuong, DichVu.MaDV, 
                   CASE 
                       WHEN DichVu.TenDV = 'bán' THEN (DichVu.GiaTien * GioHang.SoLuong) 
                       WHEN DichVu.TenDV = 'thuê' THEN (1 * DichVu.GiaTien * GioHang.SoLuong) 
                       ELSE 0 
                   END AS ThanhTien 
            FROM GioHang 
            INNER JOIN KhachHang ON GioHang.MaKH = KhachHang.MaKH 
            INNER JOIN Sach ON GioHang.MaSach = Sach.MaSach 
            INNER JOIN DichVu ON GioHang.MaDV = DichVu.MaDV
            WHERE GioHang.MaKH = @MaKH";

            // Tạo tham số @MaKH
            SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MaKH", SqlDbType.VarChar) { Value = maKH }
            };

            try
            {
                // Gọi phương thức TruyVan_LayDuLieu và truyền tham số
                return DataProvider.TruyVan_LayDuLieu(sql, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hóa đơn: " + ex.Message);
            }
        }

        public static DataTable GetDoanhThuTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT 
                                SUM(SoLuong) AS TongSoLuong,
                                SUM(ThanhTien) AS TongDoanhThu                                
                            FROM HoaDon
                            WHERE NgayMua BETWEEN @StartDate AND @EndDate";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startDate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = endDate }
            };

            try
            {
                return DataProvider.TruyVan_LayDuLieu(query, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hóa đơn: " + ex.Message);
            }
        }


        //public static int GetTongSoLuong()
        //{
        //    string query = "SELECT SUM(SoLuong) AS TongSoLuong FROM GioHang";
        //    try
        //    {
        //        object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);
        //        return result != DBNull.Value && result != null ? Convert.ToInt32(result) : 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi khi lấy tổng số lượng: " + ex.Message);
        //    }
        //}


        //public static decimal GetTongTien()
        //{
        //    string query = @"SELECT SUM(CASE 
        //                                   WHEN DichVu.TenDV = 'bán' THEN (DichVu.GiaTien * GioHang.SoLuong) 
        //                                   WHEN DichVu.TenDV = 'thuê' THEN (1 * DichVu.GiaTien * GioHang.SoLuong) 
        //                                   ELSE 0 
        //                               END) AS TongTien
        //                   FROM GioHang 
        //                   INNER JOIN DichVu ON GioHang.MaDV = DichVu.MaDV
        //                   WHERE GioHang.MaKH = @MaKH";
        //    try
        //    {
        //        object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);
        //        return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi khi tính tổng thành tiền: " + ex.Message);
        //    }
        //}
    }
}

