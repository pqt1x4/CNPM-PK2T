using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words.Lists;
using ManageBookDTO;
using ManageStuDAO;



namespace MangeBookDAO
{
    public class LichSuMuaHangDAO
    {
        public List<LichSuMuaHangDTO> GetLichSuMuaHang(string MaKH)
        {
            List<LichSuMuaHangDTO> list = new List<LichSuMuaHangDTO>();
            try
            {

                string query = @"SELECT * FROM HoaDon WHERE MaKH = @MaKH;";

                var parameters = new SqlParameter[]
                        {
                            new SqlParameter("@MaKH", SqlDbType.VarChar) { Value = MaKH }
                        };

                DataTable dtLS = DataProvider.TruyVan_LayDuLieu(query, CommandType.Text, parameters);

                foreach (DataRow row in dtLS.Rows)
                {
                    LichSuMuaHangDTO LSDTO = new LichSuMuaHangDTO
                    {
                        TenSach = row["TenSach"].ToString(),
                        TenDV = row["TenDV"].ToString(),
                        SoLuong = Convert.ToInt32(row["SoLuong"]),
                        ThanhTien = Convert.ToSingle(row["ThanhTien"]),
                        NgayMua = DateTime.TryParse(row["NgayMua"].ToString(), out DateTime ngayMua) ? ngayMua.ToString("dd/MM/yyyy") : string.Empty
                    };
                    list.Add(LSDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                list.Clear();
            }

            return list;
        }


    }
}
