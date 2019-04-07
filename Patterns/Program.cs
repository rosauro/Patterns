using Patterns.Structural.Strategy;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Patterns! {Environment.NewLine}");
            //StrategyPattern.Run();

            BuilderPattern.Run();

            Console.WriteLine("Press a key to end...");
            Console.Read();
        }
    }
}
