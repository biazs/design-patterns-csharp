using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar livro
            Livro livro = new Livro("Joao", "Design Patterns", 10);
            livro.Exibe();

            //Criar Video
            Video video = new Video("Fabiana", "Video Aulas", 25, 3);
            video.Exibe();

            //Emprestar um video e mostrar na tela
            Console.WriteLine("\nEmprestando um video");
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");
            emprestado.Exibe();

            Console.WriteLine("\nDevolvendo um video");
            emprestado.DevolverItem("Carlos");
            emprestado.Exibe();

            Console.ReadKey();


        }
    }
}
