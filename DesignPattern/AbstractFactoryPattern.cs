using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class AbstractFactoryPattern
    {
        /*
            Abstract Factory Pattern(抽象工厂方法)
            提供一个接口，用于创建相关或依赖对象的家族，
            而不需要明确指定具体类。

            通过对象来实例对象,
            通过对象的组合来使用
         */
        public AbstractFactoryPattern()
        {
            ICarFactory factory = new FactoryBMW();
            //使用的时候不需要知道factory在哪里定义，
            //可以作为参数传给下面，
            //只需要用其基类暴露出来的方法即可。
            ProduceCar(factory);
        }

        public void ProduceCar(ICarFactory factory)
        {
            factory.ProduceFourDoorCar();
            factory.ProduceTwoDoorCar();
        }
    }

    public class FactoryBMW : ICarFactory
    {
        public ICar ProduceFourDoorCar()
        {
            Console.WriteLine("Producing BMW Four Door Car!");
            return new BMWFourDoorCar();
        }

        public ICar ProduceTwoDoorCar()
        {
            Console.WriteLine("Producing BMW Two Door Car!");
            return new BMWTwoDoorCar();
        }
    }

    public class FactoryBenz : ICarFactory
    {
        public ICar ProduceFourDoorCar()
        {
            Console.WriteLine("Producing Benz Four Door Car!");
            return new BenzFourDoorCar();
        }

        public ICar ProduceTwoDoorCar()
        {
            Console.WriteLine("Producing Benz Two Door Car!");
            return new BenzTwoDoorCar();
        }
    }

    public interface ICarFactory
    {
        ICar ProduceTwoDoorCar();
        ICar ProduceFourDoorCar();
    }

    public interface ICar
    {
    }

    public class BMWTwoDoorCar : ICar
    {
    }

    public class BenzTwoDoorCar : ICar
    {
    }

    public class BMWFourDoorCar : ICar
    {
    }
    public class BenzFourDoorCar : ICar
    {
    }
}
