using Microsoft.AspNetCore.Mvc;
using WebProjesi.Models;
using System.Collections.Generic;

namespace WebProjesi.Controllers
{
    public class AntrenorController : Controller
    {
        public static List<AntrenorModeli> AntrenorListesi { get; set; }
            = new List<AntrenorModeli>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AntrenorGoruntule()
        {
            return View(AntrenorListesi);
        }

        public IActionResult AntrenorEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AntrenorEkle(AntrenorModeli model)
        {
            model.Id = AntrenorListesi.Count + 1;
            AntrenorListesi.Add(model);
            return RedirectToAction("AntrenorGoruntule");
        }
    }
}
