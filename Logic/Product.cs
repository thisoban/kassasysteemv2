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
            foreach (ProductModel product in stock)
            {
                if (product.Quantity < 1)
                {
                    stock.Remove(product);
                }
            }
            return stock;
        }

        public bool Retour(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public ProductModel SearchProduct(int serialnumber)
        {
            throw new NotImplementedException();
        }
    }
}
