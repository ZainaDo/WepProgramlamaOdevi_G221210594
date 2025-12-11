using Microsoft.AspNetCore.Mvc;
using WepProjesi.Models;

namespace WepProjesi.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult RandevuAl()
        {
            var model = new RandevuModeli()
            {
                Antrenorler = AntrenorController.AntrenorListesi
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult RandevuAl(RandevuModeli model)
        {
            return RedirectToAction("RandevuOnay");
        }

        public IActionResult RandevuOnay()
        {
            return View();
        }
    }
}
