using System;

namespace _002_ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public IObservableWeatherFields WeatherDataObject { get; set; }

        public CurrentConditionsDisplay(IObservableWeatherFields weatherData)
        {
            WeatherDataObject = weatherData;
        }
        public void Dislay()
        {
            Console.WriteLine($"Current conditions:{Temperature} F degrees and {Humidity} " +
                $"% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Dislay();
        }

        public void Update()
        {
            Temperature = WeatherDataObject.Temperature;
            Humidity = WeatherDataObject.Humidity;
            Dislay();
        }
    }
}
