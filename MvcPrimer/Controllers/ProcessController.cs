using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPrimer.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index2()
        {
            var processes = System.Diagnostics.Process.GetProcesses();
            ViewBag.MyProcesses = processes;
            return View();
        }

        public ActionResult Index()
        {
            return View(System.Diagnostics.Process.GetProcesses());
        }

        public ActionResult Details(int id)
        {
            var proc = System.Diagnostics.Process.GetProcessById(id);
            return View(proc);
        }

    }
}