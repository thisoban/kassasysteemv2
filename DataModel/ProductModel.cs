using System;

namespace DataModel
{
    public enum Status
    {
        Done, Ready, Coming
    }
    public class ProductModel
    {

        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public Status Status { get; set; }
    }
}
   

