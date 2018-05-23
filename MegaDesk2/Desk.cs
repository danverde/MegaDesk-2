using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk4
{
    /* For MegaDesk 2 the Desk class was converted to a struct */
    struct Desk
    {
        public decimal Depth;
        public decimal Width;
        public int NumDrawers;
        public int SurfaceMaterial;

        public enum Surface
        {
            Laminate = 100,
            Oak = 200,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }
    };
}
