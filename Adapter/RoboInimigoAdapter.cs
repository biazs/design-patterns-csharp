using System;

namespace Adapter
{
    //eh o adapter - adaptador do objeto Robo com Tanque
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;

        //Passa para o metodo construtor o robo que sera adaptado
        public RoboInimigoAdapter(RoboInimigo novo_robo)
        {
            this.robo = novo_robo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarParaFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
