﻿using System;

namespace Mediator
{
    public class ColegaConcreto2 : Colega
    {
        public ColegaConcreto2(Mediator mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }
        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do colega 2: " + mensagem);
        }

    }
}