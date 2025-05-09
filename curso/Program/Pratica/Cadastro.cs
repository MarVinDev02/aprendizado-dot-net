using System.Collections;
using Humano;

namespace Cadastro
{
    public class CadastroGeral 
    {
        private List<Pessoa> lista { set; get; }

        public CadastroGeral()
        {
            lista = new List<Pessoa>();
        }

        public void adicionarPessoas(Pessoa pessoa)
        {
            lista.Add(pessoa);
        }

        public void mostrarListaDePessoas()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}