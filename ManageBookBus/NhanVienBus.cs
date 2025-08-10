using ManageBookDTO;
using ManageStuDAO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class NhanVienBus
    {
        private static NhanVienDAO nhanVienDAO = new NhanVienDAO();


        public static bool AddEmployee(NhanVienDTO nv) // Thay AddCustomer bằng AddEmployee, KhachHangDTO bằng NhanVienDTO
        {
            try
            {
                NhanVienDAO.AddEmployee(nv); // Thay KhachHangDAO.AddCustomer bằng NhanVienDAO.AddEmployee
                return true;
            }
            catch { return false; }
        }
        public static bool UpdateEmployee(NhanVienDTO nv) { /* Logic sửa */ return true; }
        public static bool xoaNV(NhanVienDTO nvDTO)
        {
            try
            {
                NhanVienDAO.DeleteEmployee(nvDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SignInEmployee(NhanVienDTO emp)
        {
            try
            {
                string result = NhanVienDAO.SignInEmployee(emp);
                if (result != null) return true;
                else return false;
            }
            catch { return false; }
        }
        public static List<NhanVienDTO> GetListNV()
        {
            return NhanVienDAO.GetListNV();
        }
        public static bool updateNV(NhanVienDTO nvDTO)
        {
            try
            {
                NhanVienDAO.updateNV(nvDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static int CapNhatNhanVien(NhanVienDTO nv)
        {
            if (nv == null || string.IsNullOrEmpty(nv.MaNV))
                throw new ArgumentException("Mã Nhân Viên không hợp lệ!");
            if (string.IsNullOrEmpty(nv.TenNV))
                throw new ArgumentException("Tên Nhân Viên không được để trống!");
            if (!string.IsNullOrEmpty(nv.SDT) && nv.SDT.Length < 10)
                throw new ArgumentException("Số điện thoại phải có ít nhất 10 chữ số!");

            return NhanVienDAO.SuaNV(nv);
        }

        public DataTable LoadDanhSachNhanVien()
        {
            return nhanVienDAO.LayDanhSachNhanVien();
        }
    }
}
