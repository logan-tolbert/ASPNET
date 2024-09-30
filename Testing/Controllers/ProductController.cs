﻿using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProduct(int id)
        {
            Product product = repo.GetProduct(id);
            if (product == null)
            {
                return View("ProductNotFound");
            }
            return View(product);
        }
        
        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);
            return RedirectToAction("ViewProduct", new {id = product.ProductID});
        }
    }
}
