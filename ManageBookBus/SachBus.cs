﻿using ManageBookDTO;
using ManageBookDAO;
using MangeBookDAO;
namespace ManageBookBus
{
    public class SachBus
    {
        public static List<SachDTO> GetListBook()
        {
            return SachDAO.GetListBook();
        }

        public static bool themSach(SachDTO sachDTO)
        {
            try
            {
                SachDAO.themSach(sachDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool suaSach(SachDTO sachDTO)
        {
            try
            {
                 SachDAO.suaSach(sachDTO);
                 return true;
            }
            catch
            {

                return false;
            }
        }
        public static bool xoaSach(SachDTO sachDTO)
        {
            try
            {
                SachDAO.xoaSach(sachDTO);
                return true;
            }
            catch
            {

                return false;
            }
        }
        public static bool KiemTraSachTonTai(string maSach, string tenSach)
        {
             return SachDAO.KiemTraTrungSach(maSach, tenSach);
        }

    }
}
