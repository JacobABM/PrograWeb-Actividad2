using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad2.Models
{
    public class PerfilViewModel
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Numero3 { get; set; }
        public double Resultado {get { return (Numero1 + Numero2 + Numero3) / 3;  } }

        public string Estado { get { return Resultado <= 100 && Resultado >= 70 ? "Aprobado" : "Reprobado"; } }
    }
}
