using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace baxish.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
