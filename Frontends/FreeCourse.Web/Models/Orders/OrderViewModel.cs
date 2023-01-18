using System.Collections.Generic;
using System;

namespace FreeCourse.Web.Models.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        
        //odeme gecmisinde gerek yok
        //public AddressDto Address { get; set; }
        
        public string BuyerId { get; set; }

        public List<OrderItemViewModel> OrderItems { get; set; }
    }
}
