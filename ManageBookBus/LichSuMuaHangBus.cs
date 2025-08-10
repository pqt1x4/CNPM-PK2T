using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;

namespace ManageBookBus
{
    public class LichSuMuaHangBus
    {
        private LichSuMuaHangDAO dao = new LichSuMuaHangDAO();

        public List<LichSuMuaHangDTO> GetLichSuMuaHang(string maKH)
        {
            return dao.GetLichSuMuaHang(maKH);
        }

        public float TinhTongTien(List<LichSuMuaHangDTO> lichSuList)
        {
            float tongTien = 0;
            foreach (var lichSu in lichSuList)
            {
                tongTien += lichSu.ThanhTien;
            }
            return tongTien;
        }
    }
}
