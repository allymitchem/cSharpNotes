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

namespace giraffe;
class Program
{
    static void Main(string[] args)
    {
        string phrase = "Giraffe Academy";
        //for characters, can only use single character
        char grade = 'A';
        int age = 30; //can be whole or negative numbers, as well as decimals
        float, double, decimal //least accurate to most accurate with decimals
        double gpa = 3.2;
         // boolean => [true or false value]
        bool isMale = true; 
        
        Console.ReadLine();
    }
}


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


