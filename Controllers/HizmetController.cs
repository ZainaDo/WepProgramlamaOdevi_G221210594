using Microsoft.AspNetCore.Mvc;
using WebProjesi.Models;


namespace WepProjesi.Controllers
{
    public class HizmetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
