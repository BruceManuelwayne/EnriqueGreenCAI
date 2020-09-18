using Repaso8_20;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i; 

            // falta validacion 
            Console.Write("Ingrese el numero para calcular tabla de multiplicacion. ");

            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            for (i= 1;i<=10;i++)
            {
                Console.Write("{0} X {1} = {2}\n", numero, i, numero * i); 
            }

           /* int numero;
            const int maximo = 100;
            const int minimo = 1; 

            
            numero = Validaciones.pedirNumero(" un numero para mostrar tabla de multiplacacion ",minimo, maximo);
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ",numero,i,numero*i); 
            }*/
        }
    }
}
