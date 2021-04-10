using Kitaplik.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kitaplik.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>() {
              new Kitaplar(){ID=1,KitapAd="satranç",Yazar="zweig"},
              new Kitaplar(){ID=2,KitapAd="dr ox deneyi",Yazar="jules verne"},
              new Kitaplar(){ID=3,KitapAd="delifişek",Yazar="vasconulos"},
              new Kitaplar(){ID=4,KitapAd="kırmızı bisiklet",Yazar="muzaffer izgü"},
              new Kitaplar(){ID=5,KitapAd="ben robot",Yazar="isaac asimov"},

            };

            return View(ktp);
        }

        public IActionResult Deneme()
        {
            return View();
        }
        public IActionResult StaticTema()
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
