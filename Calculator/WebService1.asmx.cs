using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        [WebMethod(EnableSession = true)]
        public float sum(float a, char c, float b)
        {
            List<string> calcs;
            if (Session["calculation"] == null)
            {
                calcs = new List<string>();
            }
            else
            {
                calcs = (List<string>)Session["calculation"];

            }
            float res = 0;


            string calculations;
            switch (c)
            {
                case '+':
                    res = a + b;
                    calculations = a.ToString() + "+" + b.ToString() + " = " + res.ToString();
                    calcs.Add(calculations);

                    break;
                case '-':
                    res = a - b;
                    calculations = a.ToString() + "-" + b.ToString() + " = " + res.ToString();
                    calcs.Add(calculations);
                    break;
                case '*':
                    res = a * b;
                    calculations = a.ToString() + "*" + b.ToString() + " = " + res.ToString();
                    calcs.Add(calculations);
                    break;
                case '/':
                    res = a / b;
                    calculations = a.ToString() + "/" + b.ToString() + " = " + res.ToString();
                    calcs.Add(calculations);
                    break;
                case '^':
                    res = (float)Math.Pow(a,b);
                    calculations = a.ToString() + "^" + b.ToString() + " = " + res.ToString();
                    calcs.Add(calculations);
                    break;
                default:
                    Console.WriteLine("Operation didn't match");
                    break;
            }

            Session["calculation"] = calcs;

            return res;
        }

        [WebMethod(EnableSession = true)]
        public List<string> getcalc()
        {

            if (Session["calculation"] == null)
            {
                List<string> calcs = new List<string>();
                calcs.Add("no calculations yet");

                return calcs;
            }
            else
            {

                return (List<string>)Session["calculation"];

            }

        }
    }
}
