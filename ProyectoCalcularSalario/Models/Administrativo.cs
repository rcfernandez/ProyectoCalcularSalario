using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalcularSalario.Models
{
    public class Administrativo : Empleado
    {
        private double SueldoFijo = 500;
        
        public override double calcularSalario()
        {
            return SueldoFijo;
        }
    }

}