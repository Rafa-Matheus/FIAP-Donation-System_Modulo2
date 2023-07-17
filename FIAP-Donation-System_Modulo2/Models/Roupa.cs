using FIAP_Donation_System_Modulo2.Enums;
using FIAP_Donation_System_Modulo2.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Donation_System_Modulo2.Models
{
    public class Roupa : Produto
    {

        public ECategoriaRoupa Categoria { get; set; }
        public ETamanhoRoupa Tamanho { get; set; }
        public string Material { get; set; }
        public EComprimentoRoupa TipoComprimento { get; set; }

        public override string ExibirDados()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append(base.ExibirDados());
            sb.Append($"\nCategoria: {Categoria} \nTamanho: {Tamanho.GetDescription()}\nComprimento Roupa: {TipoComprimento.GetDescription()}");

            return sb.ToString();
        }
    }
}
