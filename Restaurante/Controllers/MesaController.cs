using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurante.Controllers
{
    public class MesaController : Controller
    {
        //
        // GET: /Mesa/

        public ActionResult Mesa()//identico al nombre de la visa, se pueden retornar objetos ...
        {
            return View();
        }

    }
}
