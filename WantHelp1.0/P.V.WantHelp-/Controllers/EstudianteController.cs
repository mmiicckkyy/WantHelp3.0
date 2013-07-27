﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P.V.WantHelp_.Models;
using System.IO;
using System.IO.Compression;
using System.Data;
using System.Data.Entity;

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
        public ActionResult IngresaAlMaterial()
        {
            ViewBag.idUs = Session["idUsuario"];
            //ViewBag.idCursMat = id;

            return View();
        }
        public JsonResult Descargartodo(int id)
        {
            AdminActions contexto = new AdminActions();
            Cursos cursoM = contexto.getCursos(id);
            List<Material> lista = contexto.getFiless(id);
            Directory.CreateDirectory(Server.MapPath("/Archivos/descargas")+@"\"+cursoM.Titulo+@"\");
            foreach(Material item in lista)
            {
                string nombre = item.urlHost.Split('/')[2];
                string fecha = DateTime.Now;
                File.Copy(Server.MapPath(item.urlHost),Server.MapPath("/Archivos/descargas"+cursoM.Titulo)+"/"+nombre);
                // a.File.Copy(Server.MapPath(item.urlAbs), Server.MapPath("/archivos/descargas/"+user.nombres)+"/"+nombre);
            }
        }
    }
}
