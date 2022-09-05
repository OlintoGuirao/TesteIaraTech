using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestIaraTech.Models
{
    public class CotacaoModel : Entity
    {
        [Required (ErrorMessage ="Digite o CNPJ do comprador")]
        public string CNPJComprador { get; set; }
        [Required (ErrorMessage = "Digite o CNPJ do fornecedor")]
        public string CNPJFornecedor { get; set; }

        [Required (ErrorMessage = "Digite o numero da cotação")]
        public string NumeroCotacao { get; set; }
        [Required(ErrorMessage = "Digite a data da cotação")]
        public DateTime DataCotacao { get; set; }
        [Required(ErrorMessage = "Digite a data da entrega")]
        public DateTime DataEntregaCotacao { get; set; }
        [Required(ErrorMessage = "Digite o CEP")]
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Observacao { get; set; }
        public CotacaoItemModel CotacaoItens { get; set; }


    }
}
