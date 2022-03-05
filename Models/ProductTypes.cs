using System.ComponentModel.DataAnnotations;
using System;

namespace SiteDeCompra.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }
    }
}