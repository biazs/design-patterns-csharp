using System;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteEmelementA);

       

        public abstract void VisitConcreteElementA(ConcreteElementB concreteEmelementB);
    }
}
