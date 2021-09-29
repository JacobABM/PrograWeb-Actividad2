using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actividad2.Models;

namespace Actividad2.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Revisar Calificaciones";
        }

        public IActionResult Calificaciones(PerfilViewModel vm)
        {
                return View(vm);
        }
    }
}
