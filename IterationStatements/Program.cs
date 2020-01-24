using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE - Create a List called "numbers"
            var numbers = new List<int>();

            var myArray = new int[5]; //0,1,2,3,4

            for(int z = 0; z < myArray.Length; z++)
            {
                myArray[z] = z + 1;
            }

            Console.WriteLine(myArray[1]);

            //DONE - Create a variable of type int with an initializer of 0
            var i = 0;



            // Create a do-while loop
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }
            // While your variable is less than 100
            do
            {   //execute this scope at least once
                i++; // Increment your variable by 1
                numbers.Add(i); // Then add your variable to "numbers"

            } while (i < 100); // While your variable i is less than 100




            // Create a while loop
            // While your variable is less than 200
            while (i < 200) 
            {
                i++; // Increment your variable by 1
                numbers.Add(i); // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");



            // Create a foreach loop
            // Write each number in your list to the console
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of j to 199
            // in your conditional, as long as j is less than or equal to the length of "numbers"
            // and as long as j is greater than or equal to 0
            // Decrement j by 1

            for (int j = 199; j <= numbers.Count && j >= 0; j--)
            {
                Console.WriteLine(j); // Write to the console "numbers" at index j
            }

            Console.WriteLine(numbers.Count); 
        }
    }
}
