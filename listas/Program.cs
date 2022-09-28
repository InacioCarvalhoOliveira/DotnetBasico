using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            List - lista tudo 
            IEnumerable 

            
            */
            var pagamentos = new IEnumerable<Pagamento>();
            pagamentos.Add(new Pagamento(0));
            pagamentos.Add(new Pagamento(1));
            pagamentos.Add(new Pagamento(2));
            pagamentos.Add(new Pagamento(3));

            foreach (var item in pagamentos)
            {
                Console.WriteLine(item.Id);
            }
            /*
            listagem modos: 
            Where: 
            
            
            */                     
            var pagamentoA = pagamentos.Where(x => x.Id == 3);  
            Console.WriteLine(pagamentoA.Id);          
        }
    }
    public class Pagamento
    {
        public int Id { get; set; }
        public Pagamento(){}
        public Pagamento(int id)
        {
            this.Id = id;
        }
        
        
    }
}
