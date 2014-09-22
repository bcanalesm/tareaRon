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
             Models.Usuario usuario = new Models.Usuario();
          
            //var user = bd.Usuarios.Find(pass);

            var user1 = bd.Database.SqlQuery<Models.Usuario>("Select * from Usuario where Password1 = '"+pass+"' ");
            

            if (user1.ToList().FirstOrDefault() == null)
            {
                return (false);
            }
            return (true);
        }


        public bool CrearMesa(int id, int cantidad) {
            Models.Mesa mesa = new Models.Mesa();

            mesa.IdMesa = id;
            mesa.Capacidad = cantidad;

            bd.Mesas.Add(mesa);

            bd.SaveChanges();

            return true;

        }


        public ActionResult Principal()
        {
           return View("Principal" );
        }

        public ActionResult Mesa()
        {
            return View("Mesa");
        }

        public ActionResult Crear()
        {
            return View("Crear");
        }

    }
}
