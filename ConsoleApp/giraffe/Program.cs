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

namespace giraffe;
class Program
{
    static void Main(string[] args)
    {
        //creating variables
        string characterName = "John";
        int characterAge = 35;

        //or can declare variable first 
        // int characterAge;
        // characterAge = 35;

        Console.WriteLine("There once was a man named " + characterName);
        Console.WriteLine("He was " + characterAge + " years old");
        
        //updating value halfway through
        characterName = "Mike";

        Console.WriteLine("He really liked the name " + characterName);
        Console.WriteLine("But didn't like being " + characterAge);

        Console.ReadLine();

    }
}
