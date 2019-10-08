using System;

namespace Proxy
{
    class RealSubject : Subject
    {
        public override void Requisicao()
        {
            Console.WriteLine("Chamando RealSubject.Request()");
        }
    }
}
