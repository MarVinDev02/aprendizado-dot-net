namespace Cadastro
{
    //Classe estática, serve apenas para poder chamar alguma função. 
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    //Classe normal
    public class Produto
    {
        private int Id;

        public string Descricao { get; set; }

        //Somente leitura
        public readonly int Estoque;
        // public int Estoque { get; }

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

    //Classe que será herdada.
    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("CEP: " + Cep);
        }
    }

    //Heranca
    //A classe herda os atributos e métodos da classe mãe/superclasse
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

    // Classe abstrata não pode ser instanciada, apenas herdada. 
    public abstract class Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }

        public string Descricao { get; set; }

        public abstract string GetInformations();


    }

    //subclasse
    public class Cachorro : Animal
    {
        public override string GetInformations()
        {
            return "Cachorro é um bom amigo!";
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome");
            Console.WriteLine("Informações: " + GetInformations());
        }
    }

    //Record
    public record Curso(int id, String Descricao); 
    // Forma de escrever um record.
 //{
 //   



 //    //public override bool Equals(object? obj)
 //    //{
 //    //    if (obj == null) return false;
    //    //    if (obj is Curso curso)
    //    //    {
    //    //        return Id == curso.Id && Descricao == curso.Descricao;
    //    //    }

    //    //    return base.Equals(obj);
    //    //}
    //    //public static bool operator ==(Curso a, Curso b)
    //    //{
    //    //    return a.Equals(b);
    //    //}

    //    //public static bool operator !=(Curso a, Curso b)
    //    //{
    //    //    return !(a == b);
    //    //}

    //}

    public class CursoTeste
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
    }

    //Interface
    //A classe que implementar uma interface terá que adotar todos os seus métodos. 
    public interface INotificacao
    {
        string Descricao { get; set; }
        void Notificar();

    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }
        public void Notificar()
        {
            Console.WriteLine("Notificando cliente!");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros!");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }
        public void Notificar()
        {
            Console.WriteLine("Notificando funcionário!");
        }

    }


}