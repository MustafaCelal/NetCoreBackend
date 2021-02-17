﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    // Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();
            
            //ProductManager manager = new ProductManager(new EfProductDal());
            


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CateogryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
