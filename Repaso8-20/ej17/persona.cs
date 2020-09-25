using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    public class persona
    {
        public string Nombre { get; set;  }

        public string Apellido { get; set;  }

        public Double Sueldo { get; set;  }

       
      
        

        public List<persona> allPersonas = new List<persona>(); 

        public persona(string nombre, string apellido, double sueldo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sueldo = sueldo; 

        }

        

    }
}
