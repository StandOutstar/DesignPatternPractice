namespace DesignPatternPractice
{
    // 简单工厂
    // 封装创建对象的代码
    // 工厂方法
    // 提供接口，由子类实现创建
    // 抽象工厂
    // 提供接口，创建产品家族
    public class FactoryPattern
    {
        
    }

    class Pizza
    {
    }

    class NYStylePizza: Pizza
    {
        
    }

    class CGStylePizza : Pizza
    {
        
    }

    class SimpleFactory
    {
        // 简单工厂
        public Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "NYStyle":
                    return new NYStylePizza();
                case "CGStyle":
                    return new CGStylePizza();
                default:
                    return new Pizza();
            }
        }
    }

    abstract class PizzaStore
    {
        public abstract Pizza createPizza(string type);

    }

    class NYStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            return new NYStylePizza();
        }
    }
}