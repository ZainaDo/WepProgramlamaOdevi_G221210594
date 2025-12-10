using Microsoft.AspNetCore.Mvc;

public class AntrenorController : Controller
{
    private readonly ITrainerService _trainerService;

    public AntrenorController(ITrainerService trainerService)
    {
        _trainerService = trainerService;
    }

    // GET: Antrenor/AntrenorEkle
    public IActionResult AntrenorEkle()
    {
        return View();
    }

    // POST: Antrenor/AntrenorEkle
    [HttpPost]
    public IActionResult AntrenorEkle(TrainerModel model)
    {
        if (ModelState.IsValid)
        {
            _trainerService.AddTrainer(model); // إضافة المدرب إلى قاعدة البيانات
            return RedirectToAction("Index", "Antrenor"); // عرض المدربين
        }

        return View(model);
    }
}
