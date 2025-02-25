// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// ----DRAWING A SHAPE---

//  namespace giraffe;
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Capital "C" and WriteLine (like log)
//         // Console.WriteLine("Hello World!");

//         //Making a shape
//         Console.WriteLine("    /|");
//         Console.WriteLine("   / |");
//         Console.WriteLine("  /  |");
//         Console.WriteLine(" /___|");

//             //keeps window open to see what we're printing out (pauses)
//         Console.ReadLine();
//         }
//     }

// ---VARIABLES---

// namespace giraffe;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //creating variables
//         string characterName = "John";
//         int characterAge = 35;

//         //or can declare variable first 
//         // int characterAge;
//         // characterAge = 35;

//         Console.WriteLine("There once was a man named " + characterName);
//         Console.WriteLine("He was " + characterAge + " years old");

//         //updating value halfway through
//         characterName = "Mike";

//         Console.WriteLine("He really liked the name " + characterName);
//         Console.WriteLine("But didn't like being " + characterAge);

//         Console.ReadLine();

//     }
// }


//--- DATA TYPES ---

// namespace giraffe;
// class Program
// {
//     static void Main(string[] args)
//     {
//         string phrase = "Giraffe Academy";
//         //for characters, can only use single character
//         char grade = 'A';
//         int age = 30; //can be whole or negative numbers, as well as decimals
//         float, double, decimal //least accurate to most accurate with decimals
//         double gpa = 3.2;
//          // boolean => [true or false value]
//         bool isMale = true; 

//         Console.ReadLine();
//     }
// }


// ---STRINGS---

// \n => special character that specifies new line
// Console.WriteLine("Giraffe\nAcademy");

// store string in a variable
// string phrase = "Giraffe Academy";
//Console.WriteLine(phrase);

// concatination => "" + ""

// phrase.Length (will tell how many characters in string of phrase above)
// methods will be discussed later => modify or performs task for string
// Contains method to check for parameters (true or false value)
// phrase[] => to find character at certain index
// .Index.Of() => at what index position parameter starts at
// if only putting a character in parameters, just use '' => ie 'f'
// if prints out -1 => character does not exist inside of string

// .Substring() => allows you to grab a part of the string
// give substring one parameter => index 
// give two parameters => (8, 3 ) =>starting index and how many characters

// ---Numbers---
// C# does distinguish between whole numbers and decimals
// math operations: +, -, /, *, %  (modulus => gives remainder of division operation)
// order of operations

// Math. => math operations
// Math.Abs() => absolute value
// Math.Pow(,) => first parameter raised to the second parameter
// Math.Sqrt() => square root
// Math.Max(,) => tells which number is bigger
// Math.Min(,) => which number is smaller
// Math.Round() => rounds numbers


//---GETTING USER INPUT---
// allowing user to type in value, then using value to do something

// namespace giraffe;
// class Program
// {
//     static void Main(string[] args)
//     {
//     //    use Write instead of WriteLine to go onto a new line. 
//         Console.Write("Enter your name: ");
//         string name = Console.ReadLine();
//         Console.Write("Enter your age: ");
//         string age = Console.ReadLine();
//         Console.WriteLine("Hello " + name + " you are " + age);


//         // ReadLine essentially pauses and waits for user input
//         Console.ReadLine();
//     }
// }

// ---BUILDING A CALCULATOR---

// using System.Data.SqlTypes;

// namespace giraffe;
// class Program 
// {
//     static void Main(string[] args)
//     {
//         // convert string into numbers

//         // int num = Convert.ToInt32("45");
//         // Console.WriteLine(num + 6);

//         // if wanting to use decimals, use double instead of int for variable ***

//         Console.Write("Enter a number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter another number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine(num1 + num2);

//         Console.ReadLine();
//     }
// }

// ---BUILDING MAD LIBS GAME---

// namespace giraffe;

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string color, pluralNoun, celebrity;

//             Console.Write("Enter a color: ");
//             color = Console.ReadLine();

//             Console.Write("Enter a plural noun: ");
//             pluralNoun = Console.ReadLine();

//             Console.Write("Enter a celebrity: ");
//             celebrity = Console.ReadLine();

//             Console.WriteLine("Roses are " + color);
//             Console.WriteLine(pluralNoun + " are blue");
//             Console.WriteLine("I love " + celebrity);

//             Console.ReadLine();
//         }
//     }


// ----Arrays----

// namespace giraffe;

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // have to tell c# we're making an array instead of a variable by using []. Prior to the [], we need to specify what data type it is going to include

//             int [] luckyNumbers = { 4, 8, 15, 16, 23, 42};

//             // luckyNumbers[1] = 900;
//             string[] friends = new string[5];
//             //                             ^this means the array can only hold 10 items
//             friends[0] = "Jim";
//             friends[1] = "Kelly";
//             // ^ manually setting the value of each index
            

//             Console.WriteLine( luckyNumbers[1] );

//             Console.ReadLine();
//         }
//     }

// ---Methods---

// namespace giraffe;

//     class Program
//     {
//         // static void Main is a method
//         static void Main(string[] args) 
//         {
//             SayHi("Mike", 33);
//             SayHi("John", 56);
//             SayHi("Tom", 12);
//             Console.ReadLine();
//         }
//         // come outside of the static void method brackets for new method. void doesn't return any information
//         // naming convention for methods is Capitals
//         static void SayHi(string name, int age)
//         {
//             Console.WriteLine("Hello " + name + " you are " + age);
//             // line of code wasn't executed because it wasn't ran. Only the code inside the main method gets ran. You can call the method though in Main.
//         }
//     }


// ----RETURN STATEMENTS----

// namespace giraffe;
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int cubedNumber = cube(5);
//             // Console.WriteLine(cubedNumber);
//            Console.WriteLine(cube(5));

//             Console.ReadLine();
//         }

//         // want to cube a number and return it
//         // create method outside of Main, and then call it in Main => make sure to write line to print it out
//         static int cube(int num)
//         {
//             int result = num * num * num;
//             return result;
//         }

//     }

// ----IF STATEMENTS----

// ** if statements are typically used within the Main method (or any other method) because they need to be executed as part of the program's logic

// && (and operator) is the same in C# as it is in JavaScript
// || (or operator) same as well
// else if (){} => check another condition after "if" before just "else"
// ! (negation operator) => negates the condition

// namespace giraffe;

// class Program
// {
//     static void Main()
//     {
//         int number = 10;

//         if (number > 5)
//         {
//             Console.WriteLine("Number is greater than 5");
//         }
//     }
// }

// namespace giraffe;

// class Program
// {
//     static void CheckNumber(int number)
//     {
//         if (number > 5)
//         {
//             Console.WriteLine("Number is greater than 5");
//         }
//         else
//         {
//             Console.WriteLine("Number is 5 or less");
//         }
//     }

//     static void Main()
//     {
//         CheckNumber(10); // Calling the method from Main
//     }
// }

// // ----IF STATEMENTS => Comparisons----

// // max method => tells which number is bigger
// // == comparing the value
// // != not equal to
// static int GetMax(int num1, int num2)
// {
//     int result;
//     if (num1 > num2) {
//         result = num1;
//     }
//     else {
//         result = num2;
//     }

//     return result;
// }

// ---BUILDING A BETTER CALCULATOR---

// **building a four function calculator

// namespace giraffe;

//     class Program 
//     {
//         static void Main()
//         {
//             Console.Write("Enter a number: ");
//             double num1 = Convert.ToDouble(Console.ReadLine());

//             Console.Write("Enter operator: ");
//             string op = Console.ReadLine();

//             Console.Write("Enter a number: ");
//             double num2 = Convert.ToDouble(Console.ReadLine());

//             if(op == "+"){
//                 Console.WriteLine(num1 + num2);
//             } else if (op == "-"){
//                 Console.WriteLine(num1 - num2);
//             }
//             else if (op == "/"){
//                 Console.WriteLine(num1 / num2);
//             }
//             else if (op == "*"){
//                 Console.WriteLine(num1 * num2);
//             }
//             else {
//                 Console.WriteLine("Invalid operator");
//             }

//             Console.ReadLine();
//         }
//     }

// ---SWITCH STATEMENTS---


// check if statements efficiently => less messy


namespace giraffe;

class Program{
    static void Main(string[] args)
    {

        Console.WriteLine(GetDay(80));
        Console.ReadLine();
    }
    static string GetDay(int dayNum){
        string dayName;
        
        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            default: //if none of the cases are met
                dayName = "Invalid day number";
                break;
            
                
        }

        return dayName;
    }
}