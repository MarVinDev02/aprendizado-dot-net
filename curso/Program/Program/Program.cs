using Cadastro;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            //AulaClasseAbstrata();
            AulaRecord();
        }

        private static void AulaClasseSelada()
        {
            //var configuracao = new Cadastro.Configuracao();
            //configuracao.Host = "localHost";

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaHeranca()
        {

            //var funcionario = new Cadastro.Funcionario();
            //funcionario.Id = 1;
            //funcionario.Endereco = "Endereço Teste";
            //funcionario.Cidade = "Cidade Teste";
            //funcionario.Cep = "123456";
            //funcionario.Cpf = "1234523232";
            //funcionario.ImprimirDados();
            //funcionario.ImprimirCPF();

            //pessoaFisica.ImprimirCPF();var pessoaFisica = new Cadastro.PessoaFisica();
            //pessoaFisica.Id = 1;
            //pessoaFisica.Endereco = "Endereço Teste";
            //pessoaFisica.Cidade = "Cidade Teste";
            //pessoaFisica.Cep = "123456";
            //pessoaFisica.Cpf = "1234523232";
            //pessoaFisica.ImprimirDados();
            //pessoaFisica.ImprimirCPF();
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
        //var produto = new Cadastro.Produto();
        //produto.Descricao = "Alguma coisa";
        //Não consigo colocar valor.
        //produto.Estoque = 1;
        //Console.WriteLine(produto.Estoque);
        //Console.WriteLine(produto.Numeros);

         }
        private static void AulaClasseAbstrata()
        {
            //     var cachorro = new Cadastro.Cachorro();
            //     cachorro.Nome = "Dog";
            //     cachorro.ImprimirDados();
            // }
        }

        private static void AulaRecord()
        {
            var curso1 = new Cadastro.Curso() { Id = 1, Descricao = "Curso" };
            var curso2 = new Cadastro.Curso() { Id = 1, Descricao = "Curso" };

            Console.WriteLine(curso1.Equals(curso2));
            Console.WriteLine(curso1 == curso2);
        }
    }
}

//var produto = new Cadastro.Produto();

//produto.Descricao = "Teclado";
//produto.SetId(1);
//Console.WriteLine(produto.GetId());
//produto.ImprimirDescricao();
