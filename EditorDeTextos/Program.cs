using System;
using System.IO;

namespace EditorDeTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("o que deseja fazer?");
            System.Console.WriteLine("1 - abrir arquivo");
            System.Console.WriteLine("2 - criar novo arquivo");
            System.Console.WriteLine("0 - sair");
            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 0: System.Environment.Exit(0);break;
                case 1: Abrir();break;
                case 2: Editar();break;
                default: Menu();break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            System.Console.WriteLine("qual caminho do arquivo?");
            string caminho  = Console.ReadLine();

            using(var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                System.Console.WriteLine(texto);
            }
            System.Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }
        static void Editar()
        {
            Console.Clear();
            System.Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            System.Console.WriteLine("-----------------------");
            string texto = "";
            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Salvar(texto);

            Console.Write(texto);
        }
        static void Salvar(string texto)
        {
            Console.Clear();
            System.Console.WriteLine("Onde deseja salvar seu arquivo?");
            var caminho =  Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho))
            {
                arquivo.Write(texto);
            }

            System.Console.WriteLine($"Arquivo {caminho} salvo com sucesso!!");
            Menu();
        }
    
    }
}
