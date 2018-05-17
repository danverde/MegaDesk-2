using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk4
{
    class Desk
    {
        public enum Surface
        {
            Laminate,
            Oak,
            Pine,
            Rosewood,
            Veneer
        }

        public decimal Depth { get; set; }

        public decimal Width { get; set; }

        public int NumDrawers { get; set; }

        public string Material { get; set; }
    }
}
