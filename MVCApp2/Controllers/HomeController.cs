using System;
using System.Collections.Generic;
using MVCApp2.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.TarefaProcessor;

namespace MVCApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewTarefas()
        {
            ViewBag.Message = "Lista de Tarefas";

            var pegarDados = LoadTarefas();
            List<TarefaModel> tarefas = new List<TarefaModel>();

            foreach (var row in pegarDados)
            {
                tarefas.Add(new TarefaModel
                {
                    Nome = row.Nome,
                    Descricao = row.Descricao,
                    Data = row.Data
                });
            }

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Cadastrar tarefas.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(TarefaModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateTarefa(model.Nome, model.Descricao, model.Data);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}