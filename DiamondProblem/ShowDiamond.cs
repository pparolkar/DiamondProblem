using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    public class ShowDiamond
    {
        

        /// <summary>
        /// Description: Program to print diamond from given alphabet character
        /// Assumption: Input characters should be captial alphabet character.
        /// </summary>
        /// <param name="args">args has all the values passed from the command line</param>
        static void Main(string[] args)
        {
            Console.Write("Enter any alphabet in capital letter to print diamond = ");

            string inputString;

            if (args.Length > 0)
            {
                inputString = args[0];
            }
            else
            {
                inputString = Console.ReadLine() ?? string.Empty;
            }

            IDiamond obj = new Diamond();

            var str = obj.CreateDiamond(inputString);
            Console.Write(str);

            Console.Write("\nPress any key to close the console window.");
            Console.ReadKey();            
        }

        
    }
}
