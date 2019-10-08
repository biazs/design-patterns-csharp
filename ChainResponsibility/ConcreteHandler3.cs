using System;

namespace ChainResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} Handle request {1}", this.GetType().Name, request);
            }
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }
}

