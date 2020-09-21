using Repaso8_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = Validaciones.pedirNumero("Numero", 0, 9999999);
            Console.WriteLine("Numero Ingresado: {0} tiene {1} numeros.", numero, numero.ToString().Length); 
        }
    }
}
