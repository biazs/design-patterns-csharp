using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- DESIGN PATTERNS FLYWEIGHT -----");
            FabricaFlyweight fabrica = new FabricaFlyweight();

            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.Write("Qual tartaruga enviar para a tela: ");

                cor = Console.ReadLine();

                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("---------------");
            }

        }
    }
}
