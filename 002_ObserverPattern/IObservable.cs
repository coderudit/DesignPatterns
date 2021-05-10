namespace _002_ObserverPattern
{
    public interface IObservableFields
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
