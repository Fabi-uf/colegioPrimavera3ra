using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;



namespace colegioPrimavera3ra.Controllers
{
    public class AlumnoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Alumno
        public ActionResult Index()
        {
            return View(db.Alumnos.Tolist());
        }

        private ActionResult View(object value)
        {
            throw new NotImplementedException();
        }

        // GET: Alumno/Crear
        public ActionResult Crear()
        {
            return View();
        }

        public ApplicationDbContext GetDb()
        {
            return db;
        }

        // POST: Alumno/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Alumno alumno, ApplicationDbContext bdalumnos, object alumnos)
        {
            if (ModelState.IsValid)
            {
                object valuealumno = alumnos.Add(alumno);
                bdalumnos.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alumno);
        }

        // GET: Alumno/Editar/5
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }

            return View(alumno);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        // POST: Alumno/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alumno);
        }

        // GET: Alumno/Eliminar/5
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }

            return View(alumno);
        }

        // POST: Alumno/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarConfirmar(int id)
        {
            Alumno alumno = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumno);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    
}




   
  

