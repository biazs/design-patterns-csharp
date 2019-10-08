using System;

namespace ChainResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
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
