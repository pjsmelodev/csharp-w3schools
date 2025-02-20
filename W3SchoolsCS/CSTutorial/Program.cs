using System;

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
            //DisplayVariables();
            //MultipleVariables();
            //DataTypes();
            //TypeCasting();
            //UserInput();
            //Operators();
            //MathStuff();
            //Strings();
            //Booleans();
            //Conditionals();
            Switch();

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

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);
        }

        static void MultipleVariables()
        {
            //int x = 5, y = 6, z = 50;
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
        }

        static void DataTypes() 
        {
            //Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            string greeting = "Hello";
            Console.WriteLine(greeting);
        }

        static void TypeCasting() 
        {
            // Implicit casting
            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int
            Console.WriteLine(myInt2);
            Console.WriteLine(myDouble2);

            // Type Conversion Methods
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));    // convert bool to string

            int myInt4 = 10;
            double myDouble4 = 5.25;
            bool myBoolean4 = true;

            Console.WriteLine(Convert.ToSingle(myInt4));
            Console.WriteLine(Convert.ToDouble(myInt4));
            Console.WriteLine(Convert.ToInt32(myDouble4));
            Console.WriteLine(Convert.ToString(myBoolean4));
        }

        static void UserInput()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");
        }

        static void Operators()
        {
            int sum1 = 100 + 50;
            Console.WriteLine(sum1);
            int sum2 = sum1 + 250;
            Console.WriteLine(sum2);
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum3);

            int x = 10;
            x += 5;
            Console.WriteLine(x);

            int y = 5;
            int z = 3;
            Console.WriteLine(y > z);
        }

        static void MathStuff()
        {
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));
        }

        static void Strings()
        {
            string greeting = "Hello";
            string greeting2 = "Nice to meet you!";
            string sentence = greeting + " " + greeting2;
            Console.WriteLine(sentence);

            string txt1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt1.Length);

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower());

            /*
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            */
            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            // Quando os caracteres ou strings com valores numéricos usam o operador + dá-se concatenação
            // Para fazer a soma, é necessário converter os valores para inteiros
            string x = "10";
            string y = "20";
            Console.WriteLine(x + y);   // Outputs 1020

            // String Interpolation
            string firstName2 = "John";
            string lastName2 = "Doe";
            string name2 = $"My full name is: {firstName2} {lastName2}";
            Console.WriteLine(name2);

            string myString = "Hello";
            Console.WriteLine(myString[0]);     // Outputs H
            Console.WriteLine(myString[1]);     // Outputs e
            Console.WriteLine(myString.IndexOf('e'));   // Outputs 1

            string fullName = firstName2 + " " + lastName2;
            int charPos = fullName.IndexOf('D');
            string lastName3 = fullName.Substring(charPos);
            Console.WriteLine(lastName3);

            // Special Characters
            string txtX = "We are the so-called \"Vikings\" from the north.";
            string txtY = "It\'s alright.";
            string txtZ = "The character \\ is called backslash.";
        }

        static void Booleans()
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            /*
            int myAge = 25;
            int votingAge = 18;
            bool canIVote = myAge >= votingAge;
            Console.WriteLine(canIVote);
            */

            //int myAge = 25;
            Console.Write("Enter your age: ");
            int myAge = Console.Read();
            int votingAge = 18;

            if (myAge >= votingAge)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote!");
            }
        }

        static void Conditionals()
        {
            /*
                Sintaxe:
                if (condition)
                {
                    // code block
                } else if (condition2) {
                    // code block
                } else {
                    // code block
                }
            */

            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            /*
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            */

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            } else if (time < 20)
            {
                Console.WriteLine("Good day.");
            } else
            {
                Console.WriteLine("Good evening.");
            }

            // Operador Ternário
            // Sintaxe: variable = (condition) ? expressionTrue : expressionFalse;

            int time2 = 20;
            string result = (time2 < 18) ? "Good day." : "Good evening.";
        }

        static void Switch()
        {

        }
    }
}
