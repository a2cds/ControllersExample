using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ControllersExample.Models;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ExampleModel obj = new ExampleModel { Sentence = "Criando Controller" };
            return View(obj);
        }

        public IActionResult ParamExample(string id)
        {
            return Content("Parametro id é " + id);
        }

        public IActionResult RouteDataExample()
        {
            string ctrl = (string)RouteData.Values["controller"];
            string act = (string)RouteData.Values["action"];
            string id = (string)RouteData.Values["id"];
            return Content($"Controller:{ctrl} - Action:{act} - Parametro:{id}");
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.Message = "Testando o ViewBag";
            return View();
        }

        public IActionResult ViewDataExample()
        {
            ViewData["Message"] = "Testando o ViewData";
            return View();
        }
    }
}