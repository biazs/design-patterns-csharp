using System;

namespace InjecaoDeDependencia
{
    class Empresa
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public IObjetoEndereco Endereco { get; set; }

        public Empresa( IObjetoEndereco objeto)
        {
            this.Endereco = objeto;
        }
    }
}
