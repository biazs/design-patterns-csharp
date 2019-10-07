using System;

namespace Decorator
{
    class Video : ItemBiblioteca
    {
        public string  Diretor { get; set; }
        public string  Titulo { get; set; }
        public int  MinutosDuracao { get; set; }

        public Video(string diretor, string titulo, int minutosDuracao, int numerocopias)
        {
            Diretor = diretor;
            Titulo = titulo;
            MinutosDuracao = minutosDuracao;
            this.NumeroCopias = numerocopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo ----");
            Console.WriteLine(" Diretor: " + this.Diretor);
            Console.WriteLine(" Titulo: " + this.Titulo);
            Console.WriteLine(" Duracao: " + this.MinutosDuracao);
            Console.WriteLine(" Copias: " + this.NumeroCopias);
        }
    }
}
