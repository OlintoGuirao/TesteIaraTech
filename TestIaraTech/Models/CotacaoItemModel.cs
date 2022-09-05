using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestIaraTech.Models
{
    public class CotacaoItemModel : Entity
    {
        [Required(ErrorMessage = "Digite a descrição do produto")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Digite o numero do item")]
        public int NumeroITem { get; set; }
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Digite a quantidade")]
        public decimal Quantidade { get; set; }
        public string Marca { get; set; }
        public string Unidade { get; set; }
       

    }
}
