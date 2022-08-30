using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn
{
    public class Unicorn
    {
        public string Name;
        public string Color { get; set; }
        public List<Power> MagicalPowers;
        public int Energy;

        public Unicorn(string name, string color)
        {
            Name = name;
            Color = color;
            MagicalPowers = new List<Power>();
            Energy = 100;
        }

        public void AddPower(Power magicalPower)
        {
            MagicalPowers.Add(magicalPower);
        }

        public void DisplayPowers()
        {
            foreach (var power in MagicalPowers)
            {
                Console.WriteLine($"*-*-*{power.Name}*.*.*");
            }
        }

        public void Perform(Power power)
        {
            if (MagicalPowers.Contains(power))
                Energy -= power.EnergyRequired;
        }

        public void Rest(int time)
        {
            Energy += time;
        }
    }
}
