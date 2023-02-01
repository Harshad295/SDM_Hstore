//  namespace DAL;
// using BOL;
// public static class ProductsRepository
// {
//     public static List <Product> GetAll()
//     {
//         List<Product> allProducts=new List<Product>();
//          allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", StockAvailable = 3400 });
//             allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", StockAvailable = 27000 });
//             allProducts.Add(new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", StockAvailable = 5000 });
//             allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", StockAvailable = 7000 });
//             allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", StockAvailable = 1000 });
//             allProducts.Add(new Product { ProductId = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", StockAvailable = 2000 });
//             allProducts.Add(new Product { ProductId = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", StockAvailable = 159 });
//             allProducts.Add(new Product { ProductId = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", StockAvailable = 67 });
//     return allProducts;
//     }
//     public static Product GetById(int id){

//           List<Product> products=GetAll();
//           var theProduct= from prod in products
//                           where prod.ProductId == id
//                           select prod;

         
//           return theProduct as  Product;
//     }

//     public  static bool  Insert(Product product){
//          bool status=false;
//          List<Product> products=GetAll();
//          products.Add(product);
//          status=true;
//          return status;
//     }


//     public  static bool Delete(int id){
//          bool status=false;
//          List<Product> products=GetAll();
//          Product theProduct=GetById(id);
//          products.Remove(theProduct);
//          status=true;
//          return status;
//     }


//     public static bool Update(Product product)
//     {
//          bool status=false;
//          List<Product> products=GetAll();
       

//          status=true;
//          return status;
//     }

// }