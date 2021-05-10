using System;

namespace _002_ObserverPattern
{
    public class WeatherStation
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.RegisterObserver(currentConditionsDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);

            weatherData.MeasurementsChanged(80, 65, 30);
        }
    }
}
