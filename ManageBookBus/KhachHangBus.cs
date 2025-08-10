using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class KhachHangBus
    {
        private KhachHangDAO khachHangDAO = new KhachHangDAO();

        public static bool AddCustomer(KhachHangDTO cus)
        {
            try
            {
                KhachHangDAO.AddCustomer(cus);
                return true;
            }
            catch { return false; }
        }

        public KhachHangDTO GetThongTinKhachHang(string MaKH)
        {
            return khachHangDAO.GetThongTinKhachHang(MaKH);
        }
        public static bool SignInCustomer(KhachHangDTO cus)
        {
            try
            {
                string result = KhachHangDAO.SignIn(cus);
                if(result != null) return true;
                else return false;
            }
            catch { return false; }
        }
        public static List<KhachHangDTO> GetListKH()
        {
            return KhachHangDAO.GetListKH();
        }

        public static bool suaKH(KhachHangDTO KHDTO)
        {
            try
            {
                KhachHangDAO.suaKH(KHDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }
        public static bool xoaKH(KhachHangDTO KHDTO)
        {
            try
            {
                KhachHangDAO.xoaKH(KHDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static List<KhachHangDTO> TimKiemKHTheoTen(string tenKH)
        {
            return KhachHangDAO.TimKiemKHTheoTen(tenKH);
        }

    }
}
