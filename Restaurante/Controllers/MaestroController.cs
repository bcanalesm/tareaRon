using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurante.Controllers
{
    public class MaestroController : Controller
    {
        public Restaurante.Models.nidevs00_restauranteEntities1 bd = new Restaurante.Models.nidevs00_restauranteEntities1();
        //
        // GET: /Maestro/

        public ActionResult Maestro()
        {
            
            ViewBag.Usuario = bd.Usuarios;

            return View("", ViewBag);
        }

        public bool correcto(String pass) {

            

            return (true);
        }

    }
}
