using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePro
{
    class NewStack<T>
    {
        private int top;
        private T[] stkArr;
        private int maxSize;

        /// <summary>
        /// 表示栈顶索引
        /// </summary>
        public int Top
        {
            set { top = value; }
            get { return top; }
        }

        public T[] StkArr
        {
            set { stkArr = value; }
            get { return stkArr; }
        }

        public int MaxSize
        {
            get { return maxSize; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("maxSize is d 0!");
                }
                else
                {
                    maxSize = value;
                }
            }
        }

        public NewStack(int maxSize)
        {
            this.MaxSize = maxSize;
            this.StkArr = new T[maxSize];
            Top = 0;
        }
        /// <summary>
        /// 出栈
        /// </summary>
        public T pop()
        {
            if (isNull())
            {
                throw new Exception("栈为空!");
            }
            else
            {
                return StkArr[--Top];
            }
        }

        /// <summary>
        /// 入栈
        /// </summary>
        public void pash(T value)
        {
            if (isFull())
            {
                throw new Exception("栈已满!");
            }
            else
            {
                StkArr[top++] = value;
            }
        }

        /// <summary>
        /// 判断栈是否已满
        /// </summary>
        /// <returns></returns>
        public bool isFull()
        {
            return (Top == MaxSize);
        }

        /// <summary>
        /// 判断栈是否为空
        /// </summary>
        /// <returns></returns>
        public bool isNull()
        {
            return (Top == 0);
        }

        /// <summary>
        /// 返回栈大小
        /// </summary>
        /// <returns></returns>
        public int getMaxSize()
        {
            return MaxSize;
        }

        /// <summary>
        /// 遍历栈
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetEnumerable()
        {
            for (int i = 0; i < MaxSize; i++)
            {
                yield return stkArr[i];
            }
        }
    }
}
