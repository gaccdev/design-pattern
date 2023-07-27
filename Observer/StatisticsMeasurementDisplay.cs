namespace Observer
{
    public class StatisticsMeasurementDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        private readonly WeatherData _weatherData;

        public StatisticsMeasurementDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Display from {nameof(StatisticsMeasurementDisplay)}");

            Console.WriteLine($"Temperature is {_temperature}");
            Console.WriteLine($"Humidity is {_humidity}");
            Console.WriteLine($"Pressure is {_pressure}");
        }

        void IObserver.Update()
        {
            _temperature = _weatherData.Temperature;
            _humidity = _weatherData.Humidity;
            _pressure = _weatherData.Pressure;

            Display();
        }
    }
}

