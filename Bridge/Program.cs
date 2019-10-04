using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv minhaTv = new SmartTv();
            Console.WriteLine("Selecione um canal");
            Console.WriteLine("1 - Filme \n2 - Documentario \n3 - Culinaria");
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    minhaTv.canal_atual = new Filme();
                    break;
                case '2':
                    minhaTv.canal_atual = new Documentario();
                    break;
                case '3':
                    minhaTv.canal_atual = new Culinaria();
                    break;
            }
            Console.WriteLine();
            minhaTv.ExibeCanalSintonizado();
            minhaTv.PlayTv();

            Console.ReadKey();
        }
    }
}
