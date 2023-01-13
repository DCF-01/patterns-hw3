using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StructuralPattern.MVC.Models;

namespace StructuralPattern.MVC.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}