using System;

namespace Bridge
{
    public class Filme : ICanal
    {
        const String canal = "Canal de Filmes";
        public string Canal()
        {
            return string.Format("Sintonizado no canal de filmes");
        }

        public string Status()
        {
            return string.Format("Voce esta assistindo - Os Vingadores");
        }
    }
}
