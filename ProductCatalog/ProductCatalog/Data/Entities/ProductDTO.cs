﻿namespace ProductCatalog.Data.Entities
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public string Base64Image { get; set; }
    }
}
