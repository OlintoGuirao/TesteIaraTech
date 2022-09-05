using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIaraTech.Data;
using TestIaraTech.Models;

namespace TestIaraTech.Repositorio
{
    public class CotacaoItemRepositorio : IcotacaoItemRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CotacaoItemRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

        public CotacaoItemModel ListarId(Guid id)
        {
            return _bancoContext.CotacaoItem.FirstOrDefault(x => x.Id == id);
        }
        public List<CotacaoItemModel> BuscarTodos()
        {
            return _bancoContext.CotacaoItem.ToList();
        }


        public CotacaoItemModel Adicionar(CotacaoItemModel CotacaoItem)
        {
            _bancoContext.CotacaoItem.Add(CotacaoItem);
            _bancoContext.SaveChanges();
            return CotacaoItem;
        }

        public CotacaoItemModel Editar(CotacaoItemModel cotacaoItem)
        {
            CotacaoItemModel CotacaoItemDb = ListarId(cotacaoItem.Id);
            if (CotacaoItemDb == null) throw new Exception("Houve um erro ao editar");

            CotacaoItemDb.Descricao = cotacaoItem.Descricao;
            CotacaoItemDb.NumeroITem = cotacaoItem.NumeroITem;
            CotacaoItemDb.Preco = cotacaoItem.Preco;
            CotacaoItemDb.Quantidade = cotacaoItem.Quantidade;
            CotacaoItemDb.Marca = cotacaoItem.Marca;
            CotacaoItemDb.Unidade = cotacaoItem.Unidade;

            _bancoContext.CotacaoItem.Update(CotacaoItemDb);
            _bancoContext.SaveChanges();

            return CotacaoItemDb;

        }
        public bool Remover(Guid id)
        {
            CotacaoItemModel cotacaoItem = ListarId(id);
            if (cotacaoItem == null) throw new Exception("Houve um erro ao Remover a cotacão");

            _bancoContext.CotacaoItem.Remove(cotacaoItem);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
