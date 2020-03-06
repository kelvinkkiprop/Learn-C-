using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call this mthods
            HelloWorld();
            MyVariables();
            UserInput();
            MyOperators();
            Maths();
            MyStrings();
            myBoolens();
            MyConditions();
        }

        static void HelloWorld()
        {
            //Display Hello World
            Console.WriteLine("Hello World!");
            Console.WriteLine("I will print on a new line.");

            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
        }

        static void MyVariables()
        {
            //Show String
            string name = "Kelvin Kiprop";
            //Numbers
            int myNum = 15;
            myNum = 20; // myNum1 is now 20
            int sum = myNum + 5;
            const double pie = 3.14;
            double myDoubleNum = 5.99D;
            char myLetter = 'K';
            bool myBool = true;
            Console.WriteLine("\n\nMy name starts with " + myLetter + " the is " + name
                + " I love using pie " + pie + " in Maths especialy when dealing with "
                + myDoubleNum + "," + sum + " and " + myNum + " and that is " + myBool);

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);


            //Type casting
            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9

        }



        static void MyOperators()
        {
            //Values
            int numb1 = 100;
            int numb2 = 50;
            int sum = numb1 + numb2;
            int diff = numb1 - numb2;
            Console.WriteLine("Sum: " + sum + " Diff: " + diff);

        }

        static void UserInput()
        {
            // Type your username and press enter
            Console.WriteLine("Enter your name:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string name = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Your name is: " + name);

        }

        static void Maths()
        {
            // Variable get min max
            int min = Math.Min(5, 10);
            int max = Math.Max(5, 10);
            Double squareroot = Math.Sqrt(64);//Square root
            Double postiveValue = Math.Abs(-4.7); //Return absolute (positive)
            Double roundOff = Math.Round(9.99); //Round off
            Console.WriteLine("Min number is: " + min + " and max is " + max + "," +
                " squareroot of 64 is" + squareroot + "," +
                " postive value of -4.7 is " + postiveValue + "," +
                " round off of 9.99 is " + roundOff);
        }


        static void MyStrings()
        {
            // Variable
            string greeting = "Hello World";
            string greetingToUppercase = greeting.ToUpper();   // Outputs "HELLO WORLD"
            string greetingToLowercase = greeting.ToLower();   // Outputs "hello world"
            Console.WriteLine(greeting + " length is: " + greeting.Length + "" +
                " " + greeting + " to uppercase is: " + greetingToUppercase +
                " " + greeting + " to lowercase is: " + greetingToLowercase);

            //String Concatenation
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);

            //String Interpolation
            string firstName1 = "John";
            string lastName1 = "Doe";
            string name3 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name3);

            //Access Strings
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            //GET LAST NAME
            // Full name
            string name4 = "John Doe";
            // Location of the letter D
            int charPos = name.IndexOf("D");
            // Get last name
            string lastName4 = name4.Substring(charPos);
            // Print the result
            Console.WriteLine(lastName4);

            //The sequence \"  inserts a double quote in a string:
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);
            //The sequence \'  inserts a single quote in a string:
            string txt1 = "It\'s alright.";
            Console.WriteLine(txt1);
            //The sequence \\  inserts a single backslash in a string:
            string txt2 = "The character \\ is called backslash.";
            Console.WriteLine(txt2);

        }

        static void myBoolens()
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

        }

        static void MyConditions()
        {
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)

        }
   }
}
