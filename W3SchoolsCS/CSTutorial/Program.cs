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
            //Variables();
            //Constants();
            DisplayVariables();

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

            /*
            //int myNum = 15;
            int myNum;
            myNum = 15;
            Console.WriteLine(myNum);
            */

            int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum);

            // Outros tipos de variáveis
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
        }

        static void Constants() 
        {
            const int myNum = 15;
            //myNum = 20; // error
            Console.WriteLine(myNum);
        }

        static void DisplayVariables()
        { 
            string name = "John";
            Console.WriteLine("Hello " + name + '!');

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
        }
    }
}
