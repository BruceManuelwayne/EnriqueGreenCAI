using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
          
            int t;
            int sum = 0;
            int r; 
            
            
            Console.WriteLine("Ingrese un numero: ");

            var numeroComoString = Console.ReadLine();

            //validacion
            if (int.TryParse(numeroComoString, out numeroIngresado))
            {
                Console.WriteLine($"Numero ingresado es : {numeroIngresado}");
                for (t = numeroIngresado; t != 0; t = t / 10)
                {
                    r = t % 10;
                    sum = sum * 10 + r;
                }
                Console.Write("El numero en orden inverso es : {0} \n", sum);

            }
            else
            {
                Console.WriteLine("No es un numero"); 
            }

            


        }
    }
}
