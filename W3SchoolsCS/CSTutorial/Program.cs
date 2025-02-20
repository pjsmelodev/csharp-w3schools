using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetStarted();
            //Output();
            Variables();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void GetStarted()
        {
            Console.WriteLine("Hello, World!");
        }

        static void Output()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            Console.Write("Hello, World!");
            Console.Write("I will print on the same line.");
        }

        static void Comments() 
        {
            // This is a single-line comment
            /*
                This is a multi-line comment 
            */
        }

        static void Variables()
        {
            /*
                Sintaxe:
                type variableName = value;
            */
            string name = "John";
            Console.WriteLine(name);

            int myNym = 15;
            Console.WriteLine(myNym);
        }
    }
}
