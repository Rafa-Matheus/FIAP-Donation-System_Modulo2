using FIAP_Donation_System_Modulo2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Donation_System_Modulo2.Models
{
    public class Calcado : Produto
    {

        public string Material { get; set; }
        public ETamanhoCalcado Tamanho { get; set; }
        public ECategoriaCalcado Categoria { get; set; }
        public ETipoAjuste TipoAjuste { get; set; }

        public override string ExibirDados()
        {
            throw new NotImplementedException();
        }
    }
}
