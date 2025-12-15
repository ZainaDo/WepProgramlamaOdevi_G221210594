using Microsoft.AspNetCore.Mvc;
using WebProjesi.Models;


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
