using DevExpress.Web.Mvc;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models; 

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        TrainingProjectEntities1 context = new TrainingProjectEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TOA SE are happy to present this training project. Here you can not only get experience working with a database, but also utilizing MVC architecture ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

[ValidateInput(false)]
public ActionResult GridViewPartial() {
            var model = context.View_1.ToList();
    return PartialView("~/Views/Home/_GridViewPartial.cshtml", model);
}

[HttpPost, ValidateInput(false)]
public ActionResult GridViewPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Customer item) {
            var model = context.View_1.ToList();
    if (ModelState.IsValid) {
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
            var model = context.View_1.ToList();
    if (ModelState.IsValid) {
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
            var model = context.View_1.ToList();
    if (CustomerID >= 0) {
        try {
                        // Insert here a code to delete the item from your model
                    }
        catch(Exception e) {
            ViewData["EditError"] = e.Message;
        }
    }
    return PartialView("~/Views/Home/_GridViewPartial.cshtml", model);
}

        WebApplication4.Models.TrainingProjectEntities1 db = new WebApplication4.Models.TrainingProjectEntities1();

        [ValidateInput(false)]
        public ActionResult GridViewPartial5()
        {
            var model = db.Orders;
            return PartialView("~/Views/Home/_GridViewPartial5.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartial5AddNew([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Order item)
        {
            var model = db.Orders;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/Home/_GridViewPartial5.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartial5Update([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Order item)
        {
            var model = db.Orders;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.OrderID == item.OrderID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/Home/_GridViewPartial5.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartial5Delete(System.Int32 OrderID)
        {
            var model = db.Orders;
            if (OrderID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.OrderID == OrderID);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/Home/_GridViewPartial5.cshtml", model.ToList());
        }

        WebApplication4.Models.TrainingProjectEntities1 db1 = new WebApplication4.Models.TrainingProjectEntities1();

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            var model = db1.Orders;
            return PartialView("~/Views/Home/_GridView1Partial.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Order item)
        {
            var model = db1.Orders;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/Home/_GridView1Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Order item)
        {
            var model = db1.Orders;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.OrderID == item.OrderID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db1.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/Home/_GridView1Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialDelete(System.Int32 OrderID)
        {
            Console.WriteLine("OrderID received in GridView1PartialDelete: " + OrderID);
            string script = $"<script>console.log('OrderID received in GridView1PartialDelete: {OrderID}');</script>";
            ViewData["ConsoleLogScript"] = script;
            var model = db1.Orders;
            if (OrderID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.OrderID == OrderID);
                    if (item != null)
                        model.Remove(item);
                    db1.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/Home/_GridView1Partial.cshtml", model.ToList());
        }

        WebApplication4.Models.TrainingProjectEntities1 db2 = new WebApplication4.Models.TrainingProjectEntities1();

        [ValidateInput(false)]
        public ActionResult GridView2Partial()
        {
            var model = db2.Customers;
            return PartialView("~/Views/Home/_GridView2Partial.cshtml", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView2PartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Customer item)
        {
            var model = db2.Customers;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/Home/_GridView2Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView2PartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] WebApplication4.Models.Customer item)
        {
            var model = db2.Customers;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.CustomerID == item.CustomerID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db2.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("~/Views/Home/_GridView2Partial.cshtml", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView2PartialDelete(System.Int32 CustomerID)
        {
            var model = db2.Customers;
            if (CustomerID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.CustomerID == CustomerID);
                    if (item != null)
                        model.Remove(item);
                    db2.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("~/Views/Home/_GridView2Partial.cshtml", model.ToList());
        }
    }
}