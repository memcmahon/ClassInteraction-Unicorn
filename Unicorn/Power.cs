using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn
{
    public class Power
    {
        public string Name;
        public int EnergyRequired;

        public Power(string name, int energyRequired)
        {
            Name = name;
            EnergyRequired = energyRequired;
        }
    }
}
