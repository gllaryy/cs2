using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class AirConditioner
    {
        public void Subscribe(TemperatureSensor sensor)
        {
            sensor.TemperatureChanged += TemperatureIsChanged;
        }
        public void TemperatureIsChanged(int temp)
        {
            if (temp<17)
            {
                Console.WriteLine("Обігрів увімкнено");
            }
            else if(temp>25)
            {
                Console.WriteLine("Охолодження увімкнено");
            }
            else
            {
                Console.WriteLine("Кондиціонер вимкнено");
            }
        }
    }
}
