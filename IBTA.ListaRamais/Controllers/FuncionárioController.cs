using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IBTA.ListaRamais.Models;

namespace IBTA.ListaRamais.Controllers
{
    public class FuncionárioController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Funcionário
        public ActionResult Index()
        {
            return View(db.Funcionarios.ToList());
        }

        // GET: Funcionário/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionário funcionário = db.Funcionarios.Find(id);
            if (funcionário == null)
            {
                return HttpNotFound();
            }
            return View(funcionário);
        }

        // GET: Funcionário/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionário/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoFuncionario,CodigoDepartamento,Nome,Departamento,Email,Ramal,Cargo")] Funcionário funcionário)
        {
            if (ModelState.IsValid)
            {
                db.Funcionarios.Add(funcionário);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcionário);
        }

        // GET: Funcionário/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionário funcionário = db.Funcionarios.Find(id);
            if (funcionário == null)
            {
                return HttpNotFound();
            }
            return View(funcionário);
        }

        // POST: Funcionário/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoFuncionario,CodigoDepartamento,Nome,Departamento,Email,Ramal,Cargo")] Funcionário funcionário)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionário).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionário);
        }

        // GET: Funcionário/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionário funcionário = db.Funcionarios.Find(id);
            if (funcionário == null)
            {
                return HttpNotFound();
            }
            return View(funcionário);
        }

        // POST: Funcionário/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionário funcionário = db.Funcionarios.Find(id);
            db.Funcionarios.Remove(funcionário);
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
