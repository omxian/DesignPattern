using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    class ProxyPattern
    {
        /*
            Proxy Pattern（代理模式）
            为另一个对象提供一个替身或占位符以控制这个对象的访问。

            它和装饰器模式有点像，基本是用一个对象把另外一个对象包裹起来，
            但是他们两个的意图时是不一样的。
            装饰器模式为对象增加了新功能，而代理模式是控制对象的访问。
        */ 
        public ProxyPattern()
        {
            new Image().Load();
        }

    }

    public class Image : Icon
    {
        public void Load()
        {
            Console.WriteLine("Loading Image");
            new RealImage().Load();
        }
    }

    public class RealImage : Icon
    {
        public void Load()
        {
            Console.WriteLine("Loading Real Image");
        }
        //可能还有其它方法,没有暴露出来
    }

    public interface Icon
    {
        void Load();
    }
}
