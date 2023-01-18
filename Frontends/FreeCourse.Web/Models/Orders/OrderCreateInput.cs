using System.Collections.Generic;

namespace FreeCourse.Web.Models.Orders
{
    public class OrderCreateInput
    {
        public OrderCreateInput()
        {
            OrdersItems = new List<OrderItemCreateInput>();
        }

        public string BuyerId { get; set; }
        public List<OrderItemCreateInput> OrdersItems { get; set; }

        public AddressCreateInput Address { get; set; }
    }
}
