using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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

        public bool login(String pass,int Rol) {
             Models.Usuario usuario = new Models.Usuario();
          
            //var user = bd.Usuarios.Find(pass);

             var user1 = bd.Database.SqlQuery<Models.Usuario>("SELECT * FROM [nidevs00_bdc05].[Usuario] U INNER JOIN [nidevs00_ron09].[RolxUsuario] RU ON RU.idUsuario = U.idUsuario INNER JOIN [nidevs00_ron09].[Rol] RO ON RO.idRol = RU.idRol  where Password1 = '" + pass + "'  AND RO.idRol = " + Rol);
            

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


        public bool crearProducto(int id, String Nombre,float Precio,int categoria)
        {
            Models.Producto pro = new Models.Producto();

            pro.Idproducto = id;
            pro.Nombre = Nombre;
            pro.Precio = Precio;
            pro.IdCategoria = categoria;

            bd.Productoes.Add(pro);

            bd.SaveChanges();

            return true;

        }

        

        public String obtenerMesas()
        {

            JavaScriptSerializer ts = new JavaScriptSerializer();

            var mesas = bd.Mesas.ToList();

            var json = ts.Serialize(mesas);

            return json;

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
        public ActionResult Usuario()
        {
            return View("Usuario");
        }
        public ActionResult Producto()
        {
            return View("Producto");
        }
        public ActionResult Pedido()
        {
            return View("Pedido");
        }
        public ActionResult Pago()
        {
            return View("Pago");
        }

    }
}
