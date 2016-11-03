using System;
using DesignPattern.AbstractFactory;
using DesignPattern.Decorate;
using DesignPattern.FactoryMethod;
using DesignPattern.Observer;
using DesignPattern.Singleton;
using DesignPattern.Strategy;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new SingletonPattern();
            //在此处new一个对应的模式
            Console.ReadKey();
        }
    }
}
