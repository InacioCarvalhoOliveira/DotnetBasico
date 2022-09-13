using System;
using System.Threading;

namespace cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start(6);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("M - min : 1m = 1 minuto");
            Console.WriteLine("S - seg : 10s = 10 segundos");
            Console.WriteLine("0 - sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string escolha  = Console.ReadLine().ToLower();
            char type = char.Parse(escolha.Substring(escolha.Length - 1, 1));
            int tempo = int.Parse(escolha.Substring(0,escolha.Length - 1));
            int tempSegundo = 1;
            int tempMinuto  = tempSegundo * 60;
            
            switch (type)
            {
                case 's': Start(tempo * tempSegundo);                     
                    break;

                case 'm':Start(tempo * tempMinuto);
                    break;
                    
                default:
                    break;
            }                
        }

        static void Start(int time)
        {
            
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);                                
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2500);
            
        }
    }
}
