using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class TemperatureSensor
    {
        public event Action<int> TemperatureChanged;

        
        public void SetTemperature(int temp)
        {
            Console.WriteLine($"\nТемпература змінена: {temp}°C");
            TemperatureChanged?.Invoke(temp);
        }
    }
}
