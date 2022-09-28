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
            List - tipo genérico de lista 
            List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
            implementação: 
            IEnumerable, IList         
            */

            // var teste = new List<Pagamento>();

            var pagamentos = new List<Pagamento>();
       
            pagamentos.Add(new Pagamento(0));
            pagamentos.Add(new Pagamento(1));
            pagamentos.Add(new Pagamento(2));
            pagamentos.Add(new Pagamento(3));

            foreach (var p in pagamentos)
            {
                Console.WriteLine(p.Id);
            }
         
             var ver = pagamentos.First(x => x.Id == 3);  
             Console.WriteLine(ver.Id);          
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
