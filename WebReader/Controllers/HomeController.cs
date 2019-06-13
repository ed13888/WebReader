using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebReader.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> list = new List<string>();
        public ActionResult Index()
        {
            if (list.Count == 0)
            {
                var imgdir = "/Resource/C80";
                var path = HttpContext.Server.MapPath(imgdir);
                var dir = new DirectoryInfo(path);
                var files = dir.GetFiles();
                foreach (var file in files)
                {
                    list.Add(imgdir + "/" + file.Name);
                }
            }
            return View(list);
        }
    }
}