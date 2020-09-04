using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una aplicación que indique, cuando el usuario ingresa una palabra, 
//si ésta es un palíndromo. 
//Nota: Palíndromo son palabras que al derecho y al revés se leen igual, como "ananá"
//public static bool IsPalindrome(string str)  
//{
//  return str.SequenceEqual(str.Reverse());
//}
namespace ejRepaso3
{
    class Program
    {
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
        public static void Main()
        {
            Console.Write("\n\n Recursion : Check whether a string ia Palindrome or not :\n");
            Console.Write("---------------------------------------------------------------\n");
            string str1;
            bool tf;

            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine(" The string is Palindrome.\n");
            }
            else
            {
                Console.WriteLine(" The string is not a Palindrome.\n");
            }
        }
    }
}
