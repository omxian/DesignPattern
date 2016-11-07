using System;
using System.Collections.Generic;

namespace DesignPattern.Composite
{
    class CompositePattern
    {
        /*
         Composite Pattern（组合模式）
         允许你将对象组合成树形结构来表现“整体/部分”层次结构。
         组合能让客户以一致的方式处理个别对象以及对象组合。
         */
        public CompositePattern()
        {
            MenuItem item0 = new MenuItem();
            MenuAnotherItem item1 = new MenuAnotherItem();
            MenuItem item2 = new MenuItem();
            Menu menu = new Menu();
            menu.Add(item0);
            menu.Add(item1);
            menu.Add(item2);
            Menu anotherMenu = new Menu();
            anotherMenu.Add(menu);
            anotherMenu.ComponentMethod();
        }
    }

    public class MenuAnotherItem : Component
    {
        public override void ComponentMethod()
        {
            Console.WriteLine("I am MenuAnotherItem");
        }
    }

    public class MenuItem : Component
    {
        public override void ComponentMethod()
        {
            Console.WriteLine("I am MenuItem");
        }
    }

    public class Menu : Component
    {
        private List<Component> componentList;
        public Menu()
        {
            componentList = new List<Component>();
        }

        public override void Add(Component c)
        {
            componentList.Add(c);
        }

        public override void Remove(Component c)
        {
            componentList.Remove(c);
        }

        public override Component GetChild(int i)
        {
            return componentList[i];
        }
        public override void ComponentMethod()
        {
            for (int i = 0; i < componentList.Count; i++)
            {
                componentList[i].ComponentMethod();
            }
        }
    }

    public abstract class Component
    {
        public virtual void Add(Component c)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component c)
        {
            throw new NotImplementedException();
        }
        public virtual Component GetChild(int i)
        {
            throw new NotImplementedException();
        }
        public virtual void ComponentMethod()
        {
            throw new NotImplementedException();
        }
        public virtual void PrintAll()
        {
            throw new NotImplementedException();
        }
    }
}
