using Newtonsoft.Json.Serialization;
using ShopApp.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        //[Display(Name = "Name", Prompt = "Enter Product Name")]
        //[Required(ErrorMessage ="Name zorunlu bir alan!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunlu bir alan!")]
        public string Url { get; set; }

        //[Required(ErrorMessage = "Price zorunlu bir alan!")]
        //[Range(1,100000,ErrorMessage ="1 ile 100.000 arasýnda bir deðer girmelisiniz!")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Description zorunlu bir alan!")]
        [StringLength(100,MinimumLength =5,ErrorMessage = "Description 5 ile 100 karakter arasýnda olmalýdýr!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "ImageUrl zorunlu bir alan!")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        public List<Category> SelectedCategories{ get; set; }
    }
}