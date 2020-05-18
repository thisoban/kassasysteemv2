using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace ILogic
{
    public interface IEmployee
    {
        Boolean Login();
        Boolean CheckOrder();
        void Transactions();
        void Reports();
        List<OrderModel> Orders();
        bool RegisterCustomer(CustomerModel customer);
    }
}
