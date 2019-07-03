using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new A(" Information"));//должно вывестись А: В: Information
            Console.Read();
        }
        
    }
    class A
    {
        B b;
        string line;
        public A(string line)
        {
            this.line = line;
            //ToDo инициализируйте b
        }
        public override string ToString() => $"A: {b}";

        class B
        {
            public B(A a)
            {
                this.a = a;
            }
            A a;
            public override string ToString() => $"B: {a.line}";
        }
    }
}
