using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk4
{
    class DeskQuote
    {
        public Desk Desk { get; set; }

        public int RushDays { get; set; }

        public decimal PriceQuote { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        private int CalcQuote()
        {
            return 0;
        }
    }
}
