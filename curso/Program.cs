//top Level statement

//Estrutura antiga

namespace Application
{


    public class Program
    {
        static void Main(string[] args)
        {
            var produto = new Cadastro.Produto();
            // var resultado = Cadastro.Calculos.SomarNumeros(1, 2);
            // Console.WriteLine("Resultado: " + resultado);
            // produto.Descricao = "Computador";
            // produto.SetId(1);
            // Console.WriteLine("Id: " + produto.GetId());
            // produto.ImprimirDescricao();
            // AulaPropriedadeSomenteLeitura();

            //AulaHeranca();

            
            
        }


        //Somente leitura
        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            Console.WriteLine("Produto: " + produto.Descricao + "\nDisponível: " + produto.Estoque);
        }


        //Heranca
        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1234;
            pessoaFisica.Endereco = "Rio de Janeiro";
            pessoaFisica.Cidade = "Rio de Janeiro";
            pessoaFisica.Cep = "1234352525";
            pessoaFisica.Cpf = "15681350762";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();

        }
    }
}

//Top Level Statement
//namespace Cadastro
//{
//    public class Cliente
//    { 

//    }
//    public class Funcionario
//    {

//    }
//}

//namespace Financeiro
//{
//    public class ContasReceber
//    {

//    }
//    public class Funcionario
//    {

//    }
//}




