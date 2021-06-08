using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {

            using NorthwindContext context = new NorthwindContext();
            var list = from p in context.Products
                       join c in context.Categories on
                           p.CategoryId equals c.CategoryId
                       orderby p.ProductID
                       select new ProductDetailDto
                       {
                           CategoryName = c.CategoryName,
                           ProductId = p.ProductID,
                           ProductName = p.ProductName,
                           UnitsInStock = p.UnitsInStock
                       };
            return list.ToList();
        }
    }
}
