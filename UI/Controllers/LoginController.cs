using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult submit(string username, string userpassword)
        {
            //引入数据库
            if (username == "admin" && userpassword == "123")
            {
                return Json(new
                {
                    Success = true,
                });

            }
             else
            {
                    return Json(new
                    {
                        Success = false,
                        Message = "当前用户不存在"
                    });
             }

        }

            
    }
}