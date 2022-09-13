using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente exibir1 = new Cliente(1,"inacio",22,EEstadoCivil.solteiro);
            System.Console.WriteLine(exibir1.Id);
            System.Console.WriteLine(exibir1.Nome);
            System.Console.WriteLine(exibir1.Idade);
            System.Console.WriteLine(exibir1.EstadoCivil);

            System.Console.WriteLine("\n");

            Cliente exibir2 = new Cliente(2,"francislene",40,EEstadoCivil.casado);
            System.Console.WriteLine(exibir2.Id);
            System.Console.WriteLine(exibir2.Nome);
            System.Console.WriteLine(exibir2.Idade);
            System.Console.WriteLine(exibir2.EstadoCivil);
            
            System.Console.WriteLine("\n");

            Cliente exibir3 = new Cliente(3,"marcelo",47,EEstadoCivil.viuvo);
            System.Console.WriteLine(exibir3.Id);
            System.Console.WriteLine(exibir3.Nome);
            System.Console.WriteLine(exibir3.Idade);
            System.Console.WriteLine(exibir3.EstadoCivil);
            

            
        }

        struct Cliente
        {
            public Cliente(int id, string nome, int idade, EEstadoCivil estadoCivil)
            {
                this.Id = id;
                this.Nome = nome;
                this.Idade = idade;
                this.EstadoCivil = estadoCivil;
            }

            public int Id;
            public string Nome;
            public int Idade;   
            public EEstadoCivil EstadoCivil;                    
            
        }

        enum EEstadoCivil
        {
            solteiro = 1,
            casado = 2,
            viuvo = 3,
            
        } 
    }
}
