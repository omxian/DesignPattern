using System;
using DesignPattern.AbstractFactory;
using DesignPattern.Decorate;
using DesignPattern.FactoryMethod;
using DesignPattern.Observer;
using DesignPattern.Singleton;
using DesignPattern.Strategy;
using DesignPattern.Command;
using DesignPattern.Adapter;
using DesignPattern.Facade;
using DesignPattern.TemplateMethod;
using DesignPattern.Iterator;
using DesignPattern.Composite;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //在此处new一个对应的模式
            new CompositePattern();
            Console.ReadKey();
        }
    }
}
