using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk4
{
    class DeskQuote
    {
        public enum Delivery
        {
            Rush3Days = 3,
            Rush5Days = 5,
            Rush7Days = 7,
            NoRush14Days = 14
        }

        /* custom constructor. Calculates the price Quote when called */
        public DeskQuote(Desk desk, string customerName, int deliveryTime, DateTime orderDate)
        {
            Desk = desk;
            CustomerName = customerName;
            DeliveryTime = deliveryTime;
            OrderDate = orderDate;

            try
            {
                CalcQuote();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DateTime OrderDate { get; set; }

        public string CustomerName { get; set; }

        public decimal Price { get; set; }

        public int DeliveryTime { get; set; }

        public Desk Desk { get; set; }

        private List<List<int>> GetRushOrder()
        {
            List<List<int>> prices = new List<List<int>>();
            try
             {
                string pricingFilename = "rushOrderPrices.txt";

                if (File.Exists(pricingFilename))
                {
                    string[] lines = File.ReadAllLines(pricingFilename);

                    var i = 0;
                    for (var r = 0; r < 3; r++)
                    {
                    prices.Insert(r, new List<int>());
                        for (var c = 0; c < 3; c++)
                        {
                            prices[r].Insert(c, Int32.Parse(lines[i]));
                            ++i;
                        }
                    }
                    return prices;
                }
                else
                {
                    throw new Exception($"Unable to find {pricingFilename}");
                }
            }
             catch (Exception)
            {
                throw;
            }
        }

        private void CalcQuote()
        {
            /* calcualte surface area */
            decimal surfaceArea = Desk.Depth * Desk.Width;

            var rushFee = 0;

            /* calculate size (0 -> small, 1-> medium, 2-> large) */
            int size = ((int)surfaceArea == 2000) ? 1 : (int)surfaceArea / 1000;
            if (size > 2)
            {
                size = 2;
            }

            /* Add cost of drawers */
            Price = Desk.NumDrawers * 50;

            /* 1$ per square inch AFTER $1,000 OR 200 */
            Price += (size > 0)? surfaceArea - 1000 : 200;

            /* calculate material cost */
            Price += Desk.SurfaceMaterial;

            try
            {
                var prices = GetRushOrder();

                /* add rush delivery fee if applicable */
                switch (DeliveryTime)
                {
                    case 3:
                        rushFee = prices[0][size];
                        break;

                    case 5:
                        rushFee = prices[1][size];
                        break;

                    case 7:
                        rushFee = prices[2][size];
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }

            Price += rushFee;
        }
    }
}
