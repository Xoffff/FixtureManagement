using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Class()//夹具类表
        {
            return View();
        }

        public ActionResult Inout()//出入库管理
        {
            return View();
        }

        public ActionResult Purchase()//采购及报修
        {
            return View();
        }

        public ActionResult Handle()//处理
        {
            return View();
        }

        public ActionResult Verify()//审核
        {
            return View();
        }
        public ActionResult Data()//预警实时数据
        {
            return View();
        }
        public ActionResult Analysis()//分析
        {
            return View();
        }
        public ActionResult Person()//个人
        {
            return View();
        }
        public ActionResult Admin()//管理
        {
            return View();
        }
    }
}