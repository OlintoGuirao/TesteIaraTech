using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIaraTech.Models;
using TestIaraTech.Repositorio;

namespace TestIaraTech.Controllers
{
    public class CotacaoController : Controller
    {
        private readonly ICotacaoRepositorio _icotacaoRepositorio;

        public CotacaoController(ICotacaoRepositorio cotacaoRepositorio)
        {
            _icotacaoRepositorio = cotacaoRepositorio;
        }
        public IActionResult Index()
        {
            List<CotacaoModel>cotacaos =  _icotacaoRepositorio.BuscarTodos();
            return View(cotacaos);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(Guid id)
        {
           CotacaoModel cotacao = _icotacaoRepositorio.ListarId(id);
            return View(cotacao);
        }
        public IActionResult RemoverComfirmacao( Guid id)
        {
            CotacaoModel cotacao = _icotacaoRepositorio.ListarId(id);
            return View(cotacao);
        }


        public IActionResult Remover(Guid id)
        {
            _icotacaoRepositorio.Remover(id);
            return RedirectToAction("Index");

        }


        [HttpPost]
        public IActionResult Adicionar( CotacaoModel cotacao)
        {
            if (ModelState.IsValid)
            { 
            _icotacaoRepositorio.Adicionar(cotacao);
            return RedirectToAction("Index");
            }
            return View(cotacao);
        }
        [HttpPost]
        public IActionResult Editar (CotacaoModel cotacao)
        {
            if (ModelState.IsValid)
            {
                _icotacaoRepositorio.Editar(cotacao);
                return RedirectToAction("Index");
            }
            return View(cotacao);
            

        }
    }
}
