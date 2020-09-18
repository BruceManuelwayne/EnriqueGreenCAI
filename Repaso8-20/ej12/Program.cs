using Repaso8_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    class Program
    {
            //no es exacto porque los dias en los meses varian. Tambien leapyears
        static void Main(string[] args)
        {
            DateTime[] fechas = new DateTime[2];
            //TimeSpan span;
            int anios, meses, dias, mayor, menor;

            fechas[0] = Validaciones.pedirFecha("la primera fecha");
            fechas[1] = Validaciones.pedirFecha("la segunda fecha");

            if (fechas[0] > fechas[1])
            {
                mayor = 0;
                menor = 1;
            }
            else
            {
                mayor = 1;
                menor = 0;
            }
            //span = fechas[mayor].Subtract(fechas[menor]);
            anios = fechas[mayor].Year - fechas[menor].Year;
            meses = fechas[mayor].Month - fechas[menor].Month;
            dias = fechas[mayor].Day - fechas[menor].Day;

            if (meses < 0)
            {
                anios -= 1;
                meses += 12;
            }
            if (dias < 0)
            {
                meses -= 1;
                dias += DateTime.DaysInMonth(fechas[mayor].Year, fechas[mayor].Month);
            }

            Console.WriteLine("La diferencia entre {3} y {4} es de {0} años, {1} meses, {2} dias.", anios, meses, dias, fechas[menor].ToShortDateString(), fechas[mayor].ToShortDateString());

            /*int[] diasMes = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; 
            
            DateTime desdeFecha;
            DateTime aFecha;

            //public DateDifference(DateTime f1, DateTime f2); 

            int anio;
            int mes;
            int dia; 

            date1 = Validaciones.pedirFecha("fecha 1 dd/mm/yyyy");
            
            date2 = Validaciones.pedirFecha("fecha 2 dd/mm/yyyy");
            
            Console.WriteLine(date1.ToShortDateString());

            Console.WriteLine(date2.ToShortDateString());

            TimeSpan difference = date1.Subtract(date2);

            Console.WriteLine("Hay " + difference.Days + " dias de diferencia entre las dos fechas"); 

            //Console.WriteLine("Ingrese primera fecha dd/mm/yyyy");

            //date1 = Convert.ToDateTime(Console.ReadLine()).Date; */


        }
    }
}
