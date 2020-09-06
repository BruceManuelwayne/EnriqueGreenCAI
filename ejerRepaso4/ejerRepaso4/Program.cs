using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerRepaso4
{
    class Program
    {
        private bool ValidarPalabra(string NroRegistro)
        {
            bool flag = false;

            if (String.IsNullOrEmpty(NroRegistro) || String.IsNullOrWhiteSpace(NroRegistro))
            {
                Console.WriteLine("Debe ingresar una palabra para validar");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        static class Invertir
        {
            public static string ReverseString(string myStr)
            {
                char[] myArr = myStr.ToCharArray();
                Array.Reverse(myArr);
                return new string(myArr);
            }
        }

        static class Ordenar
        {
            public static string OrdenarString(string myStr)
            {
                char[] myArr = myStr.ToCharArray();
                Array.Sort(myArr);
                return new string(myArr);
            }
        }

        public void main()
        {
            string StrRegistro;
            string StrRegistro2;
            bool flag;

            do
            {
                Console.WriteLine("Por favor ingrese la primer palabra: ");
                StrRegistro = Console.ReadLine();

                flag = ValidarPalabra(StrRegistro);

            } while (flag == false);

            do
            {
                Console.WriteLine("Por favor ingrese la segunda palabra: ");
                StrRegistro2 = Console.ReadLine();

                flag = ValidarPalabra(StrRegistro2);

            } while (flag == false);

            Console.WriteLine("el valor de la primer palabra es: {0}", StrRegistro);
            Console.WriteLine("el valor de la segunda palabra es: {0}", StrRegistro2);

            string StrOrdenado = Ordenar.OrdenarString(StrRegistro);
            string StrOrdenado2 = Ordenar.OrdenarString(StrRegistro2);
            Console.WriteLine("La primer palabra ordenada es: {0}", StrOrdenado);
            Console.WriteLine("La segunda palabra ordenada es: {0}", StrOrdenado2);

            if (StrOrdenado == StrOrdenado2)
            {
                Console.WriteLine("La palabra {0} es anagrama de la palabra {1}: ", StrRegistro, StrRegistro2);
            }

            else
            {
                Console.WriteLine("La palabra {0} no es anagrama de la palabra {1}: ", StrRegistro, StrRegistro2);
            }

        }
    }
}

