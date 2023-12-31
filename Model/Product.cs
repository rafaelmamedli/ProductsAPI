﻿using System.ComponentModel.DataAnnotations;


namespace FirstProductsAPI.Model
{

    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
