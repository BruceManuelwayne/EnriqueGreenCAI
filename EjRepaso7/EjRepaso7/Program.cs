using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso7
{
    class Program
    {
        public class Validacion
        {
            public static int pedirNumero(string mensaje, int minimo, int max)
            {
                int num = 0;
                do
                {
                    Console.Write("Ingrese " + mensaje + ": ");
                    if (!(int.TryParse(Console.ReadLine(), out num)))
                    {
                        num = -1;
                        Console.WriteLine("Error. Reingrese un valor numerico.");
                    }
                    else if (num < minimo || num > max)
                    {
                        Console.WriteLine("Error. El numero debe estar entre " + minimo + " y " + max);
                    }
                } while (num < minimo || num > max);
                return num;
            }
            static void Main(string[] args)
            {

            }
        }
    }
}
