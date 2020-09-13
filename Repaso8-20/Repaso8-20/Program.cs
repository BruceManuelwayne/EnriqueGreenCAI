using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repaso8_20
{
    class Program
    {
        static class Validaciones {
            public static string pedirTexto(string mensaje)
            {
                string texto = "";
                do
                {
                    Console.Write("Ingrese " + mensaje + ": ");
                    texto = Console.ReadLine();
                    if (string.IsNullOrEmpty(texto))
                        Console.WriteLine("Por favor, ingrese un texto");
                } while (string.IsNullOrEmpty(texto));
                return texto;
            }
            public static DateTime PedirFecha(string mensaje)
            {
                DateTime valor;
                bool ok = false;
                do
                {
                    if (!DateTime.TryParse(Validaciones.pedirTexto(mensaje), out valor))
                    {
                        Console.WriteLine("Error. Ingresar una fecha: ");
                    }
                    else
                    {
                        ok = true;
                    }
                } while (!ok);

                return valor;
            }
        }
      
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            DateTime fecha;
            bool ok = false; 
           
            do
            {
                if (!DateTime.TryParse(Validaciones.pedirTexto("Fecha"), out fecha))
                {
                    Console.WriteLine("Error. INgresar una fecha: "); 
                }
                else if (hoy < fecha)
                {
                    Console.WriteLine("No puede ingresar una fecha mayor a hoy. Reingrese.");  
                }
                else
                {
                    ok = true;
                }


            } while (!ok);
            TimeSpan span = hoy.Subtract(fecha);

            Console.WriteLine("La diferencia de fechas es {0} dias.", + span.Days); 
        }
    }
}
