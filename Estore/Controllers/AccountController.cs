using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Estore.Models;

namespace Estore.Controllers;
 public class AccountController:Controller
 {
   private readonly ILogger<AccountController> _logger;
   public AccountController(ILogger<AccountController> logger)
   {
    _logger=logger;
   }
   [HttpGet]
   public IActionResult Login()
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
        return this.RedirectToAction("index","orders");
    }

    
      [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

      
      [HttpPost]
    public IActionResult Register(string firstname, string lastname, string  location,string email, string password)
    {
        Console.WriteLine(firstname + " " + lastname + " "+ location);
        return this.RedirectToAction("Login","Account");
    }

 }
 


