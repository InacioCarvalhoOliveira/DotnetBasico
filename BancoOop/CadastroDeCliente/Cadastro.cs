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

        public void NovoCliente(string cpf,string nome, string email)       
        
        {
            Console.WriteLine("--Cadastro de cliente--");
            Console.WriteLine("--Novo Cadastro--");
            this.CPF = cpf;
            this.Nome = nome;
            this.Email = email;

            Console.WriteLine(cpf);
            Console.WriteLine(nome);                        
            Console.WriteLine(email);
            ValidarUsuario();
                                    
                      
            // nome = new Console.WriteLine();                             
            // System.Console.WriteLine(nome);

        }        
        public void ValidarUsuario()
        {
            int CompareTo(NovoCadastro cliente)
            {       
                if(this.CPF == cliente.CPF)
                {

                System.Console.WriteLine("usuario existe");
                return this.Nome.CompareTo(cliente.Nome);
                }
                
                else
                {
                throw new NotImplementedException();
                // return cliente.Nome.CompareTo(this.CPF);                
                }            
            }
        }
    }    
}