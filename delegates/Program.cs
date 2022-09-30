using System;

namespace delegates
{
    class Program

    {
        //função que realiza a inserção do Valor do Pagamnento 
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago valor de {valor}");            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(25);

            //trabalando com Events -- eventos 
            var sala = new Sala(3);
            sala.SalaSemAssentosDisponiveis += OnSalaSemAssentosDisponiveis;
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();
            sala.ReservarAssento();
        } 
        static void OnSalaSemAssentosDisponiveis(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!!");
            
        }
        public class Pagamento
        {
            /*
              supondo que já temos uma função que reliza o pagamento, faremos então que 
              esta função apenas aponte para a função que já existe e trata o Método Pagar
            */
            public delegate void Pagar(double valor);
         
        }
    }
    //trabalando com Events -- eventos 
    public class Sala
    {
        private int AssentosEmUso = 0;
        public int Assentos { get; set; }
        
        public void ReservarAssento()
        {
          AssentosEmUso++;
          if (AssentosEmUso >= Assentos)
          {
            OnSalaSemAssentosDisponiveis(EventArgs.Empty);
          }
          else{Console.WriteLine("Assentos indisponíveis");
          }
        }
        public event EventHandler SalaSemAssentosDisponiveis;
        protected virtual void OnSalaSemAssentosDisponiveis(EventArgs e)
        {
            EventHandler handler = SalaSemAssentosDisponiveis;
            handler?.Invoke(this,e);
        }
        
        public Sala( int assentos)
        {
            Assentos = assentos;
            AssentosEmUso = 0;
        }

    }
}
