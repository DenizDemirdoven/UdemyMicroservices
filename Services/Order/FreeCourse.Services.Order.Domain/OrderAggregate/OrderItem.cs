﻿using FreeCourse.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    public class OrderItem: Entity
    {
        public string ProdcuctId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUrl{ get; private set; }
        public Decimal Price { get; private set; }

        public OrderItem()
        {}

        public OrderItem(string prodcuctId, string productName, string pictureUrl, decimal price)
        {
            ProdcuctId = prodcuctId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
        public void UpdateOrderItem(string productName, string pictureUrl, decimal price)
        {
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
    }
}
