using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutencao elétrica residencial", 500, EProductType.Service);
           
            mouse.Id = 55;

            Console.WriteLine($"id: {mouse.Id}");
            Console.WriteLine($"nome do produto: {mouse.Name}");
            Console.WriteLine($"preço: {mouse.Price}");
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
            
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
            }
        
        
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType {
        Product = 1,
        Service = 2
    }
}
