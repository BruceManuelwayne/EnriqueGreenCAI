using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        public static bool checkPrime(int num)
        {
            for (int n = 2; n < num; n++)
                if (num % n == 0)
                    return false;
            return true; 
        }
        static void Main(string[] args)
        {
            string reg = "701";
            int registro = 701;
            string nuevoReg;
            

            if (reg.Substring(0, 1) == "0")
            {
                registro = registro + 100;
                Console.WriteLine(registro);
            }


            for (int i = 1; i <= registro; i++)
            {

                if (checkPrime(i) && i % 3 == 0)
                {
                    nuevoReg = i + " - Es primo y divisible por 3";
                    Console.WriteLine(nuevoReg);
                }
                else if (i % 3 == 0)
                {
                    nuevoReg = i + " - divisible por 3";
                    Console.WriteLine(nuevoReg);
                }
                else if (checkPrime(i))
                {
                    nuevoReg = i + " - primo";
                    Console.WriteLine(nuevoReg);
                }
                else
                    Console.WriteLine(i);
            }

        }
    }
}
        
   

