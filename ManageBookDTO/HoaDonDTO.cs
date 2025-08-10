using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookDTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; } 
        public string MaKH { get; set; } 
        public string MaSach { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public DateTime NgayMua { get; set; }
    }
}
