using ShopApp.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Kategori alanı zorunludur!")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Kategori için 5-100 arasında karakter giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunludur!")]
        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}
