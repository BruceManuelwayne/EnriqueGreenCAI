using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso6
{
    class Program
    {
        
        static class Validaciones
        {
            public static int pedirNumero(string mensaje, int minimo, int max)
            {
                int num = 0;
                do
                {
                    Console.WriteLine("Ingrese" + mensaje + ": ");
                    if (!(int.TryParse(Console.ReadLine(), out num)))
                    {
                        num = -1;
                        Console.WriteLine("Error, reingrese un valor numero.");
                    }
                    else if (num < minimo || num > max)
                    {
                        Console.WriteLine("Error. El numero debe esatr entre" + minimo + "y" + max);
                    }
                } while (num < minimo || num > max);
                return num;
            }
        }
        

        static void Main(string[] args)
        {

            int num1, num2; 

            num1 = Validaciones.pedirNumero("El primer numero", 0, 99999999);
            num2 = Validaciones.pedirNumero("El segundo numero", 0, 99999999);

            Console.WriteLine(("el resultado de (a+b)*(a-b) es: " + (num1 + num2) * (num1 - num2)));
        }
    }
}
