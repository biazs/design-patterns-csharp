using System;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSucessor(h2);
            h1.SetSucessor(h3);
            //h1.SetSucessor(h1);

            int[] requests = { 2, 11, 24, 34, 15, 8, 9, 22 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
