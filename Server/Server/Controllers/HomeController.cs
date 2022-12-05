using Microsoft.AspNetCore.Mvc;
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

            if (Directory.Exists($"./Data/{name}/"))
            {
                string[] files = Directory.GetFiles($"./Data/{name}/");
                text = System.IO.File.ReadAllText(files.First());
            }

            return View(new PersonViewModel(name, text));
        }
    }
}