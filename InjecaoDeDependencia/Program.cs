using System;

namespace InjecaoDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA endA = new EnderecoA();
            endA.Rua = "Rua endereco A";
            endA.Numero = 10;

            EnderecoB endB = new EnderecoB();
            endB.cidade = "Belo Horizonte";
            endB.UF = "MG";

            Empresa empresa1 = new Empresa();
            
            
            Empresa empresa2 = new Empresa();            


            Console.ReadKey();
        }
    }
}
