using Kitaplik.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitaplik.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitaplar>() {
            
            new Kitaplar
            {
                ID=6,
                KitapAd="KORKU",
                Yazar="ZWEİG"
            },
            new Kitaplar
            {
                ID=7,
                KitapAd="anna",
                Yazar="tolstoy"
            }
            
            
            };
            return View(kitaplistesi);
        }

    }
}
