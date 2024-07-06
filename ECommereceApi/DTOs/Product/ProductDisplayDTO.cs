﻿using ECommereceApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommereceApi.DTOs.Product
{
    public class ProductDisplayDTO
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ProductImageDTO> ProductImages { get; set; } = new List<ProductImageDTO>();
        public double? Discount { get; set; }

        public double OriginalPrice { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double? FinalPrice { get; set; }
        public ICollection<SubCategoryValuesDTO> CategoryValues { get; set; } = new List<SubCategoryValuesDTO>();
    }
}
