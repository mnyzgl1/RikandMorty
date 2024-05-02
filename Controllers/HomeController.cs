using Microsoft.AspNetCore.Mvc;
using RikendMorty.Models;
using RikendMorty.Services;
using System.Diagnostics;

namespace RikendMorty.Controllers
{
    public class HomeController : Controller
    {

        public IRikandMortyService _rikendmortyservice;
        public HomeController(IRikandMortyService rikandMortyService)
        {
                _rikendmortyservice = rikandMortyService;
        }

        public IActionResult Index()
        {
            var Karakters=_rikendmortyservice.GetKarakters();
            return View(Karakters);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
