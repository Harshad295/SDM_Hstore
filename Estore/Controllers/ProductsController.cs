using System.Diagnostics;
//namespace BOL;
using Microsoft.AspNetCore.Mvc;
//using Estore.Models;
using BOL;
using SAL;

namespace Estore.Controllers;

public class ProductsController : Controller
{ 
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    
    

    
    [HttpGet]
    public IActionResult Index()
    {
        ProudctHubService svc=new ProudctHubService();
        List<Product> allProducts=svc.GetAllProducts();
        this.ViewData["products"]=allProducts;
        
        return View();
    }


    [HttpGet]
    public IActionResult Details(int id)
    {
        return View();
    }

}