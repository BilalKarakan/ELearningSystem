using ELearningSystem.WebUI.Models.About;
using ELearningSystem.WebUI.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ELearningSystem.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("[area]/[controller]/[action]/{id?}")]
public class AboutsController : Controller
{
    private readonly HttpClient _httpClient;
    private readonly AppSettings _appSettings;
    public AboutsController(IOptions<AppSettings> appSettings, HttpClient httpClient)
    {
        _appSettings = appSettings.Value;
        _httpClient = httpClient;
    }
    public async Task<IActionResult> Index()
    {
        var abouts = await _httpClient.GetFromJsonAsync<ListAboutReponse>(_appSettings.BaseUrl + "About/GetAll");
        return View(abouts);
    }
}
