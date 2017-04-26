using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoCalcularSalario.Models;

namespace ProyectoCalcularSalario.Controllers
{
    public class CalculadoraController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Programador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Programador(Programador P)
        {
            //Empleado E = new Empleado();
            //E.Nombre = P.Nombre;
            //E.Apellido = P.Apellido;
            //E.Sueldo = P.calcularSalario();

            //ViewBag.Nombre = P.Nombre;
            //ViewBag.Apellido = P.Apellido;

            Empleado e = new Programador();
            ViewBag.sueldo = e.calcularSalario ;

            return View("Resultado", P);
        }


        public ActionResult Administrativo()
        {
            return View();
        }
        /*
        public ActionResult Resultado(String nombre, String apellido, int cantidad_hora, int valor_hora)
        {
            Empleado prog = new Programador();
            prog.Nombre = nombre;
            prog.Apellido = apellido;
            prog.CantidadHoras = cantidad_hora;
            prog.calcularSalario();

            //prog.

            return View();
        }
         */
        public ActionResult Resultado(Empleado E)
        {

            return View(E);
        }
    }
}
