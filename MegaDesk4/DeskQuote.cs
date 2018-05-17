using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk4
{
    class DeskQuote
    {
        public enum Delivery
        {
            Days3,
            Days5,
            Days7,
            NoRush14
        }

        public DateTime OrderDate { get; set; }

        public string CustomerName { get; set; }

        public decimal Price { get; set; }

        public int DeliveryTime { get; set; }

        public Desk Desk { get; set; }

        public decimal CalcQuote()
        {
            // 1$ per square inch AFTER $1,000
            return 0;
        }
    }
}
