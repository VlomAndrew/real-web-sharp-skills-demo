using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainWebApp.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index(int? result)
        {

            ViewBag.result = result ?? 0;
            return View();
        }

        [HttpGet]
        public ActionResult Calc(string expression)
        {
            int? res = null;
            try
            {
                 res = (int) (new DataTable().Compute(expression, null));
            }
            catch (Exception e)
            {
                
            }

            return RedirectToAction("Index", new {result = res});
        }
    }
}