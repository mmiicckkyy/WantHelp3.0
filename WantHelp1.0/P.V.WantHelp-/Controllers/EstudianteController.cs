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
            //Cursos cursofoto = db.Cursos();
            //ViewBag.fotoportada = cursofoto.FotoPortada;
            return View(db.Cursos.ToList()); ;
        }

    }
}
