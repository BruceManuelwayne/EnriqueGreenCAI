using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reg = "301";
            int registro = 301;
            string nuevoReg="";

            if (reg.Substring(0, 1) == "0")
            {
                registro = registro + 100;
                Console.WriteLine(registro);
            }


            for (int i = 1; i <= registro; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    nuevoReg = i + " - FOOBAR";
                    Console.WriteLine(nuevoReg);
                }
                else if (i % 3 == 0)
                {
                    nuevoReg = i + " - FOO";
                    Console.WriteLine(nuevoReg);
                }
                else if (i % 5 == 0)
                {
                    nuevoReg = i + " - BAR";
                    Console.WriteLine(nuevoReg);
                }
                else
                    Console.WriteLine(i);
            }

        }
    }
}
        


    

