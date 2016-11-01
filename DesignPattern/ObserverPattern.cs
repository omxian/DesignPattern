using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class ObserverPattern
    {
        /*
            Observer Pattern(观察者模式)
            观察者模式定义了对象之间的一对多依赖，
            这样一来，当一个对象改变状态时，
            它的所有依赖者都会收到通知并自动更新。
            Don't call me, I call you.

            在我的理解里面游戏框架中经常用的全局消息系统就是使用了观察者模式（变种？）。
         */

        public ObserverPattern()
        {
            ///*测试用例
            WeatherData subject = new WeatherData();
            DisplayPanel observer = new DisplayPanel(subject);
            subject.NotifyObserver();
            observer.RemoveSubject();
            subject.NotifyObserver();
            /**/
        }
    }
    
    public class WeatherData : ISubject
    {
        private List<IObserver> observerList;

        public WeatherData()
        {
            observerList = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            int[] arr = new int[2];
            arr[0] = 100;
            arr[1] = 120;

            for (int i = 0; i < observerList.Count; i++)
            {
                //这里是推模式，subject将参数传递
                //拉模式Update函数不带参数,由observer自己取拿需要的数据
                observerList[i].Update(arr);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observerList.Add(o); 
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }
    }

    public class DisplayPanel : IObserver
    {
        private ISubject subject;

        public DisplayPanel(ISubject s)
        {
            subject = s;
            subject.RegisterObserver(this);
        }
       
        public void RemoveSubject()
        {
            if (subject != null)
            {
                subject.RemoveObserver(this);
            }
        }

        public void Update(object arg)
        {
            int[] arr = (int[])arg;
            Console.WriteLine( string.Format("{0},{1}",arr[0],arr[1]));
        }
    }

    #region 定义接口
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        void Update(Object arg);
    }

    /// <summary>
    /// 主题接口
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
    #endregion
}
