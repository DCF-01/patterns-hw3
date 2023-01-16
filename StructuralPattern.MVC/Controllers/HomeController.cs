using Microsoft.AspNetCore.Mvc;
using StructuralPattern.MVC.ViewModels;

namespace StructuralPattern.MVC.Controllers
{


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index([FromQuery] ResultViewModel resultViewModel)
    {
        return View(new ResultViewModel{ Message = resultViewModel.Message, PathToMessage = resultViewModel.PathToMessage});
    }
}
}