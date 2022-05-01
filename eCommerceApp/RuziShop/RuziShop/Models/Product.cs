using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuziShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }
    }
}