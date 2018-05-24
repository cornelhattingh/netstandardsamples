using NetSTD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();
        }

        private static void Foo()
        {
            var class1 = new Class1();
            class1.Foo(System.IO.Ports.Parity.Even);
        }        
    }
}
