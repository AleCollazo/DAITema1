using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public delegate void MyDelegate();

        public static void MenuGenerator(string[] options, MyDelegate[] functions)
        {
            int op = 0;
            int i;
            do {
                for (i = 1; i <= options.Length; i++) {
                    Console.WriteLine("{0}- {1}", i, options[i - 1]);
                }
                Console.WriteLine("{0}- {1}", i, "Exit");
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción no válida");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Opción no válida");
                }
                if (op < 1 || op > i) functions[op - 1]();
                else Console.WriteLine("Opción no válida");
                if (op == i) Environment.Exit(0);
            } while (true);
            
            
        }

        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }

        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
                new MyDelegate[] { f1, f2, f3});

            Console.ReadKey();
        }
    }
}
