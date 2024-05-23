﻿namespace Microservices.CQRS.Example.Manual_CQRS.Queries.Responses
{
    public class GetByIdProductQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
