using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.MyFunc(fun);

            
        }
        public static void fun(int i)
        {
            Console.WriteLine(i);
        }

    }
    class MyClass
    {
        public delegate void CallDel(int i);

        public void MyFunc(CallDel d)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(3000);
                d(i);
            }
        }
    }
}
