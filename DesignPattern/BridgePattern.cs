using System;

namespace DesignPattern.Bridge
{
    public interface Implementor
    {
        void implementation();
    }

    public class ConcreteImplementor1 : Implementor
    {
        public void implementation()
        {
            Console.WriteLine("1");
        }
    }

    public class ConcreteImplementor2 : Implementor
    {
        public void implementation()
        {
            Console.WriteLine("2");
        }
    }

    public abstract class Abstraction
    {
        protected Implementor impl;

        public void func()
        {
            impl.implementation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor impl)
        {
            this.impl = impl;
        }

    }

    class BridgePattern
    {
        public BridgePattern()
        {
            RefinedAbstraction[] refineds = new RefinedAbstraction[2];
            refineds[0] = new RefinedAbstraction(new ConcreteImplementor1());
            refineds[1] = new RefinedAbstraction(new ConcreteImplementor2());

            foreach (RefinedAbstraction refined in refineds)
            {
                refined.func();
            }
        }
    }
}