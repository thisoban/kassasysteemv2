using DataModel;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class Product : ILogic.IProduct
    {
        private readonly IDal.IDalProduct dalProduct = FactoryDal.FactoryDal.ProductDal();
        public bool AddProductsFromOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public bool BookOutProduct(int serialnumber)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> Products()
        {
            List<ProductModel> stock = dalProduct.Products();
            //todo make readable list and make 
            //IList<ProductModel> ReadStock = new List<ProductModel>();
            //ReadStock = stock;
            //todo cant modify a list when i iterate over it 
            //foreach (ProductModel product in ReadStock)
            //{
            //    if (product.Status =="empty")
            //    {
            //        stock.Remove(product);
            //    }
            //}
            return stock;
        }

        public bool Retour(ProductModel product)
        {
            //todo moet transactie veranderen status en product terugvoeren en geld tegoed bon maken
            
            throw new NotImplementedException();
        }

        public ProductModel SearchProduct(int serialnumber)
        {
            throw new NotImplementedException();
        }
    }
}
