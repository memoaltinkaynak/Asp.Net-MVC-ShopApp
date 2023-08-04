using ShopApp.Business.Abstract;
using ShopApp.Data.Absctract;
using ShopApp.Data.Concrete.EfCore;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository) 
        {
           _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            //iş kuralları
            _productRepository.Create(entity);
        }

        public void Delete(Product Entity)
        {
            //iş kuralları
            _productRepository.Delete(Entity);

        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
             return _productRepository.GetById(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productRepository.GetCountByCategory(category);
        }

        public List<Product> GetProductByCategory(string name, int page, int pageSize)
        {
            return _productRepository.GetProductsByCategory(name, page, pageSize);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
