using Repaso8_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            bool valida = true;

            do
            {
                if(!char.TryParse(Validaciones.pedirTexto("una Tecla").ToLower(), out letra))
                {
                    Console.WriteLine("Error, debe ingresar solo una tecla. Intente de nuevo: ");
                }

            } while (!valida);

            if ("aeiou".Contains(letra))
            {
                Console.WriteLine(letra + " es una vocal");
            }
            else if ("bcdfghjklmnpqrstvwxyz".Contains(letra)) 
            {
                Console.WriteLine(letra + " es una consonante"); 
            }
            else if ("1234567890".Contains(letra)){
                Console.WriteLine(letra + " es un numero"); 
            }
            else
            {
                Console.WriteLine(letra + " no es una vocal, consonante o numero"); 
            }
        }
    }
}
