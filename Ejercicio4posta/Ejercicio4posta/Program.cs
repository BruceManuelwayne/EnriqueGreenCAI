using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4posta
{
    class Program
    {


     

        
        static class Ordenar
        {
            public static string OrdenarString(string str1)
            {
                char[] array1 = str1.ToArray();
                Array.Sort(array1);
                return new string(array1);
            }
        }

        public static void Main(string[] args)
        {
            string string1;
            string string2;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese la primera palabra: ");
                string1 = Console.ReadLine();

                flag = ValidarPalabra(string1); //error

            }
            while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la primera palabra: ");
                string2 = Console.ReadLine();

                flag = new ValidarPalabra(string2); //error


            }
            while (flag == false);

            Console.WriteLine("el valor de la primera palabra es :{0}", string1);
            Console.WriteLine("El valor de la segunda palabra es :{0}", string2);

            string strOrdenado = Ordenar.OrdenarString(string1);
            string strOrdenado2 = Ordenar.OrdenarString(string2);

            Console.WriteLine("La primera palabra ordenada es:{0}", strOrdenado);
            Console.WriteLine("La segunda palabra ordenada es:{0}", strOrdenado2);

            if (strOrdenado == strOrdenado2)
            {
                Console.WriteLine("La palabra{0} es anagrama de la palabra{1}:", string1, string2);

            }

            else
            {
                Console.WriteLine("La palabra{0} no es anagrama de la palabra{1}:", string1, string2);
            }


        }
    }

}