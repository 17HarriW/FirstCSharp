using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user how many lines printed
            Console.WriteLine("How many pizzas would you like?");
            int answer = int.Parse(Console.ReadLine());

            // Starts for i in range answer iterative loop
            for (int i = 0; i < answer; i++)     
            {
                // Prints each number pizza with pass number + 1
                Console.WriteLine("Eat pizza number " + (i+1));    
            }

            Console.ReadLine();
        }
    }
}
