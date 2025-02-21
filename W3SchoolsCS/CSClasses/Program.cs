using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClasses
{
    /*
    class Car
    {
        internal string color = "red";      // É acessível em todo o assembly
        //public string color = "red";        // É acessível em qualquer lugar
    }
    */

    class MyClass
    {
        internal string color = "red";
        internal int maxSpeed = 200;
        internal void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class NewCar
    {
        internal string model;
        internal string color;
        internal int year;
    }

    /*
    class Car
    {
        public string model;        // Field

        public Car()        // Constructor
        {
            model = "Mustang";
        }
    }
    */

    /*
    // Construtor com parâmetros
    class Car
    {
        public string model;

        public Car(string modelName)
        {
            model = modelName;
        }
    }
    */

    class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
            */

            /*
            MyClass myObj = new MyClass();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.fullThrottle();

            Console.WriteLine("\n##########################################\n");

            NewCar Ford = new NewCar();
            Ford.model = "Mustang";
            Ford.color = "Red";
            Ford.year = 1969;

            NewCar Opel = new NewCar();
            Opel.model = "Astra";
            Opel.color = "White";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.color);
            */

            /*
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
            */

            /*
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
            */

            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.model + " " + Ford.color + " " + Ford.year);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
