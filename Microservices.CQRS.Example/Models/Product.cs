﻿namespace Microservices.CQRS.Example.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}