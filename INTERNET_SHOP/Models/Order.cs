﻿namespace INTERNET_SHOP.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime DateTimeOrder { get; set; }
        public double Amount { get; set; }
        public Ticket Ticket { get; set; }
    }
}
