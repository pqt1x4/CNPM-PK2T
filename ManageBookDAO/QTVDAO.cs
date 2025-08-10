using ManageBookDTO;
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
    public class QTVDAO
    {
        public static string SignInEmployee(QTVDTO employee)
        {
            try
            {
                string query = "Select *From QTV Where Email = '" + employee.Email + "' and SDT = '" + employee.SDT + "'";
                DataTable dataTable = DataProvider.TruyVan_LayDuLieu(query);
                if (dataTable.Rows.Count > 0)
                {
                    employee.MaQTV = dataTable.Rows[0]["MaQTV"].ToString();
                    employee.TenQTV = dataTable.Rows[0]["TenQTV"].ToString();
                    employee.NgSinh = dataTable.Rows[0]["NgSinh"].ToString();
                    employee.Phai = dataTable.Rows[0]["Phai"].ToString();
                    employee.DiaChi = dataTable.Rows[0]["DiaChi"].ToString();
                    employee.Email = dataTable.Rows[0]["Email"].ToString();
                    employee.SDT = dataTable.Rows[0]["SDT"].ToString();
                    return employee.TenQTV;
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }

        public static List<QTVDTO> GetListNV()
        {
            List<QTVDTO> listQTV = new List<QTVDTO>();
            try
            {
                string query = "Select * From QTV";

                DataTable dtQTV = DataProvider.TruyVan_LayDuLieu(query);
                foreach (DataRow row in dtQTV.Rows)
                {
                    QTVDTO QTVDTO = new QTVDTO
                    {
                        MaQTV = row["MaQTV"].ToString(),
                        TenQTV = row["TenQTV"].ToString(),
                        NgSinh = row["NgSinh"].ToString(),
                        Phai = row["Phai"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        Email = row["Email"].ToString(),
                        SDT = row["SDT"].ToString(),
                    };

                    listQTV.Add(QTVDTO);
                }
                return listQTV;
            }
            catch
            {
                listQTV.Clear();
            }
            return listQTV;
        }
        public static void updateNV(QTVDTO qtvDTO)
        {
            string query = @"UPDATE QTV 
                 SET TenQTV = @TenQTV, NgSinh = @NgSinh, Phai = @Phai, DiaChi = @DiaChi, Email = @Email, SDT = @SDT 
                 WHERE MaQTV = @MaQTV";

            SqlParameter[] parameters =
            {
            new SqlParameter("@MaQTV", qtvDTO.MaQTV),
            new SqlParameter("@TenQTV", qtvDTO.TenQTV),
            new SqlParameter("@NgSinh", qtvDTO.NgSinh),
            new SqlParameter("@Phai", qtvDTO.Phai),
            new SqlParameter("@DiaChi", qtvDTO.DiaChi),
            new SqlParameter("@Email", qtvDTO.Email),
            new SqlParameter("@SDT", qtvDTO.SDT)
        };

            DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
        }
    }
    
}
