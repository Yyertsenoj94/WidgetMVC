using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WidgetMVC.Models;

namespace WidgetMVC.Controllers
{
    public class WidgetController : Controller
    {
        WidgetDbContext db = new WidgetDbContext();
        CreateWidgetVM CreateVM = new CreateWidgetVM();
        // GET: Widget
        public ActionResult Index()
        {
            IEnumerable<Widget> Widgets = db.Hammers.ToList();
            return View(Widgets);
        }

        public ActionResult Create()
        {
            CreateVM.Types = db.Types.ToList();
            CreateVM.PrimaryTypes = db.Types.Select(item => item.PrimaryType).Distinct().ToList();

            return View(CreateVM);
        }

        [HttpPost]
        public ActionResult Edit(int? id) 
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoadSubTypes(string type)
        {
            List<string> SubCategories = db.Types.Where(item => item.PrimaryType == type).Select(c => c.SubType).ToList();
            
            return Json(SubCategories, JsonRequestBehavior.AllowGet);
        }
    }
}