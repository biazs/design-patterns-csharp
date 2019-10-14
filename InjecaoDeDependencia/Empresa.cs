using System;

namespace InjecaoDeDependencia
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco Endereco { get; set; }

        /*
        public void setEndereco(IObjetoEndereco obj)
        {
            this.Endereco = obj;
        }
        */
        
        public Empresa()
        {
            this.Endereco = Localizador.getEndereco();
        }
        
    }
}
