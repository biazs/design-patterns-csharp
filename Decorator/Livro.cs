using System;

namespace Decorator
{
    class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Livro(string autor, string titulo, int numerocopias)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.NumeroCopias = numerocopias;
        }
        public override void Exibe()
        {
            Console.WriteLine("\nLivro ----");
            Console.WriteLine(" Autor: "+this.Autor);
            Console.WriteLine(" Titulo: " + this.Titulo);
            Console.WriteLine(" Copias: " + this.NumeroCopias);
        }
    }
}
