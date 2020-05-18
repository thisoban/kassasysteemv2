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
        //todo order
        //todo employee
        //todo transaction
    }
}
