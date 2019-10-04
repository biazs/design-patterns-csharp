using System;

namespace Bridge
{
    public class Documentario : ICanal
    {
        const String canal = "Canal de Filmes";
        public string Canal()
        {
            return string.Format("Sintonizado no canal de documentario");
        }

        public string Status()
        {
            return string.Format("Voce esta assistindo - A origem de tudo");
        }
    }
}
