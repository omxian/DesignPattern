using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class FacadePattern
    {
        /*
            Facade Pattern(外观模式)
            提供了一个统一的接口，用来访问子系统中的一群接口。
            外观定义了一个高层接口，让子系统更容易使用。
            
            其实就是新增一个类，这个类的构造函数需要传递其它几个分别的类进来，
            然后这个类的职责就是提供由其它几个类组合过的方法。
            
            这样做一方面可以简化接口，另一方面也是将用户从组件的子系统中解耦。
         */
        public FacadePattern()
        {
            new HomeFacade(new Light(), new Door()).GoBackHome();
        }
    }

    public class HomeFacade
    {
        private Light light;
        private Door door;
        public HomeFacade(Light light,Door door)
        {
            this.light = light;
            this.door = door;
        }

        /// <summary>
        /// 回家有一系列操作
        /// 这里举两个例子开门，开灯
        /// </summary>
        public void GoBackHome()
        {
            door.OpenDoor();
            light.TurnOnLight();
        }

        /// <summary>
        /// 出门要关灯关门
        /// </summary>
        public void GoOut()
        {
            light.TurnOffLight();
            door.CloseDoor();
        }
    }

    public class Door
    {
        public void OpenDoor()
        {
            Console.WriteLine("Open The Door");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Close The Door");
        }
    }

    public class Light
    {
        public void TurnOnLight()
        {
            Console.WriteLine("Turn On The Light");
        }

        public void TurnOffLight()
        {
            Console.WriteLine("Turn Off The Light");
        }
    }
}
