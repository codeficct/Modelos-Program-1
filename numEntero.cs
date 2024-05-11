using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos_Program_1
{
    class numEntero
    {
        // Propiedades
        private int number;
        
        // Constructor
        public numEntero()
        {
            number = 0;
        }

        // Metodos
        public void cargar(int date)
        {
            number = date;
        }
        public int descargar()
        {
            return number;
        }
    }
}
