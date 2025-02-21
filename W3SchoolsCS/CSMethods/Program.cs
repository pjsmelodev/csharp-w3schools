using System;

namespace CSMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyMethod();
            //MyMethod();
            //MyMethod();
            /*
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

            Console.WriteLine("\n##################################\n");

            MyMethod2("Liam", 5);
            MyMethod2("Jenny", 8);
            MyMethod2("Anja", 31);

            Console.WriteLine("\n##################################\n");

            MyMethod3();
            MyMethod3("Sweden");
            */

            Console.WriteLine(NewMethod(3));
            Console.WriteLine(NewMethod2(3, 6));

            int z = MyMethod2(5, 3);
            Console.WriteLine(z);

            NamedArguments(child3: "John", child1: "Liam", child2: "Liam");

            Console.WriteLine("\n##################################\n");

            Console.WriteLine(PlusMethod(8, 5));
            Console.WriteLine(PlusMethod(4.3, 6.26));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /*
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        */
        
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void MyMethod2(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age + " years old.");
        }

        /*
         * Parâmetro Standard
         *  Se nenhum argumento for passado, o parâmetro padrão é usado.
        */
        static void MyMethod3(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static int NewMethod(int x)
        {
            return x + 5;
        }

        static int NewMethod2(int x, int y) 
        {
            return x + y; 
        }

        static int MyMethod2(int x, int y)
        {
            return x + y;
        }

        static string NamedArguments(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
            return child3;
            // Aparentemente tem de retornar algo, mesmo que não seja usado
            // O WriteLine deveria estar no Main
        }

        // Method Overloading
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
