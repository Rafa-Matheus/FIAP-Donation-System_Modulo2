using FIAP_Donation_System_Modulo2.Enums;
using FIAP_Donation_System_Modulo2.Models;
using System;

namespace FIAP_Donation_System_Modulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Roupa roupa = new Roupa();
            roupa.Nome = "Camiseta";
            roupa.Categoria = ECategoriaRoupa.Camisetas;
            roupa.Tamanho = ETamanhoRoupa._4;
            roupa.TipoComprimento = EComprimentoRoupa.AcimaDoJoelho;
            Console.WriteLine(roupa.ExibirDados());

            Calcado calcado = new Calcado();
            calcado.Tamanho = ETamanhoCalcado.Dois;
            calcado.TipoAjuste = ETipoAjuste.Botao;



            //Produto p = new Produto();


            //            p.nome = "sapato";
            //            p.descricao = "sapato rosa novo";
            //            p.genero = "feminino";
            //            p.foto = "sem foto";
            //            p.status = true;




            //            Usuario usuario = new Usuario();
            //            usuario.nome = "Admin";
            //            usuario.email = "";
            //;            Console.WriteLine("E-mail: "+ usuario.exibirDados());
        }

    }
}
}
