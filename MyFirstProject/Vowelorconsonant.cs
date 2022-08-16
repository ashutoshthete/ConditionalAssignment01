using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAssignment01
{
    class Vowelorconsonant
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char i = char.Parse(Console.ReadLine());

            if((i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'y' || i == 'w')|| (i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U' || i == 'Y' || i == 'W'))
            {
                Console.WriteLine("Enterd charcter is "+i+" a vowel");
            }
            else
            {
                Console.WriteLine("Entered character is "+i+" a consonant");
            }
            


        }
    }
}
