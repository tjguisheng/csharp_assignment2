using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Input a integer to check sum of digits: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"sum of digit(s) is {SumDigi(num)}");

            //Task2
            //OddNum();

            //Task3
            Console.WriteLine("Input a string to reverse: ");
            string text = Console.ReadLine();
            Console.WriteLine($"in reverse are: {RevStr(text)}");

            //Task4
            Console.WriteLine("Input a string to count vowel or consonant: ");
            string text2 = Console.ReadLine();
            VowelConsonChecker(text2);

            //Task5
            Console.WriteLine("Please input a grade:\n Grade \t Description \n E \t Excellent \n V \t Very Good \n G \t Good \n A \t Average \n F \t Fail");
            char grade = Console.ReadLine()[0];
            gradeEquivalent(grade);
        }

        public static int SumDigi(int num)
        {
            int sum = 0;

            do
            {
                sum += num % 10;
                num /= 10;
            } while (num >0);

            return sum;
        }

        public static void OddNum()
        {
            for(int i=1; i<=99;i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public static string RevStr(string str)
        {
            
            int len = str.Length;
            char[] rev = new char[len];
            for (int i=0; i<len; i++)
            {
                rev[i] = str[len - i-1];
            }
            string result = new string(rev);
            return result;
        }

        public static void VowelConsonChecker(string text)
        {
            // vowel char list
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            // consonant char list
            char[] consonants = new[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            string lowText = text.ToLower();    // change into lower case

            int vowCount = 0, consonCount = 0;

            foreach(char letter in lowText)   //check letters in text
            {
                if(vowels.Contains(letter)) //count vowel 
                {
                    vowCount++;
                }
                
                if(consonants.Contains(letter)) //count consonant
                {
                    consonCount++;
                }
            }

            Console.WriteLine($"The total number of vowel in the string is : {vowCount} \n The total number of consonant in the string is : {consonCount}");
        }

        public static void gradeEquivalent(char grade)
        {
            grade = char.ToLower(grade);
            switch(grade)
            {
                case 'a':
                    Console.WriteLine("You have chosen: Average");
                    break;
                case 'e':
                    Console.WriteLine("You have chosen: Excellent");
                    break;
                case 'f':
                    Console.WriteLine("You have chosen: Fail");
                    break;
                case 'g':
                    Console.WriteLine("You have chosen: Good");
                    break;
                case 'v':
                    Console.WriteLine("You have chosen: Very Good");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select from E, V, G, A, F");
                    break;
            }
        }
    }
}
