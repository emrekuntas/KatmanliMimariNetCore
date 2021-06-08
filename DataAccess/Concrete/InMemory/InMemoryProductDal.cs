using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> 
            {
            new Product{CategoryId=1,ProductName="Bilgisayar",UnitsInStock=5,ProductID=1,UnitPrice=15},
            new Product{CategoryId=2,ProductName="Telefon",UnitsInStock=10,ProductID=2,UnitPrice=25},
            new Product{CategoryId=2,ProductName="Tablet",UnitsInStock=3,ProductID=3,UnitPrice=35},
            new Product{CategoryId=3,ProductName="Kulaklık",UnitsInStock=30,ProductID=4,UnitPrice=5},
            new Product{CategoryId=3,ProductName="Wifi",UnitsInStock=20,ProductID=5,UnitPrice=100},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
            product.CategoryId = product.CategoryId;
        }
    }
}
