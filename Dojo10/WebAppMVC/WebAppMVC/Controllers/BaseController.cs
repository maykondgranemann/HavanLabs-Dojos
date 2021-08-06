using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;
using WebAppMVC.Repository;

namespace WebAppMVC.Controllers
{
    public class BaseController<T,R> : Controller where T:BaseModel where R:BaseRepository<T>
    {
        R repository;
        public BaseController(R repo)
        {
            repository  = repo;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(T model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        public ActionResult List()
        {
            return View(repository.Read());
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(repository.Read(id));
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }
        [HttpPost]
        public ActionResult Edit(T model)
        {
            repository.Edit(model);
            return RedirectToAction("List");
        }
    }
}