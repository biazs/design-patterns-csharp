using System;

namespace Adapter
{
    //este eh o nosso Adapt - o objeto que sera adaptado
    public class RoboInimigo
    {        
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int DanoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo inimigo causou " + DanoAtaque + " de dano com o ataque Esmagar com as maos!");
        }
        public void AndarParaFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("O robo inimigo andou " + movimento + " passos para frente");
        }
        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("O robo inimigo vai contra " + piloto);
        }
    }
}
