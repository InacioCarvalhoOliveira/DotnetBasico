using System;
using BancoOop;

namespace CadastroDeCliente
{
    class NovoCadastro : Program
    {
        private string CPF { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }

        public NovoCadastro(){}

        public NovoCadastro(string cpf, string nome, string email)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.Email = email;
        }

        public void NovoCliente()
        {
            Console.WriteLine("--Cadastro de cliente--");
            Console.WriteLine("--Novo Cadastro--");            
            // nome = new Console.WriteLine();                             
            // System.Console.WriteLine(nome);

        }

    }

    
}