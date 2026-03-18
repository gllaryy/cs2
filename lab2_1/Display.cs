using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Display
    {
        public void Subscribe(TemperatureSensor sensor)
        {
            sensor.TemperatureChanged += TemperatureIsChanged;
        }
        public void TemperatureIsChanged(int temp)
        {
            Console.WriteLine($"Display: поточна температура {temp}°C");
        }
    }
}
