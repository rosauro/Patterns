using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Strategy
{
    public static class StrategyPattern
    {
        public static void Run()
        {
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user
            Console.ReadKey();
        }
    }
}
