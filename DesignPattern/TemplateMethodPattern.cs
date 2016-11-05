using System;

namespace DesignPattern.TemplateMethod
{
    class TemplateMethodPattern
    {
        public TemplateMethodPattern()
        {
            /*
                Template Method Pattern(模板方法模式)
                在一个方法中定义一个算法的骨架，而将一些步骤延迟到子类中。
                模板方法使得子类可以在不改变算法结构的情况下，重新定义算法中的某些步骤。
            
                还可以使用钩子，让模板方法模式更灵活。    

                其实Unity中的Start,Update等方法就是使用了模板方法模式，
                C#中的IComparable也是很好的例子。
             */
            new MakeCoffee();
        }

        public class MakeCoffee : MakeDrink
        {
            /// <summary>
            /// 重新实现了某个算法
            /// </summary>
            public override void Brew()
            {
                Console.WriteLine("Brew Coffee");
            }

            public override bool IsCustom()
            {
                return true;
            }

            public override void CustomHook()
            {
                Console.WriteLine("Custom void Hook");
            }
        }

        public abstract class MakeDrink
        {
            public MakeDrink()
            {
                BoilWater();
                Brew();
                PourInCup();
                //有两种钩子方法
                //这种做法称为挂钩
                if (IsCustom())
                {
                    Custom();
                }
                //这种需要实现方法默认为空
                CustomHook();
            }

            public void BoilWater()
            {
                Console.WriteLine("Boil water");
            }
            public abstract void Brew();
            
            public virtual bool IsCustom()
            {
                return false;
            }
            public void Custom()
            {
                Console.WriteLine("Custom");
            }

            public virtual void CustomHook()
            {

            }

            public void PourInCup()
            {
                Console.WriteLine("PourInCup");
            }
        }
    }
}