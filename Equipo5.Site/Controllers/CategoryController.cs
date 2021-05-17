using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Equipo5.Business;
using Equipo5.Entities.Models;

namespace Equipo5.Site.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var biz = new CategoryBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                var biz = new CategoryBiz();
                biz.Agregar(model);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                // que pasa con el error -> Bitacora
                Console.WriteLine(e);
                return View(model);
            }

            /*
            [HttpGet]
            public ActionResult Edit(int id)
            {
                var biz = new CategoryBiz();
                var model = biz.Buscar(id);
                if (model == null)
                    throw new Exception();

                return View(model);
            }*/

        }
    }
}