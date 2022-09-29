using System;

namespace calculadora
{
    class Program : Operacoes
    {
        static void Main(string[] args)
        {

           Operacoes modulos = new Operacoes();
          
           Console.WriteLine("Console Calculadora");
           Console.WriteLine("Menu de Opções > 1:Soma || 2:Subração || 3:Divisão || 4:Multiplicação");
           Console.WriteLine("Qual operação deseja fazer:");
           int num = int.Parse(Console.ReadLine());

           switch (num)
           {
              case 1:
                modulos.ModuloSoma(1);
                break;

              case 2:
                modulos.ModuloSubtracao(2);
                break;

              case 3:
                modulos.ModuloDivisao(3);
                break;

              case 4:
                modulos.ModuloMultiplicacao(4);
                break;    

            default:
                Console.WriteLine("cabo amigão");
                break;
           }
        }
    }
}
