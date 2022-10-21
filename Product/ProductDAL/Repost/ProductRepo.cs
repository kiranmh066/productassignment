using Microsoft.EntityFrameworkCore;
using ProductDAL.Migrations;
using System;
using System.Collections.Generic;
using System.Text;
using ProductEntity;
using System.Linq;

namespace ProductDAL.Repost
{
    public class ProductRepo:IProductRepo
    {
        private ProductDbContext _productDbContext;

        public ProductRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void AddProduct(ProductEntity.Product product)
        {
            _productDbContext.tblProduct.Add(product);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<ProductEntity.Product> GetProducts()
        {
            return _productDbContext.tblProduct.ToList();
        }
    }
}
