using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECOMMERCE;

namespace ECOMMERCE.Controllers
{
    public class ProductsController : Controller
    {
        private INTEC_EcommerceEntities db = new INTEC_EcommerceEntities();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Mark).Include(p => p.Supplier).OrderByDescending(x=> x.CreatedDate);
            return View(products.ToList());
        }

        public ActionResult Test()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Mark).Include(p => p.Supplier).OrderByDescending(x => x.CreatedDate);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.MarkId = new SelectList(db.Marks, "Id", "Name");
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name");
            return View(new Product());
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Code,Name,ListPrice,PurchasePrice,Year,Description,MarkId,CategoryId,Ofert,OfertPrice,Picture,Rating,Height,Weight,ExpirationDate,MinStock,MaxStock,SupplierId,Enabled")] Product product, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                product.Id = Guid.NewGuid().ToString();
                product.CreatedDate = DateTime.Now;

                if (file != null)
                {
                    string pictureUrl = System.IO.Path.GetFileName(file.FileName);
                    string pathUrl = System.IO.Path.Combine(Server.MapPath("/Public/products"), pictureUrl);

                    file.SaveAs(pathUrl);

                    product.Picture = pictureUrl;
                }

                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
            ViewBag.MarkId = new SelectList(db.Marks, "Id", "Name", product.MarkId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", product.SupplierId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
            ViewBag.MarkId = new SelectList(db.Marks, "Id", "Name", product.MarkId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", product.SupplierId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Name,ListPrice,PurchasePrice,Year,Description,MarkId,CategoryId,Ofert,OfertPrice,Picture,Rating,Height,Weight,ExpirationDate,MinStock,MaxStock,SupplierId,Enabled,CreatedBy,CreatedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", product.CategoryId);
            ViewBag.MarkId = new SelectList(db.Marks, "Id", "Name", product.MarkId);
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", product.SupplierId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
