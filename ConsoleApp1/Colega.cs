using System;

namespace Mediator
{
    public abstract class Colega
    {
        protected Mediator mediador;

        protected Colega(Mediator mediador)
        {
            this.mediador = mediador;
        }
    }
}
