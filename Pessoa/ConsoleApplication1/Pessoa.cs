using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pessoa
    {
        string Nome { get; set;}
        string Sobrenome { get; set; }
        string Cpf { get; set; }
        string Telefone { get; set; }
        int Dia { get; set; }
        int Mês { get; set; }
        int Ano { get; set; }

        public Pessoa(){}
        public Pessoa( string nome, string sobrenome)
       {
           this.Nome = nome;
           this.Sobrenome = sobrenome;
       }
        public Pessoa(string cpf) 
        {
            this.Cpf = cpf;
        }
        public Pessoa(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }
}
