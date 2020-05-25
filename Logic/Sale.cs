using System;
using System.Collections.Generic;
using System.Text;
using DataModel;
using ILogic;

namespace Logic
{
    public class Sale : ISale
    {
        private readonly IDal.IDalProduct dalProduct = FactoryDal.FactoryDal.ProductDal();
        public bool RetourTransaction(int transaction)
        {   // search for transaction and show it then ask for change
            throw new NotImplementedException();
        }

        public bool SellProducts(List<ProductModel> products)
        {
            // when sale is being confirmed by pay
            // when the sale is ready to sell
            throw new NotImplementedException();
        }

        private ProductModel GetProduct(int serialnumber)
        { 
            ProductModel product = dalProduct.GetProduct(serialnumber);
            return product;
        }

        private List<ProductModel> products()
        {

        }
    }
}
