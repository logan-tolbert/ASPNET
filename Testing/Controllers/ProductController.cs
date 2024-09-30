﻿using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            this._repo = repo;
        }

        
        public IActionResult Index()
        {
            var products = _repo.GetAllProducts();
            return View();
        }
    }
}
