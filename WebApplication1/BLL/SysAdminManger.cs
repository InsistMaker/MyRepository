using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Web;
//using System.Net.Http;

namespace BLL
{
    public class SysAdminManger
    {
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            objAdmin = new SysAdminService().AdminLogin(objAdmin);
            if (objAdmin !=null)
            {
                HttpContext.Current.Session["CurrentName"] = objAdmin;
            }
            return objAdmin;
        }
    }
}
