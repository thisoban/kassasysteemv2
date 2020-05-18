using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace ILogic
{
    public interface ISale
    {
        bool SellProducts(List<ProductModel> products);
    }
}
