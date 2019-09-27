using System;

namespace McBonalds{
    public class Cliente{

      // ATRIBUTOS=======================
        public string Nome {get;set;}
        public string Endereço {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}

        // CONSTRUTOR=tem a Função de criar a instancia da classe   =
        public Cliente(string nome, string telefone, string email){
            // this é usado para especificar a variavel
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;

        }

        public Cliente()
        {
        }
    }
}