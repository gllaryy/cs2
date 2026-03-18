namespace pr2
{
    internal class Program1
    {
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Display display = new Display();
            AirConditioner airConditioner = new AirConditioner();
            SecuritySystem security = new SecuritySystem();

            display.Subscribe(sensor);
            airConditioner.Subscribe(sensor);
            security.Subscribe(sensor);

            sensor.SetTemperature(10);
            sensor.SetTemperature(20);
            sensor.SetTemperature(30);
            sensor.SetTemperature(45);
            sensor.SetTemperature(2);

        }
    }
}
