﻿namespace CQRSDesignPattern.CQRS.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public bool Stotus { get; set; }
    }
}
