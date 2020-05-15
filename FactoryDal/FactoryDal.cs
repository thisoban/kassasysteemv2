using System;
using Dal;
using IDal;

namespace FactoryDal
{
    public static class FactoryDal
    {
        public static IDalProduct ProductDal()
        {
            return new DalProduct();
        }
    }
}
