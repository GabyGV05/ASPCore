using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {

        


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Index()
        {
            Array array;
            List<AlumnoModel> alumnos = new List<AlumnoModel>();
            alumnos.Add(new AlumnoModel
            {
                NumCont = 17030086,
                Nombre="Gabriela",
                Apellido_paterno="Gramillo",
                Apellido_materno="Vaquera",
                Codigo_especialidad=1

            });

            alumnos.Add(new AlumnoModel
            {
                NumCont = 17030083,
                Nombre = "Esperanza Jaqueline",
                Apellido_paterno = "Fernandez",
                Apellido_materno = "Maldonado",
                Codigo_especialidad = 1

            });

            alumnos.Add(new AlumnoModel
            {
                NumCont = 17030084,
                Nombre = "Karla Nohemi",
                Apellido_paterno = "García ",
                Apellido_materno = "Reza",
                Codigo_especialidad = 1

            });
            array = alumnos.ToArray();
            ViewBag.alumnos = array;

            return View();

        }
    }
}
