using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNetTraiing
{
    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car have 4 Wheels..!");
        }
    }
}
