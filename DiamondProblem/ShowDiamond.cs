using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    public class ShowDiamond
    {
        #region Global Variables
        private static int rowCount, alphabetAscii, firstLetterAscii = 65, lastLetterAscii = 90;
        private static StringBuilder sb;
        #endregion

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

            var str = CreateDiamond(inputString);
            Console.Write(str);

            Console.Write("\nPress any key to close the console window.");
            Console.ReadKey();            
        }

        /// <summary>
        /// Description: Method to create diamond
        /// </summary>
        /// <param name="inputString">input string</param>
        /// <returns></returns>
        public static string CreateDiamond(string inputString)
        {
            sb = new StringBuilder();

            try
            {               
                char inputChar = Convert.ToChar(inputString);

                int inputCharacter = Convert.ToInt32(inputChar); //Getting ascii value from user input
                
                if(IsValidAlphabet(inputCharacter)) //Validate user input
                {
                    rowCount = inputCharacter - (firstLetterAscii - 1); //Getting number of rows to print diamond
                    alphabetAscii = (firstLetterAscii - 1);
                    for (int rowNumber = 1; rowNumber <= rowCount; rowNumber++)
                    {
                        CreateRow(rowNumber);
                    }    
                    for (int rowNumber = rowCount - 1; rowNumber > 0; rowNumber--)
                    {
                        CreateRow(rowNumber);
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

        /// <summary>
        /// Description: Method to create rows of diamond
        /// </summary>
        /// <param name="rowNumber"></param>
        private static void CreateRow(int rowNumber)
        {
            string space = "";

            string tempStrOfSpacesBeforeLetters = space.PadLeft(rowCount - rowNumber);
            sb.Append(tempStrOfSpacesBeforeLetters);
            char alphabet = (char)(alphabetAscii + rowNumber);
            sb.Append(alphabet.ToString());

            if (rowNumber != 1)
            {
                string tempStrOfSpacesBetweenCharacters = space.PadLeft(((rowNumber * 2) - 3));
                sb.Append(tempStrOfSpacesBetweenCharacters);
                sb.Append(alphabet.ToString());
            }
            sb.Append("\n");

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
            if (!(inputCharacter >= firstLetterAscii && inputCharacter <= lastLetterAscii))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
