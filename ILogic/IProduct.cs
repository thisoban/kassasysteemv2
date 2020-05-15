using System;
using System.Collections.Generic;
using DataModel;

namespace ILogic
{
    public interface IProduct
    {
        bool Retour(ProductModel product);
        ProductModel SearchProduct(int serialnumber);
        bool BookOutProduct(int serialnumber);
        bool AddProductsFromOrder(OrderModel order);
        List<ProductModel> Products();
    }
}
