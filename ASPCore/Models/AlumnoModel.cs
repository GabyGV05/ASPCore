using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class AlumnoModel
    {
        public int NumCont { get; set; }
        public string Nombre { get; set; }
        public string Apellido_paterno {get;set;}
        public string Apellido_materno { get; set; }
        public int Codigo_especialidad { get; set; }

    }
}
