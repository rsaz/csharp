/* Project: Variables
 * Variables are used to store information to be referenced and manipulated in a computer
 * program. They also provide a way of labeling data with a descriptive name, so our
 * programs can be understood more clearly by the reader and ourselves. It is helpful to
 * think of variables as containers that hold information. Their sole purpose is to label
 * and store data in memory. This data can then be used throughout your program.
 * 
 * Author: Richard Zampieri
 * Email: br.developer@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // To declare a variable you need 4 elements
            // 1 - Data type
            // 2 - Name of the variable
            // 3 - Optional assignment operator
            // 4 - Optional value

            // (int) data type - (variable) number
            int number;

            // (int) data type - (variable) anotherNumber - (=) assignment operator - (5) value
            int anotherNumber = 5;

            // More commonly used simple data types in c#
            // int, float, double, decimal, bool, string, char

            int myInteger = 1;
            float myFloat = 1.0f;
            double myDouble = 1.0;
            decimal myDecimal = 1.0m;
            bool myBool = true; // can be true or false
            string myString = "My text"; // value has to be between double quotes 
            char myChar = 'a'; // value has to be between single quotes

            // Complete list of the data type available here 
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/built-in-types-table

            // variables name convetion
            // All variable names must begin with a letter of the alphabet or an underscore(_ ). 
            // After the first initial letter, variable names can also contain letters and numbers.
            // No spaces or special characters, however, are allowed.
            // Uppercase characters are distinct from lowercase characters.
            // Using all uppercase letters is used primarily to identify constant variables.
            // You cannot use a C# keyword (reserved word) as a variable name.
            // variables names start with lower case
            int heatlh;
            // Composed variable names have the subsequent word always in uppercase 
            int healthPlayer;
        }
    }
}
