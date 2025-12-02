using Microsoft.AspNetCore.Mvc;

namespace WepProjesi.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
