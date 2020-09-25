using Repaso8_20;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    class Program
    {
        static void Main(string[] args)
        {

            const int cantidad = 5;
            const double sueldoMax = 1000000;
            double[] sueldo = new double[cantidad];
            string[] nombre = new string[cantidad];
            double maximo = 0;
            int auxMax = 0; 

            for (int i = 0; i< cantidad; i++)
            {

                nombre[i] = Validaciones.pedirTexto("Nombre del empeado" + (i + 1));
                sueldo[i] = Validaciones.pedirDouble("sueldo ", 0, sueldoMax); 

                if (sueldo[i] > maximo)
                {
                    maximo = sueldo[i];
                    auxMax = i; 
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es -Nombre: {0}, Sueldo: {1}", nombre[auxMax], sueldo[auxMax]); 
        }
    }
}
