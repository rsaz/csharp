/* Project: Console Input and Outup
 * In a console application input can be represented for the command <Console.ReadLine()> or
 * <Console.ReadLine()>, or a file to be read, etc.
 * Output can be represented by <Console.WriteLine()> or <Console.Write()>
 * Author: Richard Zampieri
 * Email: br.developer@gmail.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console ReadLine

            // User input
            /* Console.ReadLine() is a function that receive an input from the console
             * and return a string
             * The return of this function must be store in a variable
             */
            string userInput = Console.ReadLine();
            /* The line of code above allows storing the data entry from the user to be stored in a
             * variable called userInput
             */

            /* If the user decides to store the information as another data type such as numbers,
             * the information must be converted using the following command
             */
            
            // int variable - int.Parse is responsible to convert the string entry to integer
            // This pattern can be replicated to other data types
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            /* Important to note with this approach is that, when you convert the user data entry
             * you need to make sure that the user data entry is typed accordingly with the data
             * type requested. For instance, you can't type a text when an integer data is requested
             */

            // Console WriteLine

            // Application Output
            /* Console.WriteLine method provides a mechanism for the console to interact with the user
             * It prints information in the windows console
             */

            // Any information can be printed in the console
            Console.WriteLine("Hello there!");
            Console.WriteLine(2019);
            Console.WriteLine(false);
            Console.WriteLine(true);
            Console.WriteLine(2.54f);

            // Variables can be printed
            string name = "Your name";
            Console.WriteLine(name);

            // Information can be concatenated in the Console.WriteLine method
            Console.WriteLine("My age is " + 5);
            Console.WriteLine("Hi, I am " + name + ", I am deloper!");

            // Interpolation
            // Simplify the text concatenation with variables using curly braces
            Console.WriteLine($"Hi, I am {name}, I am developer!");
            Console.WriteLine($"Hi, I am {name}, I am developer!");
        }
    }
}
