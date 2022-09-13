using System;


namespace editorHtml
{
    public class Menu
    {
        public static void Show()
        {
           Console.Clear();
           Console.BackgroundColor = ConsoleColor.DarkGreen;
           Console.ForegroundColor = ConsoleColor.Cyan;   
        }

        public static void DrawScreen()
        {
            OpenScreen();
                ShowContent();
            CloseScreen();
                    WriteOptions();                 
        }   
        public static void OpenScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void ShowContent()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
        }
        public static void CloseScreen()
        {
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
                
            }
            Console.Write("+");
            Console.Write("\n\n");
        }
        public static void WriteOptions()
        {
           
            //cursor principal 
            Console.SetCursorPosition(0,14);
            Console.SetCursorPosition(2,2);
            Console.Write("teste");
            

            
        }
    
    }    

}