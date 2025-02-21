using System;
using System.IO;

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

    /*
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
    */

    /*
    *   Access Modifiers
    *   Modifier	Description
        public	    The code is accessible for all classes
        private	    The code is only accessible within the same class
        protected	The code is accessible within the same class, or in a class that is inherited from that class. 
        internal	The code is only accessible within its own assembly, but not from another assembly. 
    */

    /*
    // Private Modifier -> Não vai ser possível aceder 
    // Se não for definido nenhum modificador, o campo é privado por defeito
    class Car
    {
        private string model = "Mustang";
    } 
    */

    /*
    class Car
    {
        public string model = "Mustang";
    }
    */

    /*
     * Encapsulamento -> Proteger os campos de uma classe, para que não possam ser acedidos diretamente de fora da classe
     * Para obter encapsulamento é necessário definir os campos como privados e criar métodos públicos para aceder a esses campos
     * read-only -> Apenas é possível ler o valor, não é possível alterar
     *  Apenas se define o get
     * write-only -> Apenas é possível alterar o valor, não é possível ler
     *  Apenas se define o set
    */
    class Person
    {
        private string name;    // field

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Propriedades automáticas
        public string Name2 { get; set; }
    }

    /*
     * Inheritance
     *  Derived Class (child) - the class that inherits from another class
     *  Base Class (parent) - the class being inherited from
     * Para se herdar de uma class mãe é necessário usar o : e o nome da classe mãe
    */
    class Vehicle   // Base class (parent)
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()  // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle     // Derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
    // sealed -> Impede herença de uma classe
    // sealed class Car -> não vai herdar da class Vehicle

    /*
     * Polimorfismo
     * Permite que as classes derivadas possam substituir ou estender a funcionalidade da classe base
    */
    /*
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
        // É preciso usar virtual para permitir que as classes derivadas substituam o método
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
        // É preciso usar override para substituir o método da classe base
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
        // É preciso usar override para substituir o método da classe base
    }
    */

    /*
     * Abstract Classes and Methods
     * Consiste em esconder certos detalhes e mostrar apenas a funcionalidades essenciais de um objeto
     *  Abstract Class -> Não pode ser instanciada -> tem de ser herdada por outra class
     *  Abstract Method -> Só pode ser usado numa classe abstrata e não tem corpo
    */
    /*
    abstract class Animal
    {
        public abstract void animalSound();     // Não tem corpo
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    */

    /*
     * Interfaces: classes completamente abstratas que são usadas para agrupar métodos relacionados com corpos vazios
     * Útil quando se quer criar métodos que devem ser implementados em várias classes
    */
    interface IAnimal
    {
        void animalSound();     // interface method (does not have a body)
    }

    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    // Multiple Interfaces
    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    // Enums -> Usado para declarar um conjunto de constantes nomeadas
    // Podem ou não estar dentro de uma class
    enum Level
    {
        Low,
        Medium,
        High
    }

    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }

    /*
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }
    */

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

            /*
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.model + " " + Ford.color + " " + Ford.year);
            */

            /*
            Car myObj = new Car();
            Console.WriteLine(myObj.model);     
            */

            Person myPerson = new Person();
            myPerson.Name = "Liam";
            myPerson.Name2 = "John";
            Console.WriteLine(myPerson.Name);
            Console.WriteLine(myPerson.Name2);

            Console.WriteLine("\n##########################################\n");

            Car myCar = new Car();

            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Console.WriteLine("\n##########################################\n");

            /*
            Animal myAnimal = new Animal();     // Create a Animal object
            Animal myPig = new Pig();           // Create a Pig object
            Animal myDog = new Dog();           // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            */

            /*
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
            */

            Pig myPig = new Pig();
            myPig.animalSound();

            DemoClass myObj = new DemoClass();

            myObj.myMethod();
            myObj.myOtherMethod();

            Console.WriteLine("\n##########################################\n");

            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            Console.WriteLine("\n##########################################\n");

            Months myMonth = Months.April;
            Console.WriteLine(myMonth);

            int myMonthNum = (int)Months.April;
            Console.WriteLine(myMonthNum);

            Console.WriteLine("\n##########################################\n");

            Level myVar2 = Level.Medium;
            switch (myVar2)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
                default:
                    break;
            }

            Console.WriteLine("\n##########################################\n");

            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            /*
             *  Method	Description
                AppendText()    Appends text at the end of an existing file
                Copy()	        Copies a file
                Create()	    Creates or overwrites a file
                Delete()	    Deletes a file
                Exists()	    Tests whether the file exists
                ReadAllText()	Reads the contents of a file
                Replace()	    Replaces the contents of a file with the contents of another file
                WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
            */

            Console.WriteLine("\n##########################################\n");

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            //checkAge(15);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
