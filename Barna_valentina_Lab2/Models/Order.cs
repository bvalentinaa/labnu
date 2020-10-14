using System;
namespace Barna_valentina_Lab2.Models
{
    public class Order
    {
        public int    OrderID    { get; set; }
        public string CustomerID { get; set; }
        public string BookID     { get; set; }

        public Customer Customer { get; set; }
        public Book Book         { get; set; }
    }
}
