using System;
using System.Collections.Generic;
using DataModel;

namespace IDal
{
    public interface IDalProduct
    {
        List<ProductModel> Products();
        ProductModel GetProduct(int serialnumber);
        bool ChangeProduct(ProductModel changeProduct);
        bool RemoveProduct(ProductModel product);
        bool AddProducts(List<ProductModel> addproducts);
        bool AddProduct(ProductModel newproduct);
    }
}
