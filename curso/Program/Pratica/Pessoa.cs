using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humano
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome(){
            return Nome;
        }

        public void SetIdade(int idade)
        {
            Idade = idade;
        }

        public int GetIdade(){
            return Idade;
        }

        public override string ToString()
        {
            return $"Nome: {GetNome()}, Idade: {GetIdade()}";
        }
    }
}