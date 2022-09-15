using System;

namespace Aoo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                instancia classe Pagamento, para acessar os obejtos e métodos que 
                forem acessívies(contanto que sejam públicos)            
            */

            Pagamento retorna = new Pagamento();            
            Console.WriteLine(retorna.retornaSalario());
            System.Console.WriteLine(retorna.retornaPagamento());
            System.Console.WriteLine(retorna.reajusteSalario());

            /*
                System.Console.WriteLine(retorna.Salario*10);
                isto funcionaria se a propriedade Salario da classe Pagamento fosse pública 
            */
        }  
    }

    public class Pagamento 
    {
        /*
            por via de regra não exite propriedade pública, pois não faz
            sentido alterar uma propriedade de uma classe pertencente a outra              
        */
        private double Salario { get; set; }
        private string FormaDePagamento { get; set; }
        public Pagamento(){}
        public Pagamento(double salario, string formaDePagamento)
        {
            this.Salario = salario; 
            this.FormaDePagamento = formaDePagamento;
        }
        public double retornaSalario()
        {               
            return Salario = 100; 
        }
        public string retornaPagamento()
        {               
            return FormaDePagamento = "boleto"; 
        }        
        public double reajusteSalario()
        {                
            var r = Salario * 0.2;
            return r; 
        }
        
    }

    

}
