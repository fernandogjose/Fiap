using Fiap.Application.Interfaces.AppServices;
using Fiap.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Fiap.Mvc.Controllers
{

    public class HomeController : Controller
    {

        private readonly IReceitaAppService _receitaAppService;

        public HomeController(IReceitaAppService receitaAppService)
        {
            _receitaAppService = receitaAppService;
        }

        public IActionResult Index()
        {
            IEnumerable<Receita> response = _receitaAppService.List();
            return View(response);
        }

        public IActionResult Novo()
        {
            Receita response = new Receita();
            return View(response);
        }

        public IActionResult Novo(Receita receita)
        {
            _receitaAppService.Add(receita);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            Receita response = _receitaAppService.Get(id);
            return View(response);
        }

        public IActionResult Editar(Receita receita)
        {
            _receitaAppService.Update(receita);
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {
            _receitaAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}