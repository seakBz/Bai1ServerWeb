using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baitap1_Server.Models;
using Baitap1_Server.Helper;

namespace Baitap1_Server.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult XuLy(string _HocKi, string _NamHoc)
        {
            List<BaiTap> data = BaiTap.initData();
            foreach (BaiTap u in data)
            {
                if (u.HocKi == _HocKi && u.NamHoc == _NamHoc)
                {
                    string text = readFileText.docFile(Server.MapPath(u.LinkFileDestrip));
                    ViewBag.Destrip = text;
                    ViewData["Data"] = u;
                    break;
                }
                else
                {
                    ViewData["listData"] = null;
                }
            }
            return View();
        }
    }
}