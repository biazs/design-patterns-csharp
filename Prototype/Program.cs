using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcPermantente = new FuncionarioPermanente();
            funcPermantente.Nome = "Joao";
            funcPermantente.Idade = 30;
            funcPermantente.Tipo = "Permanente";

            FuncionarioPermanente cloneFuncPermanente = (FuncionarioPermanente)funcPermantente.Clone();
            cloneFuncPermanente.Nome = "Carlos";
            cloneFuncPermanente.Idade = 40;

            Console.WriteLine("Detalhes do funcionario permanente:");
            Console.WriteLine("Nome: {0} - Idade: {1} - Tipo: {2}", funcPermantente.Nome, funcPermantente.Idade, funcPermantente.Tipo);

            Console.WriteLine("\nDetalhes do funcionario permanente CLONADO:");
            Console.WriteLine("Nome: {0} - Idade: {1} - Tipo: {2}", cloneFuncPermanente.Nome, cloneFuncPermanente.Idade, cloneFuncPermanente.Tipo);

            Console.ReadKey();

        }
    }
}
