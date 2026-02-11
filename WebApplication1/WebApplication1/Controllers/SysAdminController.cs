using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace WebApplication1.Controllers
{
    public class SysAdminController : Controller
    {
        // GET: SysAdmin
        public ActionResult Index()
        {
            return View("AdminLogin");
        }
        public ActionResult AdminLogin()
        {
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(Request.Params["loginId"]),
                LoginPwd=Request.Params["loginpwd"]
            };
            objAdmin = new SysAdminManger().AdminLogin(objAdmin);
            ViewData["info"]="欢迎"+objAdmin.AdminName;
            return View();
        }
    }
}