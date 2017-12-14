using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLibrary
{
    public class MyStack<T>
    {
        public static int STACK_INIT_SIZE = 1000;//栈最大值
        public static int STACKINCREMENT = 10;//增量数//未使用
        public int stackSize { get; set; }//栈个数
        public int topPointer { get; set; }//栈顶指针（数组最后元素位置）
        public int basePointer { get; set; }//栈底指针
        private T[] arrayList;//栈数组

        public MyStack()
        {
            InitStack();
        }
        public MyStack(int initSize, int increment)
        {
            STACK_INIT_SIZE = initSize;
            STACKINCREMENT = increment;
            InitStack();
        }
        /**
        * 
        * 栈初始化
        * 
        * */
        private void InitStack()
        {
            arrayList = new T[STACK_INIT_SIZE];
            stackSize = STACK_INIT_SIZE;
            topPointer = basePointer = 0;
        }
        /**
        * 
        * 清空栈
        * 
        * */
        public bool ClearStack()
        {
            InitStack();
            return true;
        }

        /**
         * 
         * 获取栈内元素个数
         * 
         * */
        public int StackLength()
        {
            int count = 0;
            while (topPointer != basePointer)
            {
                topPointer--;
                count++;
            }
            return count;
        }
        /**
        * 
        * 判断栈空，空为true
        * 
        * */
        public bool StackEmpty()
        {
            if (topPointer == basePointer) return true;

            return false;
        }
        /**
        * 
        * 获取栈顶元素
        * 
        * */
        public T GetTop()
        {

            if (StackEmpty())
            {
                try
                {
                    throw new StackException("获取栈顶元素失败，栈已空。");
                }
                catch (StackException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return default(T);
                }
            }
            T t = arrayList[topPointer - 1];
            return t;
        }
        /**
        * 
        * 入栈
        * 
        * */
        public void Push(T item)
        {
            if (topPointer - basePointer == STACK_INIT_SIZE)
            {
                try
                {
                    throw new StackException("入栈失败，栈已满。");
                }
                catch (StackException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }
            arrayList[topPointer] = item;
            topPointer++;
        }
        /**
        * 
        * 出栈
        * 
        * */
        public T Pop()
        {
            if (StackEmpty())
            {
                try
                {
                    throw new StackException("出栈失败，栈已空。");
                }
                catch (StackException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return default(T);
                }
            }
            topPointer--;
            T t = arrayList[topPointer];

            return t;
        }
    }
}
