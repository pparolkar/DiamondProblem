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
             /// <param name="args"></param>
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

            var str = CreateDiamond(inputString);
            Console.Write(str);

            Console.Write("Press any key to close the console this window.");
            Console.ReadKey();

            
        }

        /// <summary>
        /// Description: Method to create diamond
        /// </summary>
        public static string CreateDiamond(string inputString)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
               
                char inputChar = Convert.ToChar(inputString);

                int inputCharacter = Convert.ToInt32(inputChar);

                if (inputCharacter >= 65 && inputCharacter <= 90)
                {
                    int rowCount = inputCharacter - 64;
                    int alphabetAscii = 64;

                    int i, j, k;
                    for (i = 1; i <= rowCount; i++)
                    {
                        for (j = 1; j <= rowCount - i; j++)
                        {                            
                            sb.Append(" ");
                        }
                        for (k = 1; k <= i * 2 - 1; k++)
                        {
                            if (k == 1 || k == (i * 2 - 1))
                            {                                
                                char alphabet = (char)(alphabetAscii + i);
                                sb.Append(alphabet.ToString());
                            }
                            else
                            {
                                sb.Append(" ");
                            }
                        }
                        
                        sb.Append("\n");
                    }

                    for (i = rowCount - 1; i > 0; i--)
                    {
                        for (j = 1; j <= rowCount - i; j++)
                        {                           
                            sb.Append(" ");
                        }
                        for (k = 1; k <= i * 2 - 1; k++)
                        {
                            if (k == 1 || k == (i * 2 - 1))
                            {                                
                                char alphabet = (char)(alphabetAscii + i);
                                sb.Append(alphabet.ToString());
                            }
                            else
                            {
                                sb.Append(" ");
                            }
                        }
                        
                        sb.Append("\n");
                    }                   
                    
                }
                else
                {                    
                    sb.Append("Please enter a character between A to Z, i.e. alphabates in capital letter.");
                }                
                
            }
            catch (Exception ex)
            {               
                sb.Append("Something went wrong!! " + ex.Message);
            }
            
            return sb.ToString();
        }

        
    }
}
