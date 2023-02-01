using Microsoft.AspNetCore.Mvc;
using BOL;
namespace CatalogServices.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    public IActionResult GetProducts()
    {
        var products= new List<Product>();
        products.Add(new Product{Id=1, Title="Gerbera",  Description="Wedding flower", UnitPrice=5, Quantity=400});
       products.Add(new Product{Id=2, Title="Rose",  Description="Valentine Flowers", UnitPrice=15, Quantity=4000});
          return Ok(products);
    }

    [Route("{id}")]
    [HttpGet]
    public IActionResult GetProductById(int id)
    { 
        
        Console.WriteLine("Id"+id);
        
        Product theProduct=new Product{ Id=1, Title="Jasmine",  Description="Fregrance flower", UnitPrice=1, Quantity=4000 };
        return Ok(theProduct);

    }


    }