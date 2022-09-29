using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora
{
    public class InputVariable 
    {
        public decimal numA { get; set; }
        public decimal numB { get; set; }

        public InputVariable(){}
        public InputVariable(decimal numa, decimal numb)
        {
            this.numA = numa;
            this.numB = numb;
        }
       
        public void Entrada(string modulo)
        {
            System.Console.WriteLine("Insira o Primeiro número :");
            numA = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira o Segundo número :");
            numB = decimal.Parse(Console.ReadLine());
        }
    }
}