using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja49.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Preco { get; set; }

        [Display(Name = "Image")]
        public string Url { get; set; }

        [Display(Name = "Última Compra")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Última Venda")]
        public DateTime UltimaVenda { get; set; }

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }


    }
}
