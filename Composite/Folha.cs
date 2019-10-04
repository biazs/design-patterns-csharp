using System;

namespace Composite
{
    class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {

        }
        public override void Adicionar(Componente c)
        {
            Console.WriteLine("Nao e possivel adicionar a folha");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + nome);
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Nao e possivel remover a folha");
        }
    }
}
