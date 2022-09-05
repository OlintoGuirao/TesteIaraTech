using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIaraTech.Models;
using TestIaraTech.Repositorio;

namespace TestIaraTech.Controllers
{
    public class CotacaoItemController : Controller
    {
        private readonly IcotacaoItemRepositorio _icotacaoItemRepositorio;

        public CotacaoItemController(IcotacaoItemRepositorio cotacaoItemRepositorio)
        {
            _icotacaoItemRepositorio = cotacaoItemRepositorio;
        }
        public IActionResult Index()
        {
            List<CotacaoItemModel> Itemcotacao = _icotacaoItemRepositorio.BuscarTodos();
            return View(Itemcotacao);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(Guid id)
        {
            CotacaoItemModel cotacaoItem = _icotacaoItemRepositorio.ListarId(id);
            return View(cotacaoItem);
        }
        public IActionResult RemoverComfirmacao(Guid id)
        {
            CotacaoItemModel cotacaoItem = _icotacaoItemRepositorio.ListarId(id);
            return View(cotacaoItem);
        }


        public IActionResult Remover(Guid id)
        {
            _icotacaoItemRepositorio.Remover(id);
            return RedirectToAction("Index");

        }


        [HttpPost]
        public IActionResult Adicionar(CotacaoItemModel cotacaoItem)
        {
            if (ModelState.IsValid)
            {
                _icotacaoItemRepositorio.Adicionar(cotacaoItem);
                return RedirectToAction("Index");
            }
            return View(cotacaoItem);
        }
        [HttpPost]
        public IActionResult Editar(CotacaoItemModel cotacaoItem)
        {
            if (ModelState.IsValid)
            {
                _icotacaoItemRepositorio.Editar(cotacaoItem);
                return RedirectToAction("Index");
            }
            return View(cotacaoItem);


        }
    }
}
