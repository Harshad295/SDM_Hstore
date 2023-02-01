namespace Estore.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SAL;
using BOL;
public class ShoppingCartController:Controller
{
    private readonly ILogger <ShoppingCartController> _logger;
    public ShoppingCartController(ILogger <ShoppingCartController> logger)
    {
       _logger=logger;
    }
     [HttpGet]
    public IActionResult Index()
    {   
        int cart=int.Parse(HttpContext.Session.GetInt32("cart").ToString());
        this.ViewData["cart"]=cart;
        Console.WriteLine("DATA IS retrived from session cart");
        Console.WriteLine(cart);
        return View();
    }

     [HttpGet]
    public IActionResult AddToCart(int id)
    {
        
        Console.WriteLine("DATA IS ADDED to session cart");
        HttpContext.Session.SetInt32("cart", id);

        return RedirectToAction("Index","ShoppingCart");
    }


}

