using System;

namespace ArrayTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var usuario = new int[5]{1,2,3,4,5};
            usuario[0] = 12;

            foreach (var item in usuario)
                System.Console.WriteLine(item);
            

            
            // System.Console.WriteLine(usuario[0]);
            // System.Console.WriteLine(usuario[1]);      
            // System.Console.WriteLine(usuario[2]);


        //    Tst cad = new Tst();
        //    System.Console.WriteLine(cad.Id = "0000");
               
        //    cad.Nome = "inacio";
        //    cad.Idade = "22";
           

           
        }

    }
    
    // public struct Tst
    // {       
    //     public Tst(string id,string nome,string idade)
    //     {
    //         this.Id = id;
    //         this.Nome = nome;
    //         this.Idade = idade;
    
    //     }
    //     public string Id;
    //     public string Idade;
    //     public string Nome;
                
    // }
      
}
