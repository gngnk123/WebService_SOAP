using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Services;
using Calculator.Models;
using Microsoft;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult EnterValues()
        {
            //WebService1 cl1 = new WebService1();
           // float res = cl1.sum(74, 13, 's');
           // CalculatorModel model = new CalculatorModel();
           // return Json(res, JsonRequestBehavior.AllowGet);
            return View();
        }


        [HttpPost]
        public ActionResult EnterValues(float a, char c, float b)
        {
            WebService1 cl1 = new WebService1();
            // float res = cl1.sum(74, 13, 's');
            // CalculatorModel model = new CalculatorModel();
            // return Json(res, JsonRequestBehavior.AllowGet);
            //float result = cl1.sum(a, c, b);
            ViewBag.Sum = " :" + cl1.sum(a, c, b);
            ViewBag.Getcalc = cl1.getcalc();



            //if (Session["calculation"] != null)
            //{
            //    var Values = Session["calculation"] as List<float>;
            //    Values.Add(result);
            //    Session["calculation"] = Values;
            //}
            //else
            //{
            //    var list = new List<float>();
            //    list.Add(result);
            //    Session["calculation"] =list;
            //}


            return View();
        }



        //[WebMethod]
        //public JsonResult Sum(CalculatorModel model)
        //{
        //    WebService1 cl1 = new WebService1();
        //    string hel = cl1.HelloWorld();
        //    int sum = model.Value1 + model.Value2;
        //    return Json( hel, JsonRequestBehavior.AllowGet);
        //}


    }
}