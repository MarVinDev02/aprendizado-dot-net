//top Level statement

//Estrutura antiga

using Modulo12;

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
            // AulaClasseSelada();
            // AulaClasseAbstrata();
            //AulaRecord();
            // AulaInterface();
            // Conversores();
            // TrabalhandoComStrings();
            // AulaStarsWith();
            // AulaRepleace();
            //AulaLentgh
            //AulaClasseSelada();
            //Conversores
            //TrabalhandoComStrings;
            //CalcularIdade();
            // TrabalhandoComDatas();
            // TrabalhandoComExcessoes();
            TrabalhandoComArquivos();


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

        private static void AulaClasseSelada()
        {
            var configuracao = new Cadastro.Configuracao
            {
                Host = "LocalHost"
            };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro
            {
                Nome = "Perrito",
                Raca = "Cachorro",
                Idade = 9

            };

            Console.WriteLine(cachorro.Nome);
            Console.WriteLine(cachorro.Raca);
            Console.WriteLine(cachorro.Idade);
            Console.WriteLine(cachorro.GetInformations());
        }

        private static void AulaRecord()
        {
            var curso1 = new Cadastro.Curso(123, "Algo");
            var curso2 = curso1 with { Descricao = "Alguma coisa" }; //Copia o objeto, e altera apenas o valor de apenas um atributo. 

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
            //Console.WriteLine(curso1.Equals(curso2));
            // Console.WriteLine(curso1 == curso2);

            // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            // var curso2 = curso1; // Apontando para o mesmo endereço que curso 1;
            // curso2.Descricao = "teste";
            // var curso2 = new Cadastro.CursoTeste();
            // curso2.Descricao = "Nova Descriçao";
            // curso2.Id = curso1.Id;

        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            //forma estática de instanciar. Sem usar o var.
            var notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            conversores.ConvertAndParse();
        }
        // private static void Conversores()
        // {
        //     var conversores = new Conversores.Conversor();
        //     conversores.AulaTryParse();
        // }

        private static void TrabalhandoComStrings()
        {
            // var range = new Modulo10.TrabalhandoComStrings();
            var trim = new Modulo10.TrabalhandoComStrings();
            trim.AulaTrim();
        }

        private static void AulaStarsWith()
        {

            var trim = new Modulo10.TrabalhandoComStrings();
            trim.StartsWithEnds();
        }


        private static void AulaRepleace()
        {
            var repleace = new Modulo10.TrabalhandoComStrings();
            repleace.Repleace();
        }

        private static void AulaLentgh()
        {
            var lentgh = new Modulo10.TrabalhandoComStrings();
            lentgh.AulaLentgh();
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();

        }

        private static void TrabalhandoComDatas()
        {
            var datas = new Modulo11.TrabalhandoComDatas();
            datas.AulaTimeOnly();
        }

        private static void CalcularIdade()
        {
            Console.WriteLine("Em que ano você nasceu?");
            var dataDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano estamos?");
            var dataAtual = int.Parse(Console.ReadLine());
            var idade = dataAtual - dataDeNascimento;

            Console.WriteLine("Sua idade: " + idade);
        }

        private static void TrabalhandoComExcessoes()
        {
            var TrabalhandoComExcessoes = new Modulo12.TrabalhandoComExcessoes();
            TrabalhandoComExcessoes.AulaTratandoException();
        }

         private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
            trabalhandoComArquivos.AulaExcluindoArquivo();
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




