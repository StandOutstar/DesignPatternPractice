using System;

namespace DesignPatternPractice
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        public virtual string GetDescription()
        {
           return Description;
        }

        public abstract double Cost();
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast";   
        }

        public override double Cost()
        {
            return 0.9;
        }
    }
    
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 1.2;
        }
    }

    // 抽象装饰器
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();  // 此处是一个继承中的一个难点
    }

    // 具体装饰器
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string GetDescription()
        {
            return "Whip " + _beverage.GetDescription(); 
            
        }

        public override double Cost()
        {
            return 0.3 + _beverage.Cost();
        }
    }
    
    // 具体装饰器
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {

            return "Mocha " + _beverage.GetDescription();
        }

        public override double Cost()
        {
            return 0.4 + _beverage.Cost();
        }
    }
    
}