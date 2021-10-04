using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demosesstion1.Models;
namespace Demosesstion1.Controllers
{
    public class studenttController : Controller
    {
        public IActionResult Index()
        {

            return View("studentview");
        }

        public IActionResult Index1()
        {
            if (Request.Form["option"] == "1")
            {
                int id = Convert.ToInt32(Request.Form["textid"]);
                string name = Request.Form["textname"];
                int bsay = Convert.ToInt32(Request.Form["textbday"]);
                double Mark1 = Convert.ToDouble(Request.Form["textMark1"]);
                double Mark2 = Convert.ToDouble(Request.Form["textMark2"]);
                Schoolstudent schoolstd = new Schoolstudent();
                bool isvalid = schoolstd.check();
                if (isvalid == true)
                {
                    double avg1 = schoolstd.calc();
                    string messg = schoolstd.print(avg1);
                    ViewData["messege"] = messg;
                }
                return View("studentview");
            }


            else
            {
                int id = Convert.ToInt32(Request.Form["textid"]);
                string name = Request.Form["textname"];
                int bsay = Convert.ToInt32(Request.Form["textbday"]);
                double Mark1 = Convert.ToDouble(Request.Form["textMark1"]);
                double Mark2 = Convert.ToDouble(Request.Form["textMark2"]);
                double Hours1 = Convert.ToDouble(Request.Form["textHours1"]);
                double Hours2 = Convert.ToDouble(Request.Form["textHours2"]);

                Schoolstudent schoolstd = new Schoolstudent();
                bool isvalid = schoolstd.check();
                if (isvalid == true)
                {
                    double avg1 = schoolstd.calc();
                    string messg = schoolstd.print(avg1);
                    ViewData["messege"] = messg;
                }

                return View("studentview");
            }
        }
    }
}
