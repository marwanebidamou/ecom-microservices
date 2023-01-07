﻿using System.ComponentModel.DataAnnotations;

namespace EcomApp.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Range(0, 10000000)]
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? ImageUrl { get; set; }

    }
}
