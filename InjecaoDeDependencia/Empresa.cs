using System;

namespace InjecaoDeDependencia
{
    class Empresa 
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco _endereco;

        public IObjetoEndereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        /*
        public Empresa(IObjetoEndereco objeto)
        {
            this.Endereco = objeto;
        }
        */
    }
}
