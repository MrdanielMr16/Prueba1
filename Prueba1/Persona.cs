﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public class Persona
    {
        String Cedula;
        String Nombre;
        int Edad;
        int Fecha_Nacimiento;
        public Persona(String Ce, String Nom, int A)
        {
            Nombre = Nom;
            Cedula = Ce;
            Fecha_Nacimiento = A;
        }
    }
}