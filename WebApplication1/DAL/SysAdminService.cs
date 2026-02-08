using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SysAdminService
    {
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "select AdminName from admins where loginID={0} and loginPwd='{1}'";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            
            try
            {
                SqlDataReader objReader = Helper.SqlHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.AdminName= objReader["AdminName"].ToString();
                    objReader.Close();
                }
                else
                {
                    objAdmin = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objAdmin;
        }
    }
}
