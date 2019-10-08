using System;

namespace Flyweight
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            this.condicao = "Tartaruga dentro do casco ";
            this.acao = "rodando no chao - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}