﻿namespace AppDto
{
    public record ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
    }
}
