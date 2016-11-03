using System;

namespace DesignPattern.Strategy
{
    class StrategyPattern
    {
        /*
            策略模式（Strategy Pattern）
            策略模式定义了算法族，
            分别封装起来,让他们之间可以互相替换，
            此模式让算法的变化独立于使用算法的客户。
         */
        public StrategyPattern()
        {
            ///*测试用例
            Duck test = new FlyQuackDuck();
            test.fly();
            test.SetFlyBehavior(new FlyWithRocket());
            test.fly();
            test.sound();
            /**/
        }
    }

    /// <summary>
    /// 假如要一个飞的鸭子并且Quack Quack叫
    /// </summary>
    public class FlyQuackDuck : Duck
    {
        public FlyQuackDuck()
        {
            flyBehavior = new FlyWithWings();
            soundBehavior = new Quack();
        }
    }

    /// <summary>
    /// 鸭子基类
    /// </summary>
    public class Duck
    {
        //算法族的基类，用其实现多态
        protected FlyBehavior flyBehavior;
        protected SoundBehavior soundBehavior;
        public void fly()
        {
            //默认不做任何事情
            if (flyBehavior != null)
            {
                //不关心当前是什么fly的类型
                flyBehavior.fly();
            }
        }

        public void sound()
        {
            if (soundBehavior != null)
            {
                soundBehavior.sound();
            }
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetSoundBehavior(SoundBehavior sb)
        {
            soundBehavior = sb;
        }
    }
    #region Fly Interface Define
    public interface FlyBehavior
    {
        void fly();
    }

    public class FlyWithWings:FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FlyWithWings");
        }
    }

    public class FlyWithRocket : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FlyWithRocket");
        }
    }
    #endregion
    #region Quack Interface Define
    public interface SoundBehavior
    {
        void sound();
    }

    public class Quack : SoundBehavior
    {
        public void sound()
        {
            Console.WriteLine("Quack");
        }
    }

    public class Squeak : SoundBehavior
    {
        public void sound()
        {
            Console.WriteLine("Squeak");
        }
    }
    #endregion
}
