using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace calculadora
{
    public class Operacoes : InputVariable
    {
        InputVariable chamada = new InputVariable();

        public decimal Soma { get; set; }
        public decimal Subtracao { get; set; }
        public decimal Divisao { get; set; }
        public decimal Multiplicacao { get; set; }

        public Operacoes(){}
        public Operacoes(decimal soma, decimal subtracao, decimal divisao, decimal multiplicacao)
        {
            this.Soma = soma;
            this.Subtracao = subtracao;
            this.Divisao = divisao;
            this.Multiplicacao = multiplicacao;
        }

        public void ModuloSoma(int id)
        {
            System.Console.WriteLine("Modulo de Soma");            
            chamada.Entrada("ModSoma");
            Soma = chamada.numA + chamada.numB;
            System.Console.WriteLine("Resultado :"+ Soma); 

        }
        
        public void ModuloSubtracao(int id)
        {
            System.Console.WriteLine("Modulo de Subtração");
            chamada.Entrada("ModSubtracao");
            Subtracao = chamada.numA - chamada.numB;
            System.Console.WriteLine("Resultado :"+ Subtracao);                  
            
        }

        public void ModuloDivisao(int id)
        {
            System.Console.WriteLine("Modulo de Divisão");
            chamada.Entrada("ModDivisao");
            Divisao = chamada.numA / chamada.numB;
            System.Console.WriteLine("Resultado :"+ Divisao);                  
            
        }

        public void ModuloMultiplicacao(int id)
        {
            System.Console.WriteLine("Modulo de Multiplicação");
            chamada.Entrada("ModMultiplicacao");
            Multiplicacao = chamada.numA * chamada.numB;
            System.Console.WriteLine("Resultado :"+ Multiplicacao);                  
            
        }        
    }
}