using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorate
{
    class DecoratePattern
    {
        /*
            Decorate Pattern(装饰者模式)
            装饰者模式动态地将责任附加到对象上。
            若要扩展功能，装饰者提供了比继承更有弹性地替代方案。

            装饰者模式通常是用其它类似工厂或生成器这样的模式创建的。
         */
        public DecoratePattern()
        {
            ///*测试用例
            Console.WriteLine(new Milk(new Mocha(new DarkRoast())).Cost()); //17.5
            Console.WriteLine(new Mocha(new DarkRoast()).Cost()); //16.2
            Console.WriteLine(new DarkRoast().Cost()); //15
            /**/
        }

        /// <summary>
        /// 所有组件的基类
        /// </summary>
        public abstract class Beverage
        {
            public string description = "Unknow Beverage";

            public string GetDescription()
            {
                return description;
            }

            public abstract double Cost();
        }

        /// <summary>
        /// 装饰组件的基类
        /// </summary>
        public abstract class CondimentDecorate : Beverage
        {
            //这里可能会对组件基类的一些方法进行重写
        }


        public class Milk : CondimentDecorate
        {
            private Beverage beverage;
            public Milk(Beverage beverage)
            {
                this.beverage = beverage;
            }
            public override double Cost()
            {
                return 1.3 + beverage.Cost();
            }
        }

        public class Mocha : CondimentDecorate
        {
            private Beverage beverage;
            public Mocha(Beverage beverage)
            {
                this.beverage = beverage;
            }
            public override double Cost()
            {
                return 1.2 + beverage.Cost();
            }
        }

        /// <summary>
        /// 具体组件
        /// </summary>
        public class DarkRoast : Beverage
        {
            public override double Cost()
            {
                return 15;
            }
        }

        /// <summary>
        /// 具体组件
        /// </summary>
        public class Espresso : Beverage
        {
            public override double Cost()
            {
                return 10;
            }
        }
    }
}
