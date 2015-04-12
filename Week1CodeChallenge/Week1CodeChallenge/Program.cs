using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            
           
        }
        //declare function to Fizz or Buzz or FizzBuzz at appropriate times
        public static string FizzBuzz(int number)
        {
            //test to see if number is negative
            if (number < 0)
            {
                return string.Empty;
                
            }
            //if the number is 0, then return the number converted to a string
            if (number == 0)
            {
                return number.ToString();
            }
            //if the number is divisble by 5 and 3 then return FizzBuzz
            if (number % 5 == 0 & number % 3 == 0)
            {
                return "FizzBuzz"; 
            }
            //if the number is divisble by 3 then return Buzz
            if (number % 3 == 0)
            {
                return "Buzz";
            }
            //if the number is divisible by 5 then return Fizz
            if (number % 5 == 0)
            {
                return "Fizz";
            }
            //else return the number converted to string
            else
            {
                return number.ToString();
            }
            
        }
        public static string Yodaizer(string text)
        {
            //declare a string array called sentence
            //and populate that array using the text.Split() method / splitting at each space
            string[] sentence = text.Split(' ');
            
            //concatenate all of the strings in the array, adding a space between each and return that string
            return string.Join(" ", sentence.Reverse());
           
        }

        //declare function to track various text statistics
        public static void TextStats(string input)
        {
            //declare all counter variables
            int characterCount = input.Length;
            int numberOfWords = 1;
            int numberOfVowels = 0;
            int numberOfConsonants = 0;
            int numberOfSpecialCharacters = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //is the character at string index i a vowel
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'u' || input[i] == 'o' ||
                    input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'U' || input[i] == 'O')
                {
                    numberOfVowels++;
                }
                //is the character at string index i a consonant
                else if (input[i] == 'b' || input[i] == 'c' || input[i] == 'd' || input[i] == 'f' || input[i] == 'g' || input[i] == 'h' || input[i] == 'j' ||
                    input[i] == 'k' || input[i] == 'l' || input[i] == 'm' || input[i] == 'n' || input[i] == 'p' || input[i] == 'q' || input[i] == 'r' ||
                    input[i] == 's' || input[i] == 't' || input[i] == 'v' || input[i] == 'w' || input[i] == 'x' || input[i] == 'y' || input[i] == 'z' ||
                    input[i] == 'B' || input[i] == 'C' || input[i] == 'D' || input[i] == 'F' || input[i] == 'G' || input[i] == 'H' || input[i] == 'J' ||
                    input[i] == 'K' || input[i] == 'L' || input[i] == 'M' || input[i] == 'N' || input[i] == 'P' || input[i] == 'Q' || input[i] == 'R' ||
                    input[i] == 'S' || input[i] == 'T' || input[i] == 'V' || input[i] == 'W' || input[i] == 'X' || input[i] == 'Y' || input[i] == 'Z')
                {
                    numberOfConsonants++;
                }
                //is the character at string index i a space
                else if (input[i] == ' ')
                {
                    numberOfWords++;
                }
                //the character at index i must be a special character
                else
	            {
                    numberOfSpecialCharacters++;
	            }


            }
            //print out all results after exiting loop
            Console.WriteLine("There are " + numberOfWords + " words in this sentence.");
            Console.WriteLine("There are " + characterCount + " characters in this sentence.");
            Console.WriteLine("There are " + numberOfVowels + " vowels in this sentence.");
            Console.WriteLine("There are " + numberOfConsonants + " consonants in this sentence.");
            Console.WriteLine("There are " + numberOfSpecialCharacters + " special characters in this sentence.");

        }
        public static bool IsPrime(int number)
        {
            //is the number less than 3?
            if (number < 3)  
            {
                if (number == 2)
                {
                    //2 is a prime number
                    return true;
                }
                    //consider 1 a prime number
                else if(number == 1)
                {
                    return true;
                }
                else
                {
                    //every other number that is less than 3 is not a prime number because it is 0 or negative
                    return false;
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    //even numbers cannot be prime(except for 2)
                    return false;
                }
                    //if we reach this point then the number must be odd
                else
                {
                    //declare divider variable to used in loop
                    int i;

                    //begin testing at 3, continue testing until the number modulo div is not equal to 0, increment by 2
                    for (i = 3; number % i != 0; i += 2)
                        ;

                        if (i == number)
                        {
                            // if theNum and div are equal it must be a prime
                            return true;
                        }
                        else
                        {
                            // some other number divided evenly into theNum, and it is not
                            // itself, so it is not a prime
                            return false;
                        }

                    
                }
            }
            

        }
        public static string DashInsert(int number)
        {
            //declare ints to be tested
            int num1;
            int num2;
            //convert the number entered to a string which can be looped through
            //store in variable numberString
            string numberString = number.ToString();
            //declare new StringBuilder
            System.Text.StringBuilder returnString = new System.Text.StringBuilder();
  
            //begin for loop to iterate through the string
            for (int i = 0; i < numberString.Length - 1; i++)
            {
                //convert each char into a string which can then be parsed
                string tempString = numberString[i].ToString();
                
                //store int in variable num 1
                num1 = int.Parse(tempString);
                //store int for num2
                string tempString2 = numberString[i + 1].ToString();
                num2 = int.Parse(tempString2);
                
                //if num1 is an even number or 0, simply add it to the return string
                if (num1 == 0 || num1 % 2 == 0)
                {
                    returnString.Append(num1.ToString());
                }
                
                //else num1 must be odd
                else
                {
                    //if num1 and num2 are odd, then add a dash after num1
                    if (num1 % 2 != 0 & num2 % 2 != 0)
                    {
                        returnString.Append(num1.ToString());
                        returnString.Append("-");
                       
                    }
                    else
                    {
                        //if num1 and num2 are not both odd, still add num1 to the end of the returnstring
                        returnString.Append(num1.ToString());
                    }
                    
                }
                
            }
            //add the final character to the string.  This will always just be the character itself
            //so I dont need to check for even or odd
            string finalChar = numberString[numberString.Length - 1].ToString();
            returnString.Append(finalChar.ToString());
            return returnString.ToString();
        }
    }
}
