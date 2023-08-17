using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService : IValidator<Category>
    {
        Category GetById(int id);
        Category GetByIdWithProducts(int categoryId);
        List<Category> GetAll();
        void Create(Category Entity);
        void Update(Category Entity);
        void Delete(Category Entity);
        void DeleteFromCategory(int productId, int categoryId);
    }
}
