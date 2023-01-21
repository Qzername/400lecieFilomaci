using Microsoft.AspNetCore.Mvc;
using Server.Code;
using Server.Models;
using System.Diagnostics;

namespace Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpGet("[action]/{name}")]
        public IActionResult Person(string name)
        {
            string text = "<div><h1 class=\"text-center\">Nie znaleziono osoby</h1></div><div><h3 class=\"text-center\">Możliwe źle podany link</h1></div>";

            if (Database.DoesPersonExist(name))
                text = Database.GetPerson(name).LongText;

            return View(new PersonViewModel(name, text));
        }

        [HttpGet("[action]/{category}")]
        public IActionResult List(string category)
        {
            return View(new ListViewModel(category));
        }

        [HttpGet("[action]")]
        public IActionResult Map()
        {
            return View(new MapViewModel());
        }
    }
}