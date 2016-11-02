using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class FactoryMethodPattern
    {
        /*
            Factory Method Pattern(工厂方法模式)
            定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个。
            工厂方法把实例化推迟到子类。

            如果由新的一套实例化规则，可以简单的新建一个新的工厂。
            面向修改封闭，面向扩展开放。
         */

        public FactoryMethodPattern()
        {
            ///*测试代码
            //由子类决定要实例化的是什么类
            new FactoryA().Produce(ProductType.A);
            new FactoryB().Produce(ProductType.A);
            /**/
        }
    }

    /// <summary>
    /// 每个子类的具体是实现可以完全不同
    /// </summary>
    public class FactoryB : IFactory
    {
        public IProduct Produce(ProductType type)
        {
            if (type == ProductType.A)
            {
                return new ProductA();
            }
            else
            {
                return new ProductD();
            }
        }
    }

    public class FactoryA : IFactory
    {
        public IProduct Produce(ProductType type)
        {
            if (type == ProductType.A)
            {
                return new ProductA();
            }
            else 
            {
                return new ProductB();
            }
        }
    }
    public class ProductA : IProduct
    {
    }
    public class ProductB : IProduct
    {
    }
    public class ProductC : IProduct
    {
    }
    public class ProductD : IProduct
    {
    }

    /// <summary>
    /// 工厂的基类，暴露在外的接口
    /// </summary>
    public interface IFactory
    {
        //子类可以自己决定怎么去实例化
        IProduct Produce(ProductType productType);
    }

    /// <summary>
    /// 工厂实例化的基类
    /// </summary>
    public interface IProduct
    {
    }

    public enum ProductType
    {
        A,
        B,
        C,
        D
    }
}
