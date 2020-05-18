using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
   public class OrderModel
    {
        public int Number { get; set; }
        public List<ProductModel> OrderProducts { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int WholeSalePrice { get; set; }
        public string status { get; }
    }
}
