using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIaraTech.Data;
using TestIaraTech.Models;

namespace TestIaraTech.Repositorio
{
    public class CotacaoRepositorio : ICotacaoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CotacaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
      

        public CotacaoModel ListarId(Guid id)
        {
            return _bancoContext.Cotacao.FirstOrDefault(x => x.Id == id);
        }
        public List<CotacaoModel> BuscarTodos()
        {
            return _bancoContext.Cotacao.ToList();
        }

        public CotacaoModel Adicionar(CotacaoModel cotacao)
        {
            _bancoContext.Cotacao.Add(cotacao);
            _bancoContext.SaveChanges();
            return cotacao;
        }
        public CotacaoModel Editar(CotacaoModel cotacao)
        {
            CotacaoModel CotacaoDb = ListarId(cotacao.Id);
            if (CotacaoDb == null) throw new Exception("Houve um erro ao editar");

            CotacaoDb.CNPJComprador = cotacao.CNPJComprador;
            CotacaoDb.CNPJFornecedor = cotacao.CNPJFornecedor;
            CotacaoDb.NumeroCotacao = cotacao.NumeroCotacao;
            CotacaoDb.DataCotacao   = cotacao.DataCotacao;
            CotacaoDb.DataEntregaCotacao = cotacao.DataEntregaCotacao;
            CotacaoDb.CEP  = cotacao.CEP;
            CotacaoDb.Logradouro = cotacao.Logradouro;
            CotacaoDb.Complemento = cotacao.Complemento;
            CotacaoDb.Bairro = cotacao.Bairro;
            CotacaoDb.UF = cotacao.UF;
            CotacaoDb.Observacao = cotacao.Observacao;
            CotacaoDb.CotacaoItens = cotacao.CotacaoItens;

            _bancoContext.Cotacao.Update(CotacaoDb);
            _bancoContext.SaveChanges();

            return CotacaoDb;
            
        }

        public bool Remover( Guid id)
        {
            CotacaoModel CotacaoDb = ListarId(id);
            if (CotacaoDb == null) throw new Exception("Houve um erro ao Remover a cotacão");

            _bancoContext.Cotacao.Remove(CotacaoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
