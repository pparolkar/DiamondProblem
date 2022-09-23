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

            Console.Write("\nPress any key to close the console window.");
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

                int inputCharacter = Convert.ToInt32(inputChar); //Getting ascii value of user input
                
                if(IsValidAlphabet(inputCharacter)) //Validate user input
                {
                    int rowCount = inputCharacter - 64; //Getting number of rows to print diamond
                    int alphabetAscii = 64;
                    CreateUpperTriangle(rowCount, alphabetAscii, sb);
                    CreateLowerTriangle(rowCount, alphabetAscii, sb);
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

        /// <summary>
        /// Description: Method to create top triangle of the diamond
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="alphabetAscii"></param>
        /// <param name="sb"></param>
        public static void CreateUpperTriangle(int rowCount, int alphabetAscii, StringBuilder sb)
        {
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
        
        }

        /// <summary>
        /// Description: Method to create lower triangle of the diamond
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="alphabetAscii"></param>
        /// <param name="sb"></param>
        public static void CreateLowerTriangle(int rowCount, int alphabetAscii, StringBuilder sb)
        {
            int i, j, k;
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

        /// <summary>
        /// Desciption: Method to validate user input
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <returns></returns>
        public static bool IsValidAlphabet(int inputCharacter)
        {
            bool isValid = true;
            //Used ascii values from A to Z for printing diamond, Ascii value of A=65 and Z=90
            if (!(inputCharacter >= 65 && inputCharacter <= 90))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
