
using Microsoft.EntityFrameworkCore;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Telefon", Url="telefon"},
            new Category(){Name="Bilgisayar", Url="bilgisayar"},
            new Category(){Name="Elektronik", Url = "elektronik"},
            new Category(){Name="Beyaz Eşya", Url = "beyez-esya"}
        };

        private static Product[] Products = {
            new Product(){Name="Iphone 6S",Url="iphone-6s",Price=2000,ImageUrl="1.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="Iphone 7S",Url="iphone-7s",Price=3000,ImageUrl="2.jpg",Description="iyi telefon", IsApproved=false},
            new Product(){Name="Samsung J7 Prime",Url="samsung-j7",Price=4000,ImageUrl="3.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="Samsung S8",Url="samsung-s8",Price=5000,ImageUrl="4.jpg",Description="iyi telefon", IsApproved=false},
            new Product(){Name="Iphone 8",Url = "iphone-8", Price=6000,ImageUrl="5.jpg",Description="iyi telefon", IsApproved=true},
        };

        private static ProductCategory[] ProductCategories = {
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
        };



    }
}
