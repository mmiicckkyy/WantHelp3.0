using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P.V.WantHelp_.Models;

namespace P.V.WantHelp_.Controllers
{
    public class EstudianteController : Controller
    {
        //
        // GET: /Estudiante/
        private contextodb db = new contextodb();
        
        public ActionResult Index()
        {
            /*  foto Avatar  */
            int aux = Convert.ToInt32(Session["idUsuario"]);
            string Cadenausuario = db.Usuario.Where(a => a.Id_Usu == aux).FirstOrDefault().Avatar;
            ViewBag.fotoA = Cadenausuario;
            /*******************/
            //Cursos cursofoto = db.Cursos();
            //ViewBag.fotoportada = cursofoto.FotoPortada;
            return View(db.Cursos.ToList()); ;
        }

    }
}
