using Repaso8_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejRepaso9
{
    class Program
    {
       
    static void Main(string[] args)
        {
            string nombreUsuario = "Enrique";
            string nombre = Validaciones.pedirTexto("Nombre de usuario:");
            string nombreU = EditString.UppercaseFirst(nombre);
            
        
            
            if (string.Compare(nombreU, nombreUsuario) == 0)
                Console.WriteLine("hola {0}!", nombreU);
            else
            {
                Console.WriteLine("no te conozco.");
            }


           }

        public static class EditString
        {
            public static string UppercaseFirst(string s)
            {
                // Check for empty string.
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }
                // Return char and concat substring.
                return char.ToUpper(s[0]) + s.Substring(1);
            }
        }
    }
}
    
           

            
