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
        public ActionResult ClasesCurso(int id)
        {
            CursosActions contextoC = new CursosActions();
            return View(contextoC.getSesiones(id));
        }
        public ActionResult IngresarAlCurso(int id)
        {
            ViewBag.idUs = Session["idUsuario"];
            ViewBag.idSesion = id;
            string NameS = db.sesiones.Where(a => a.id == id).FirstOrDefault().titulo;
            ViewBag.NameSc = NameS;
            return View();
        }
    }
}
