using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Persona
    {
        String Cedula;
        String Nombre;
        int Edad;
        int Fecha_Nacimiento;

        private int CalcularEdad()
        {
            Edad = Fecha_Nacimiento - 2021;
            return Edad;
        }
    }
}
