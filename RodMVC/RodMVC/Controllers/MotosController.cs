using RodMVC.Models;
using RodMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RodMVC.Controllers
{
    public class MotosController : Controller
    {
        MotoRepository repository = new MotoRepository();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Moto model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        public ActionResult Lista()
        {
            return View(repository.Read());
        }
        
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Moto model = repository.Read(id);

            return View();
        }
        [HttpPost]
        public ActionResult Editar(Moto model)
        {
            repository.Update(model);
            return RedirectToAction("Lista");
            
        }
        public ActionResult Deletar(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Lista");
        }
        public ActionResult Detalhes(int id)
        {
            return View(repository.Read(id));
        }
        
    }

}
