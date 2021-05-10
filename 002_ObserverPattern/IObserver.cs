namespace _002_ObserverPattern
{
    public interface IObserver
    {
        /// <summary>
        /// This update method is feasible when IObservable is not passed inside the constructor
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update(float temp, float humidity, float pressure);

        /// <summary>
        /// This update method is feasible when IObservable is passed inside the constructor
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update();
    }
}
