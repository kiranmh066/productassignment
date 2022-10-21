using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetProducts();

        //void GenerateCode(Product product);

        //void ShowProduct(Product product);

    }
}
