using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(string name, int salary)
        {

            var model = new DemoModel
            {
                Name = name,
                Salary = salary
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult PostToPrivacy()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult PostToPrivacy(/*string name, int salary*/ DemoModel viewModel)
        {


            //ViewData["OtherName"] = "Pelle";
            //ViewBag.Salary = 50;

            var model = new DemoModel
            {
                Name = viewModel.Name,
                Salary = viewModel.Salary
            };

            return View(model);
        }


    }
}