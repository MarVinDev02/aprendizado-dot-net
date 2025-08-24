namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {
        private int Id;

        public string Descricao { get; set; }

        //Somente leitura
        // public readonly int Estoque;
        public int Estoque { get; }

        //Construtor
        public Produto()
        {
            Estoque = 1;
        }

        //Funcoes
        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " " + Descricao);

        }

        public void SetId(int id)
        {
            Id = id; ;
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
            System.Console.WriteLine("Código: " + Id);
            System.Console.WriteLine("Endereco: " + Endereco);
            System.Console.WriteLine("Cidade: " + Cidade);
            System.Console.WriteLine("CEP: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa

    {
        public string Cpf { get; set; }

        public void ImprimirCpf()
        {
            System.Console.WriteLine("CPF: " + Cpf);
        }
    }

    //Classe selada: Não pode ser herdada;
    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    public abstract class Animal
    {
        public string nome { get; set; }
        public string raca { get; set; }
        public int idade { get; set; }
    }

    public class Cachorro : Animal
    {
        
    }

}