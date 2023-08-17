using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Data;
using ShopApp.Data.Absctract;
using ShopApp.Models;
using System;
using System.Collections.Generic;

namespace ShopApp.Controllers
{
    public class HomeController : Controller
    { 
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }


        public IActionResult Index()
        {

            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetHomePageProducts()
            };

            return View(productViewModel);

        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }


    }
}
