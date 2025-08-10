using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class QTVBus
    {
        public static bool SignInEmployee(QTVDTO emp)
        {
            try
            {
                string result = QTVDAO.SignInEmployee(emp);
                if (result != null) return true;
                else return false;
            }
            catch { return false; }
        }
        public static List<QTVDTO> GetListNV()
        {
            return QTVDAO.GetListNV();
        }
        public static bool updateNV(QTVDTO nvDTO)
        {
            try
            {
                QTVDAO.updateNV(nvDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
}
