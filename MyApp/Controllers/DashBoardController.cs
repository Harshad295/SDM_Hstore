using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers;

public class DashBoardController : Controller
{
    private readonly ILogger<DashBoardController> _logger;

    public DashBoardController(ILogger<DashBoardController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
