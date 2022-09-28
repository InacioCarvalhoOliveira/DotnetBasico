// using System;

// namespace Oop
// {
//     public class NovaPagamento
//     {     
//         //delegate   
//         static void RealizarPagamento(double valor)
//         {
//             Console.WriteLine($"Pague o valor de {valor}");                
//         }
//         static void Main(string[] args)
//         {
//             var pessoa  = new Pessoa("inacio","21",550);
//             var pessoaA  = new Pessoa("inacio","21",550);
//             var pessoaB  = new Pessoa("inacio","21",550);

//             //delegate
//             var pagar = new Pagamento.Pagar(RealizarPagamento);
//             pagar(25);
            
//             pessoa = new PessoaFisica("50332620840");
//             pessoa = new PessoaJuridica("121222-00001/1");

//             Console.WriteLine(pessoaA.Equals(pessoaB));
            
            
//         }
//     }
//     public class Pessoa : IEquatable<Pessoa>
//     {
//         private string Nome { get; set; }
//         private string Idade { get; set; }
//         private int salario { get; set; }
//         public Pessoa(){}
//         public Pessoa(string nome,string idade,int salario)
//         {
//             this.Nome = nome;
//             this.Idade = idade;
//             this.salario = salario;
//         }

//         public bool Equals(Pessoa pessoa)
//         {            
//             return Idade == pessoa.Idade; 
//         }
//     }
//     public class PessoaFisica : Pessoa
//     {
//         public string CPF { get; set; }
//         public PessoaFisica(){}
//         public PessoaFisica(string cpf)
//         {
//             this.CPF = cpf; 
//         }      
        
//     }
//     public class PessoaJuridica : Pessoa 
//     {
//         private string CNPJ { get; set; }
//         public PessoaJuridica(){}
//         public PessoaJuridica(string cnpj)
//         {
//             this.CNPJ = cnpj;
//         }       
//     }

//     //deleagte
//     public class Pagamento
//     {
//         public delegate void Pagar(double valor);
        
//     }

// }