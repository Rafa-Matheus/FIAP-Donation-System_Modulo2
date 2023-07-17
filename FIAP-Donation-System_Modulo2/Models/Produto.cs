using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Donation_System_Modulo2.Models
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public string Foto { get; set; }
        public bool Status { get; set; }

        public abstract string ExibirDados();
    }
}
