using System;

namespace DesignPattern.Iterator
{
    class IteratorPattern
    {
        /*
         Iterator Pattern（迭代器模式）
         提供一种方法顺序访问一个聚合对象中的各个元素，
         而又不暴露其内部的表示。
         */
        public IteratorPattern()
        {
            Iterator iterator = new MenuIterator(new int[] { 1, 2, 3});
            Console.WriteLine(iterator.Next());
            Console.WriteLine(iterator.Next());
            Console.WriteLine(iterator.HasNext());
            Console.WriteLine(iterator.Next());
            Console.WriteLine(iterator.HasNext());
        }
    }
    
    public class MenuIterator : Iterator
    {
        private int[] menuItemArr;
        private int currentPosition;
        public MenuIterator(int[] arr)
        {
            menuItemArr = arr;
            currentPosition = 0;
        }
        public bool HasNext()
        {
            return currentPosition < menuItemArr.Length;
        }

        public object Next()
        {
            object result = menuItemArr[currentPosition];
            currentPosition++;
            return result;
        }

    }

    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
