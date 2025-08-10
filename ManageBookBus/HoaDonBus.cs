using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ManageBookBus
{
    public class HoaDonBus
    {

        public DataTable GetHoaDonData(string maKH)
        {
            try
            {
                // Truyền tham số maKH vào phương thức GetHoaDonData của HoaDonDAO
                return HoaDonDAO.GetHoaDonData(maKH);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hóa đơn từ BUS: " + ex.Message);
            }
        }

        private HoaDonDAO hoaDonDAO = new HoaDonDAO();

        public static DataTable LayDoanhThuTheoThoiGian(DateTime starDate, DateTime endDate)
        {
            try
            {
                return HoaDonDAO.GetDoanhThuTheoKhoangThoiGian(starDate, endDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu hóa đơn từ BUS: " + ex.Message);
            }

        }

        //public int GetTongSoLuong()
        //{
        //    try
        //    {
        //        return HoaDonDAO.GetTongSoLuong();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi khi lấy tổng số lượng từ BUS: " + ex.Message);
        //    }
        //}


        //public decimal GetTongTien()
        //{
        //    try
        //    {
        //        return HoaDonDAO.GetTongTien();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi khi tính tổng thành tiền từ BUS: " + ex.Message);
        //    }
        //}
    }
}
