using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CRUD_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            string defaultKey = File.ReadAllText("appsettings.Debug.JSON");
            JObject jObject = JObject.Parse(defaultKey);
            JToken token = jObject["DefaultConnection"];
            string connectionString = token.ToString();
            ProductRepo.connString = connectionString;




            ProductRepo repo = new ProductRepo();

            //Create Products

            //Console.WriteLine("Creating Product......");
            //var newProduct = new Product { Name = "AJs Product", Price = 19.99M, CategoryID = 2, OnSale = 0 };
            //repo.CreateProduct(newProduct);
            //Console.WriteLine("Product Created!");


            //Updates Products

            //Console.WriteLine("Updating Products.....");
            //var newInfo = new Product { ProductID = 941, StockLevel = 27 };
            //repo.UpdateProducts(newInfo);
            //Console.WriteLine("Product Updated!");



            //Delete By ID
           
            //var id = 943;
            //repo.DeleteByID(id);


            //Delete By Name

            //var name = "AJs Product";
            //repo.DeleteByName(name);


            //Delete By Name and ProductID
;
            //repo.DeleteByNameAndID("AJs Product", 945);





            List<Product> products = repo.GetProducts();

            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.ProductID}  {prod.Name} ------- ${prod.Price}-------You have {prod.StockLevel} of these items.");

            }
            Console.ReadLine();
        }
    }
}
