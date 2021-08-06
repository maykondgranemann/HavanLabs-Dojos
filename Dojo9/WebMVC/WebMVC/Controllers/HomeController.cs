using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using WebMVC.Reposiotry;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private SkateRepository repository = new SkateRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Skate> model = repository.Read();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Salvar(Skate model)
        {
            repository.Create(model);
            return View();
        }

        public ActionResult Deletar(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Skate model = repository.Read(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(Skate model)
        {
            repository.Editar(model);
            return RedirectToAction("Listar");
        }
    }
}