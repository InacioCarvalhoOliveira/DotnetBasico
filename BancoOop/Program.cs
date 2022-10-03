using System;
using CadastroDeCliente;

namespace BancoOop
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Banco Oop");
            NovoCadastro cadastro = new NovoCadastro();
            cadastro.NovoCliente("5033260840","Inacio Oliveira","inacio@oliveira.com");
            cadastro.NovoCliente("5033260840","Giulia Quaglia","giulia@quaglia.com");         
            cadastro.ValidarUsuario();

        }
    }
}
