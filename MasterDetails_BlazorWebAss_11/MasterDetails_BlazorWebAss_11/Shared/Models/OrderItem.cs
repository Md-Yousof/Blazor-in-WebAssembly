using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MasterDetails_BlazorWebAss_11.Shared.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order? Order { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set;}
       
    }
}
