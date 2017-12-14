using System;

namespace StackLibrary
{
    public class StackException : ApplicationException
    {
        private string msg;
        public StackException()
        {
            msg = "栈错误。";
        }
        public StackException(string message,Exception inner):base(message,inner)
        {

        }
        public StackException(string message) : base(message)
        {
            msg = message;
        }
        public override string ToString() // 重写ToString方法,请看下面override说明
        {
            return msg;
        }
    }
}
