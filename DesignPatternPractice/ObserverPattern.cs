using System;
using System.Collections.Generic;

namespace DesignPatternPractice
{
    public class WeatherData: ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure); 
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurement(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }

    public class CurrentConditionDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private ISubject _subject;

        public CurrentConditionDisplay(ISubject subject)
        {
            _subject = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }

    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    interface IDisplayElement
    {
        void Display();
    }
}