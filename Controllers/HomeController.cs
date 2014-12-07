using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSubCells.Models;

namespace WebSubCells.Controllers
{
    public class HomeController : Controller
    {
        SubCellsDB db = new SubCellsDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            var model = db.SubCellCode;
            return View(model);
        }

    }
}
