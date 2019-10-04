using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo RX2018 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();

            IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(R2D2);

            Console.WriteLine("=========== ROBO ===========");
            R2D2.ReagirContraHumano("Fabiana");
            R2D2.AndarParaFrente();
            R2D2.EsmagarComMaos();

            Console.WriteLine("=========== TANQUE ===========");
            RX2018.Pilotar("Joao");
            RX2018.Movimenta();
            RX2018.ArmaFogo();

            Console.WriteLine("========= ROBO ADAPTADO==========");
            robo_adapter.Pilotar("Maria");
            robo_adapter.Movimenta();
            robo_adapter.ArmaFogo();


            Console.ReadKey();
        }
    }
}
