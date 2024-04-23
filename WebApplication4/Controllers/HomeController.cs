using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

[ValidateInput(false)]
public ActionResult GridViewPartial() {
   var model =new View_1();
    return PartialView("~/Views/Home/_GridViewPartial.cshtml", model);
}

[HttpPost, ValidateInput(false)]
public ActionResult GridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Customer item) {
   var model =new View_1();
    if(ModelState.IsValid) {
        try {
                        // Insert here a code to insert the new item in your model
                    }
        catch(Exception e) {
            ViewData["EditError"] = e.Message;
        }
    }
    else
        ViewData["EditError"] = "Please, correct all errors.";
    return PartialView("~/Views/Home/_GridViewPartial.cshtml", model);
}
[HttpPost, ValidateInput(false)]
public ActionResult GridViewPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Customer item) {
   var model =new View_1();
    if(ModelState.IsValid) {
        try {
                        // Insert here a code to update the item in your model
                    }
        catch(Exception e) {
            ViewData["EditError"] = e.Message;
        }
    }
    else
        ViewData["EditError"] = "Please, correct all errors.";
    return PartialView("~/Views/Home/_GridViewPartial.cshtml", model);
}
[HttpPost, ValidateInput(false)]
public ActionResult GridViewPartialDelete(System.Int32 CustomerID) {
   var model =new View_1();
    if(CustomerID >= 0) {
        try {
                        // Insert here a code to delete the item from your model
                    }
        catch(Exception e) {
            ViewData["EditError"] = e.Message;
        }
    }
    return PartialView("~/Views/Home/_GridViewPartial.cshtml", model);
}
    }
}