using System;

namespace DesignPattern.Adapter
{
    class AdapterPattern
    {
        /*
            Adapter Pattern(适配者模式)
            将一个类的接口，转换成客户期望的另一个接口。
            适配器让原本接口不兼容的类可以合作无间。
         
            这个例子用的是对象适配器，
            还有一种适配器通过多重继承实现，称为类适配器。
         
         */
        public AdapterPattern()
        {
            //适配器看起来和装饰器很像，但是他们的意图不一样。
            new DogAdapter(new Dog()).Quack();
        }
    }

    public interface IDuck
    {
        void Quack();
        void Fly();
    }

    public class Duck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    /// <summary>
    /// 我们的需求是把"Dog"当成"Duck"来用
    /// </summary>
    public class Dog
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }

    /// <summary>
    /// 有了这个适配器 就能将"Dog",当成"Duck"来用
    /// 通过实现"Duck"的接口，或者继承"Duck"类来实现
    /// </summary>
    public class DogAdapter : IDuck
    {
        private Dog dog;
        public DogAdapter(Dog dog)
        {
            this.dog = dog;
        }

        public void Fly()
        {
            dog.Jump();
        }

        public void Quack()
        {
            dog.Bark();
        }
    }
}
