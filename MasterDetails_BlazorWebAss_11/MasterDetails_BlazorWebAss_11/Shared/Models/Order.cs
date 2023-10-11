using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetails_BlazorWebAss_11.Shared.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsActive { get; set; }

        public List<OrderItem> Items { get; set;}=new List<OrderItem>();

    }
}
