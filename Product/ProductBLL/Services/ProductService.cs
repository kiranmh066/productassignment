using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class ProductService
    {
        private IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        //Add Product
        public void AddProduct(Product product)
        {
            /*_productRepo.AddProduct(product);*/
            string _productcode=null;
              int  channelId = product.channelId;

            int j = 0;
            j++;

            if (channelId == 1)
            {
                int k=product.productYear;
                /*var a = 0;
                (a++).ToString("000").Dump();
                (a++).ToString("000").Dump();*/

                Random rnd = new Random();
                int y=rnd.Next(100, 999);

                _productcode = ("k"+"00" + "channelId");

            }
            else if (channelId == 2)
            {
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[6];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                _productcode = new String(Charsarr);
                    
            }
            else if (channelId == 3)
            {
                int k = 10000000;
                int z = k + j;
                _productcode = ("z");
            }
            else
            {
                Console.WriteLine("channelId");
            }
                //return "";
            _productcode=
            product.ProductCode =_productcode;

            _productRepo.AddProduct(product);
        }

        //GetProducts
        public IEnumerable<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }

        public string codegenarator(int channelId)
        {
            if(channelId == 0)
            {

            }
            else if(channelId == 1)
            {

            }
            else if(channelId==3)
            {

            }
            else
            {
                Console.WriteLine("channelId");
            }
            return "";
        }
    }
}
