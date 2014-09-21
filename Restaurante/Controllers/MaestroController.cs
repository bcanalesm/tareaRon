using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurante.Controllers
{
    public class MaestroController : Controller
    {
        public Restaurante.Models.nidevs00_restauranteEntities2 bd = new Restaurante.Models.nidevs00_restauranteEntities2();
        //
        // GET: /Maestro/

        public ActionResult Maestro()
        {
            Models.Usuario user = new Models.Usuario();
            //user.IdUsuario = 1;
            //user.Login1 = "zD";
            //user.Nombre = "Coyotus";
            //user.Password1 = "12";

            //bd.Usuarios.Add(user);
            //bd.SaveChanges();


            return View("Maestro");
        }

        public bool login(String pass) {

            var user = bd.Usuarios.Find(pass);

            if (user == null) {
                return (false);
            }
            return (true);
        }

        public ActionResult Principal()
        {
            Models.Usuario user = new Models.Usuario();
            //user.IdUsuario = 1;
            //user.Login1 = "zD";
            //user.Nombre = "Coyotus";
            //user.Password1 = "12";

            //bd.Usuarios.Add(user);
            //bd.SaveChanges();


            return View("Principal" );
        }

    }
}
