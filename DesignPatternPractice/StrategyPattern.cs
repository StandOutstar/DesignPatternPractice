using System;
using System.Reflection.Metadata;

namespace DesignPatternPractice
{
    public class StrategyPattern
    {
        public IAlgorithm Algorithm { get; set; }

        public void Compute()
        {
            Algorithm.Do();
        }
        
        
    }

    public interface IAlgorithm
    {
        void Do();
    }

    public class AlgorithmImplement1: IAlgorithm
    {
        public void Do()
        {
            Console.WriteLine("AlgorithmImplement1 Do");
        }
    }
    
    
    public class AlgorithmImplement2: IAlgorithm
    {
        public void Do()
        {
            Console.WriteLine("AlgorithmImplement2 Do");
        }
    }
    
    
}