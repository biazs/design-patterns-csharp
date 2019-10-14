using System;

namespace Visitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteEmelementA)
        {
            Console.WriteLine("{0} visitado por {1}", concreteEmelementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementA(ConcreteElementB concreteEmelementB)
        {
            Console.WriteLine("{0} visitado por {1}", concreteEmelementB.GetType().Name, this.GetType().Name);
        }

    }
}
