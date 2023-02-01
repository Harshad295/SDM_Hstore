using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LMS.Models;

namespace LMS.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
     public IActionResult Training()
    {
        return View();
    }
       [HttpPost]
    public IActionResult Login(string email, string password)
    {
       if(email=="hd@gmail.com" && password=="2347")
       {
           Console.WriteLine("All Ok");
       }
        return this.RedirectToAction("index","topics");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
