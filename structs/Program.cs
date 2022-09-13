using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product item =new Product(5,"caneta",1.50);
            //item.Id = 5;
            System.Console.WriteLine(item.Id);
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine(item.Price);           
            
        }


    }

    public struct Product
    {

        public Product(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }

    }
    
}
