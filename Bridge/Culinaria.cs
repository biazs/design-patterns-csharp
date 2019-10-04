using System;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return string.Format("Sintonizado no canal de culinaria");
        }

        public string Status()
        {
            return string.Format("Voce esta assistindo - Receita de bolo de laranja");
        }
    }
}
