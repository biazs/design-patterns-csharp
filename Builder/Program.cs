using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante();

            ICelular celularBuilder = null;

            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("Um celular foi construido: \n{0}", celularBuilder.Celular.Nome);

            celularBuilder = new IphoneBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("\nUm novo celular foi construido: \n{0}", celularBuilder.Celular.Nome);

            Console.ReadKey();
        }
    }
}
