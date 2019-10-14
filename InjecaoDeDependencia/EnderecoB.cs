using System;

namespace InjecaoDeDependencia
{
    public class EnderecoB : IObjetoEndereco
    {
        public string cidade { get; set; }
        public string UF { get; set; }
    }
}
