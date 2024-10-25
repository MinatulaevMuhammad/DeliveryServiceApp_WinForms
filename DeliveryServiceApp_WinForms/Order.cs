using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp_WinForms
{
    public class Order
    {
        public int Id {  get; set; }
        public string District { get; set; }
        public double Weight { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
