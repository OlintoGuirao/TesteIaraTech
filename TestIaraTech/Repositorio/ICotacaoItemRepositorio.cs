using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIaraTech.Models;

namespace TestIaraTech.Repositorio
{
    public interface IcotacaoItemRepositorio
    {
        CotacaoItemModel ListarId(Guid id);
        List<CotacaoItemModel> BuscarTodos();
        CotacaoItemModel Adicionar(CotacaoItemModel cotacaoItem);
        CotacaoItemModel Editar(CotacaoItemModel cotacaoItem);
        bool Remover(Guid id);
    }
}
