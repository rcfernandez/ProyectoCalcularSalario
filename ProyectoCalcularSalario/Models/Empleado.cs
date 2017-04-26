using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalcularSalario.Models
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Sueldo { get; set; }
        /*
        public virtual double calcularSalario()
        {
            return Sueldo;
        }*/
    }

}