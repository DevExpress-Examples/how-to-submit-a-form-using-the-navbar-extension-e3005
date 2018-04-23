using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;
using DevExpress.Web.Mvc;

namespace Example.Controllers {
    [HandleError]
    public class HomeController : Controller {
        [HttpGet]
        public ActionResult Index() {
            ViewData["Message"] = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            MyModel model = new MyModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult PostValues(FormCollection form) {
            String actionName = form["actionName"];

            MyModel model = new MyModel();

            if (TryUpdateModel<MyModel>(model)) {
                if (actionName == "act1")
                    return RedirectToAction("PostValues1", model);
                else if (actionName == "act2")
                    return RedirectToAction("PostValues2", model);
            }

            return Content("Form was not submitted by the NavBar, or the Model was invalid :(");
        }

        public ActionResult PostValues1(MyModel model) {
            return Content(String.Format("Action 1 (memo: '{0}')", model.Text));
        }

        public ActionResult PostValues2(MyModel model) {
            return Content(String.Format("Action 2 (memo: '{0}')", model.Text));
        }
    }
}
