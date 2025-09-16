using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("[area]/[controller]/[action]/{id?}")]
public class AboutsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
