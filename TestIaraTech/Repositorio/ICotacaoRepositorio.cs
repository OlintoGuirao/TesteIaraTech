using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIaraTech.Models;

namespace TestIaraTech.Repositorio
{
    public interface ICotacaoRepositorio
    {
        CotacaoModel ListarId(Guid id);
        List<CotacaoModel> BuscarTodos();
        CotacaoModel Adicionar(CotacaoModel cotacao);
        CotacaoModel Editar(CotacaoModel cotacao);
        bool Remover(Guid id);
        
        
    }
}
