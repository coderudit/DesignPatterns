using System.Collections.Generic;

namespace _002_ObserverPattern
{
    public class WeatherData : IObservableWeatherFields
    {
        private List<IObserver> observers;
        
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = observers.IndexOf(observer);
            if (index > 0)
                observers.Remove(observer);
        }

        /// <summary>
        /// Send a notification to observers that fields has changed and take a update of a field
        /// you want.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Use it when IObservable is not passed to IObserver in constructor.
                //observer.Update(Temperature, Humidity, Pressure); 

                //In this way, Observer can ask for only those stuff that it needs.
                observer.Update();
            }
        }

        public void MeasurementsChanged(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            NotifyObservers();
        }
    }
}
