using System;

namespace DesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
/*            WeatherData w = new WeatherData();
            CurrentConditionDisplay c = new CurrentConditionDisplay(w);
            w.SetMeasurement(1, 2, 3);
            w.SetMeasurement(4, 9, 3);*/

            // test decorator pattern
//            Beverage order1 = new Mocha(new Whip(new Whip(new Espresso())));
//            Console.WriteLine(order1.GetDescription());
//            Console.WriteLine($"{order1.Cost().ToString()}");
            Beverage beverage1 = new Espresso();
            Console.WriteLine($"{beverage1.GetDescription()}: ${beverage1.Cost()}");
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()}: ${beverage1.Cost()}");
            beverage1 = new Mocha(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()}: ${beverage1.Cost()}");
        }
    }
}

