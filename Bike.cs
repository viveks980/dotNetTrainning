using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bike have 2 Wheels..!");
        }
    }
}
