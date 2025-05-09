//namespace Cadastro;
//namespace >> class >> atributo e metodo >> getter e setter
using static Cadastro.Configuracao;

namespace Cadastro
{
    //Classe estática
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    //Classe
    public class Produto
    {
        public string Descricao { get; set; }

        //Só consigo acessar através do construtor
        //public readonly int Estoque; // Somente leitura, não posso instanciar.

        public int Estoque { get; }
        public readonly int Numeros;

        public Produto()
        {
            Estoque = 1;
            Numeros = 3;
        }

        private int Id { get; set; }


        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }
    //Classe com Herança
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public void ImprimirCPF()
        {
            Console.WriteLine("Cpf: " + Cpf);

        }
    }

    //Classe recebendo herança
    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }

    }

    //Classe Selada
    //Não pode ser herdada, mas pode ser instanciada. 
    //Diferente da super classe
    public sealed class Configuracao
    {
        public string Host  { get; set; }
    }


    //Classe abstrata
    // Não pode ser instanciada, ela só pode ser herdada;
    //O contrário de sealed class. 
    public abstract class Animal
        {
            public string Nome { get; set; }

            //Precisa ser, obrigatoriamente herdada pela classe filha.
            public abstract string GetInformacoes();

            public void ImprimirDados()
            {
                Console.WriteLine("Nome Animal: " + Nome);
                Console.WriteLine("Informações: " + GetInformacoes());
            }



        }
        //Record

    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }

    }

    public class Curso
    {
        public int Id { get; set; }

        public String Descricao { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }
            return base.Equals(obj);
        }

    }

}