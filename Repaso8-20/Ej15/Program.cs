using Repaso8_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            string clave = "enrique";
            bool claveCorrecta = false;
            string ingreso = "";


            do
            {
                
                     ingreso = Validaciones.pedirTexto("usuario");
                                         if (intentos == 2)
                                        {
                                            Console.WriteLine("Usuario Bloqueado, superaste intentos  posibles");
                                            break;
                                        }
                                        if (String.Compare(clave, ingreso) == 0)
                                        {
                                            Console.WriteLine("Bienvenido *{0}", clave);
                                            claveCorrecta = true;
                                        }
                    
                                        else
                                        {
                                            Console.WriteLine("Acceso Denegado, La contraseña no es correct.");
                                            intentos++;
                                        }

                
            } while (!claveCorrecta || intentos < 2);
        }
        
    }
}


        
    

