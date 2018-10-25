using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 适用性：
    /// 1.当创建负责对象的算法应该独立于该对象的组成部分以及它们的装配方式时
    /// 2.当构造过程必须允许被构造的对象有不同的表示时
    /// </summary>
    public class BuilderPattern
    {
        //Client
        public BuilderPattern()
        {
            //随意替换具体Builder,不可用基类，见下注释
            ConcreteBuilder2 builder = new ConcreteBuilder2();
            //Director如有需要也可以切换
            Director director = new Director(builder);
            director.Construct();

            //具体构造器返回具体结果,可以将结果直接返回
            //因可能会构造出不同的结果，因此不能将这个方法作为Builder基类，需客户端自行调用
            builder.GetResult();
        }
    }

    /// <summary>
    /// 可以根据需要构建不同产品
    /// </summary>
    public class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }

    public class Builder
    {
        public virtual void BuildPart1() { }
        public virtual void BuildPart2() { }
        public virtual void BuildPart3() { }
    }


    public class ConcreteBuilder1 : Builder
    {
        //可以只实现自己特定的方法
        public override void BuildPart2()
        {
            Console.WriteLine("Build Part2.");
        }

        public void GetResult()
        {
            Console.WriteLine("Get Product 1");
        }
    }

    public class ConcreteBuilder2 : Builder
    {
        public override void BuildPart1()
        {
            Console.WriteLine("Build Part1.");
        }

        public override void BuildPart2()
        {
            Console.WriteLine("Build Part2.");
        }

        public override void BuildPart3()
        {
            Console.WriteLine("Build Part3.");
        }
        
        public void GetResult()
        {
            Console.WriteLine("Get Product 2");
        }
    }
}
