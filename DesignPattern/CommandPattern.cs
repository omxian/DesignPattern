using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    class CommandPattern
    {
        /*
            Command Pattern（命令模式）
            将“请求”封装成对象，以便使用不同的请求，
            队列或者日志来参数化其它对象。命令模式也支持可撤销的操作。

            命令模式是用命令模式实现的,
            可以参考下StrategyPattern
         */
        public CommandPattern()
        {
            ICommand[] excuteCommandArr = new ICommand[]{ new FlyWithRocketCommand(), new QuackCommand()};
            new MacroCommand(excuteCommandArr).Excute();
        }
    }

    public class FlyWithWingsCommand : ICommand
    {
        public void Excute()
        {
            Console.WriteLine("FlyWithWings");
        }
    }

    public class FlyWithRocketCommand : ICommand
    {
        public void Excute()
        {
            Console.WriteLine("FlyWithRocket");
        }
    }

    public class QuackCommand : ICommand
    {
        public void Excute()
        {
            Console.WriteLine("Quack");
        }
    }

    public class SqueakCommand : ICommand
    {
        public void Excute()
        {
            Console.WriteLine("Squeak");
        }
    }

    /// <summary>
    /// 可混合执行多个Command的宏命令
    /// </summary>
    public class MacroCommand : ICommand
    {
        private ICommand[] commandArr;
        public MacroCommand(ICommand[] commandArr)
        {
            this.commandArr = commandArr;
        }

        public void Excute()
        {
            for (int i = 0; i < commandArr.Length; i++)
            {
                commandArr[i].Excute();
            }
        }
    }

    /// <summary>
    /// 不做任何事情的空命令
    /// </summary>
    public class NoCommand : ICommand
    {
        public void Excute()
        {
        }
    }
    /// <summary>
    /// 核心接口
    /// </summary>
    public interface ICommand
    {
        void Excute();

        //如果有Undo的需求可以在这里实现
        //void Undo();
    }
}
