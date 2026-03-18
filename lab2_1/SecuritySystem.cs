using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class SecuritySystem
    {
        public void Subscribe(TemperatureSensor sensor)
        {
            sensor.TemperatureChanged += TemperatureIsChanged;
        }
        public void TemperatureIsChanged(int temp)
        {
            if(temp>40)
            {
                Console.WriteLine("Перегрів!");
            }
            else if(temp<5)
            {
                Console.WriteLine("Ризик замерзання!");
            }
        }
    }
}
