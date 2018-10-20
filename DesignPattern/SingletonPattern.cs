using System;

namespace DesignPattern.Singleton
{
    class SingletonPattern
    {
        /*
            Singleton Pattern(单件模式)
            确保一个类只有一个实例，
            并提供一个全局访问点。

            游戏中的管理器（资源，配置，音频等）一般都会使用单件模式
            在Unity中可以使用MonoSingleton(类似单件，但是需要挂在不销毁的对象上)
         */
        public SingletonPattern()
        {
            Singleton.Instance.TestMethod();
        }
    }

    public class Singleton
    {
        private Singleton()
        {
            //隐藏掉实例方法，只能通过其它途径来new
        }

        private static Singleton instance;
        private static object lockObject = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    //防止在多线程环境中创建了多个对象
                    lock (lockObject)
                    {
                        instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public void TestMethod()
        {
            Console.WriteLine("Hi");
        }
    }
}