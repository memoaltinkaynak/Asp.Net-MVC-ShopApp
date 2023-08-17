using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductByCategory(string name, int page, int pageSize);
        List<Product> GetAll();
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product Entity);
        bool Update(Product entity, int[] categoryIds);
        int GetCountByCategory(string category);
    }
}
