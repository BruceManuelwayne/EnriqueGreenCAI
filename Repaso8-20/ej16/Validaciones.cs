using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso8_20
{
    static class Validaciones
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
        public static string pedirTexto(string mensaje)
        {
            string text = "";

            do
            {
                Console.WriteLine("ingrese " + mensaje + ": ");
                text = Console.ReadLine();
                if (string.IsNullOrEmpty(text))
                    Console.WriteLine("Ingrese texto valido: ");

            } while (string.IsNullOrEmpty(text));
            return text;
        }

        public static string pedirContinuar()
        {
            string texto = "";
            bool estaOk = false;
            do
            {
                Console.Write("Desea probar otro ejercicio? 'S' para SI o 'N' para salir de la app.");
                texto = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty(texto))
                    Console.WriteLine("Por favor, ingrese un texto");
                if (string.Compare(texto, "S") == 0)
                    estaOk = true;
                if (string.Compare(texto, "N") == 0)
                    estaOk = true;
                if (!estaOk)
                    Console.WriteLine("Por favor, ingrese S o N");
            } while (!estaOk);
            return texto;
        }

        public static DateTime pedirFecha(string mensaje)
        {
            DateTime valor;
            bool ok = false;
            do
            {
                if(!DateTime.TryParse(Validaciones.pedirTexto(mensaje), out valor))
                {
                    Console.WriteLine("Error. Infresar una fecha: ");
                }
                else
                {
                    ok = true;
                }

            } while (!ok);
            return valor; 
        }

    }
}
