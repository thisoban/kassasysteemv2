using System;
using Logic;

namespace FactoryLogic
{
    public static class FactoryLogic
    {
        public static ILogic.IProduct ProductLogic()
        {
            return new Product();
        }
        public static ILogic.ISale SaleLogic()
        {
            return new Sale();
        }
        //todo order
        //todo employee
        //todo transaction
    }
}
