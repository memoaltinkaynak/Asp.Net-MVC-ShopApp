using System;
using ShopApp.Entity;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ShopApp.ViewModels
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int  CurrentPage { get; set; }
        public string  CurrentCategory { get; set; }
        
        int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }
    }

    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products{ get; set; }
    }
}
