using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Raamatukogu.Models;

namespace Raamatukogu.Controllers
{
    public class RaamatuLisamineController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult RaamatuVäljaLaenutamine([Bind(Include = "Id,nimi,raamat")] RaamatuVäljaLaenutamine raamatuväljalaenutamine)
		{
			if (ModelState.IsValid)
			{
				db.RaamatuVäljaLaenutamine.Add(raamatuväljalaenutamine);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(raamatuväljalaenutamine);
		}

		public ActionResult Laenutus()
		{
			return View(db.RaamatuLisamine.ToList());
		}

		public ActionResult RaamatuLisamine()
		{
			return View();
		}
		public ActionResult RaamatuVäljaLaenutamine()
		{
			return View(db.RaamatuVäljaLaenutamine.ToList());
		}

		// POST: RaamatuLisamines/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult RaamatuLisamine([Bind(Include = "Id,nimi,autor,LaenuPikkus")] RaamatuLisamine raamatuLisamine)
		{
			if (ModelState.IsValid)
			{
				db.RaamatuLisamine.Add(raamatuLisamine);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(raamatuLisamine);
		}
		// GET: RaamatuLisamines
		public ActionResult Index()
        {
            return View(db.RaamatuLisamine.ToList());
        }

        // GET: RaamatuLisamines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaamatuLisamine raamatuLisamine = db.RaamatuLisamine.Find(id);
            if (raamatuLisamine == null)
            {
                return HttpNotFound();
            }
            return View(raamatuLisamine);
        }

        // GET: RaamatuLisamines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RaamatuLisamines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nimi,autor,LaenuPikkus")] RaamatuLisamine raamatuLisamine)
        {
            if (ModelState.IsValid)
            {
                db.RaamatuLisamine.Add(raamatuLisamine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raamatuLisamine);
        }

        // GET: RaamatuLisamines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaamatuLisamine raamatuLisamine = db.RaamatuLisamine.Find(id);
            if (raamatuLisamine == null)
            {
                return HttpNotFound();
            }
            return View(raamatuLisamine);
        }

        // POST: RaamatuLisamines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nimi,autor,LaenuPikkus")] RaamatuLisamine raamatuLisamine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raamatuLisamine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raamatuLisamine);
        }

        // GET: RaamatuLisamines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RaamatuLisamine raamatuLisamine = db.RaamatuLisamine.Find(id);
            if (raamatuLisamine == null)
            {
                return HttpNotFound();
            }
            return View(raamatuLisamine);
        }

        // POST: RaamatuLisamines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RaamatuLisamine raamatuLisamine = db.RaamatuLisamine.Find(id);
            db.RaamatuLisamine.Remove(raamatuLisamine);
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
