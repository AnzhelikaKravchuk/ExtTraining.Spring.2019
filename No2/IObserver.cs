namespace No2
{
    public interface IObserver
    {
        void Update(IObservable sender, WeatherInfo info);
    }
}