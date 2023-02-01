using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LMS.Models;

namespace LMS.Controllers;

public class TopicsController: Controller
{
    private readonly ILogger<TopicsController> _logger;

    public TopicsController(ILogger<TopicsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    } 

    [HttpGet]
    public IActionResult Info()
    {
        return View();
    } 
    
}