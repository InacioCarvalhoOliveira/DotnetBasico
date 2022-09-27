//  using System;

//  namespace Oop
//  {
//      class Program
//      {
//          static void Main(string[] args)
//          {
//              Console.Clear();

//              /*
//                  instancia classe Pagamento, para acessar os obejtos e métodos que 
//                  forem acessívies(contanto que sejam públicos)            
//              */
            
//              /*desta forma é necessário sempre inicializar o dispose, e, pode ocorrer de vc esquecer
//              var Pagamento = new Pagamento();
//              Pagamento.Dispose();

//               o mesmo dispose porem já instanciado, sem perigo de haver esquecimentos 
//               using(var Pagamento = new Pagamento()){
//                   Console.WriteLine("processando classes");               
//               }
//              */

//              Pagamento retornaInfoPagamento = new Pagamento();            
//              Console.WriteLine("salário Atual: "+retornaInfoPagamento.retornaSalario());
//              Console.WriteLine("Reajuste aplicado de: "+retornaInfoPagamento.reajusteSalario());
//              Console.WriteLine("Forma de pagamento: "+retornaInfoPagamento.retornaPagamento());
            
//              DadosDaContaCorrente retornaInfoConta = new DadosDaContaCorrente();
//              Console.WriteLine(retornaInfoConta.Nome = "inacio");
//              Console.WriteLine(retornaInfoConta.Cargo = "dev");
//              Console.WriteLine(retornaInfoConta.retornaCpf());                
//              /*
//                  System.Console.WriteLine(retorna.Salario*10);
//                  isto funcionaria se a propriedade Salario da classe Pagamento fosse pública 
//              */
//          }  
//      }

//      public class Pagamento : IDisposable
//      {
//          /*
//              por via de regra não exite propriedade pública, pois não faz
//              sentido alterar uma propriedade de uma classe pertencente a outra              
//          */
//          public Pagamento()
//          {
//              Console.WriteLine("iniciando Classe"); 
//              Console.WriteLine(DateTime.Now);
                       
//          }
//          private double Salario { get; set; }
//          private string FormaDePagamento { get; set; }
        
//          public Pagamento(double salario, string formaDePagamento)
//          {
//              this.Salario = salario; 
//              this.FormaDePagamento = formaDePagamento;
//          }
//          public double retornaSalario()
//          {               
//              return Salario = 1300; 
//          }
//          public string retornaPagamento()
//          {               
//              return FormaDePagamento = "boleto"; 
//          }        
//          public double reajusteSalario()
//          {                
//              var r = Salario * 0.2;
//              return r; 
//          }

//          public void Dispose()
//          {
//              Console.WriteLine("finalizando classe");            
//          }
//      }

//      public class DadosDaContaCorrente 
//      {
//          private string CPF { get; set; }
//          public string Nome { get; set; }
//          public string Cargo { get; set; }

//          public DadosDaContaCorrente(){}
//          public DadosDaContaCorrente(string cpf, string nome, string cargo)
//          {
//              this.CPF = cpf;
//              this.Nome = nome;
//              this.Cargo = cargo;
//          }

//          public string retornaCPF(int Pf_Pj)
//          {
//              this.CPF = CPF;
//              return CPF;
//          }
//          public string retornaNome()
//          {           
//              return Nome = "";

//          }
//           public string retornaCpf()
//          {           
//              return CPF = "1234.111.122-12";
//          }
//           public string retornaCargo()
//          {           
//              return Cargo = "";

//          }     
//      }   

//  }
